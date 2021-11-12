using LmjHotelBusiness.Models;
using LmjHotelBusiness.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LmjHotelDesktopApp
{
    public partial class FrmQuartos : Form
    {
        private QuartoService _quartoService;

        public FrmQuartos()
        {
            InitializeComponent();
        }

        public void SetQuartoService(QuartoService quartoService)
        {
            _quartoService = quartoService;
        }

        private void FrmQuartos_Load(object sender, EventArgs e)
        {
        }

        private void btnVoltarTelaPrincipal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnListaQuartosDisponiveis_Click(object sender, EventArgs e)
        {
            ListarQuartos(btnListaQuartosDisponiveis);
        }

        private void btnListarQuartosOcupados_Click(object sender, EventArgs e)
        {
            ListarQuartos(btnListarQuartosOcupados);
        }

        private void ListarQuartos(Button button)
        {
            List<Quarto> quartos = new List<Quarto>();

            try
            {
                if (button == btnListaQuartosDisponiveis)
                {
                    quartos = _quartoService.ListarQuartosDisponiveis();
                }
                else
                {
                    quartos = _quartoService.ListarQuartosOcupados();
                }

                dataGridListaDeQuartos.DataSource = quartos;
                DataGridViewColumn[] columns = new DataGridViewColumn[] { dataGridListaDeQuartos.Columns[0] };
                DeixarColunaInvisivelDGV(columns);

                string[] cabecalhos = new string[] { "Número", "Status" };
                DefinirCabecalhosPersonalizadosDGV(cabecalhos);
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show("" + ex.Message,
                    "Error!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
        }

        private void DeixarColunaInvisivelDGV(DataGridViewColumn[] coluna)
        {
            for (int i = 0; i < coluna.Length; i++)
            {
                coluna[i].Visible = false;
            }
        }

        private void DefinirCabecalhosPersonalizadosDGV(string[] cabecalho)
        {
            int indice = 0;
            foreach (DataGridViewColumn coluna in dataGridListaDeQuartos.Columns)
            {
                if (coluna.Visible)
                {
                    coluna.HeaderText = cabecalho[indice];
                    indice++;
                }
            }
        }
    }
}
