using LmjHotelBusiness.Models;
using LmjHotelBusiness.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LmjHotelDesktopApp
{
    /* Como os formulários do Windows Form tem suas próprias Controllers disponíveis em suas estruturas,
       utilizamos essa classe para interagir com a classe de ReservaService do LmjHotelBusiness,
       receber as operações correspondentes as regras de negócio impostas */
    public partial class FrmReservas : Form
    {
        //Declarando a dependência com a classe ReservaService
        private ReservaService _reservaService;

        public FrmReservas()
        {
            InitializeComponent();
        }

        //Injetando a dependência com a classe ReservaService manualmente
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
            try
            {
                var reservas = _reservaService.ListaTodasReservas();
                MontarListagemNoDateGridView(reservas);
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(
                    "" + ex.Message,
                    "Error!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
        }

        private void btnListarReservasAtivas_Click(object sender, EventArgs e)
        {
            try
            {
                var reservas = _reservaService.ListaReservasAtivas();
                MontarListagemNoDateGridView(reservas);
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(
                    "" + ex.Message,
                    "Error!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
        }

        private void btnListarReservasInicioHoje_Click(object sender, EventArgs e)
        {
            try
            {
                var reservas = _reservaService.ListarReservasQueIniciamHoje();
                MontarListagemNoDateGridView(reservas);
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(
                    "" + ex.Message,
                    "Error!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
        }

        /* Método Genérico usado por todos os métodos de listagem de reservas, na qual tem a mesma,
           estrutura, mudando apenas as informações que serão exibidas por estes. */
        private void MontarListagemNoDateGridView(List<Reserva> reservas)
        {
            var dataGridVazio = VerificarSeDataGridEstaVazio();
            if (!dataGridVazio)
            {
                dataGridListagemReservas.Columns.Clear();
                dataGridListagemReservas.Rows.Clear();
            }

            DefinirColunasDataGrid();
            DefinirLinhasDataGrid(reservas);
        }

        private bool VerificarSeDataGridEstaVazio()
        {
            if (dataGridListagemReservas.Rows.Count == 0)
            {
                return true;
            }
            return false;
        }

        //Definição das colunas do DataGridView do Windows Form.
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

        //Método usado para aumentar tamanho de uma ou mais coluna específica conforme o seu conteúdo.
        private void RegularColunaDataGrid(DataGridViewColumn[] colunas)
        {
            for (int i = 0; i < colunas.Length; i++)
            {
                colunas[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        //Definição das linhas do DataGridView do Windows Form.
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
