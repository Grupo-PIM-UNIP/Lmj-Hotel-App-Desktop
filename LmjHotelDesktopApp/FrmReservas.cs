using LmjHotelBusiness.Models;
using LmjHotelBusiness.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LmjHotelDesktopApp
{
    public partial class FrmReservas : Form
    {
        private ReservaService _reservaService;

        public FrmReservas()
        {
            InitializeComponent();
        }

        public void SetReservaService(ReservaService reservaService)
        {
            _reservaService = reservaService;
        }

        private void FrmReservas_Load(object sender, EventArgs e)
        {
        }

        private void btnVoltarTelaPrincipal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnListarTodasReservas_Click(object sender, EventArgs e)
        {
            if (dataGridListagemReservas.Rows.Count == 0)
            {
                DefinirColunasDataGrid();
                var reservas = _reservaService.ListaTodasReservas();
                DefinirLinhasDataGrid(reservas);
            }
        }

        private void btnListarReservasAtivas_Click(object sender, EventArgs e)
        {

        }

        private void DefinirColunasDataGrid()
        {
            dataGridListagemReservas.Columns.Add("DataInicio", "Início");
            dataGridListagemReservas.Columns.Add("DataFim", "Fim");
            dataGridListagemReservas.Columns.Add("NumeroQuarto", "Quarto");
            dataGridListagemReservas.Columns.Add("Hospede", "Hóspede");
            dataGridListagemReservas.Columns.Add("Telefone", "Telefone");

            DataGridViewColumn[] colunas = new DataGridViewColumn[] { dataGridListagemReservas.Columns[3] };
            RegularColunaDataGrid(colunas);
        }
        
        private void RegularColunaDataGrid(DataGridViewColumn[] colunas)
        {
            for (int i=0; i<colunas.Length; i++)
            {
                colunas[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        } 
 

        private void DefinirLinhasDataGrid(List<Reserva> reservas)
        {
            foreach (var item in reservas)
            {
                DateTime inicio = item.DataInicio;
                DateTime fim = item.DataFim;
                string numeroQuarto = item.Quarto.Numero;
                string nomeHospede = item.Hospede.Nome + " " + item.Hospede.Sobrenome;
                string telefone = item.Hospede.Telefone;

                dataGridListagemReservas.Rows.Add(
                    inicio.ToShortDateString(),
                    fim.ToShortDateString(),
                    numeroQuarto,
                    nomeHospede,
                    telefone);
            }
        }
    }
}
