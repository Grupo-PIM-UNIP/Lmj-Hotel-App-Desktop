using LmjHotelBusiness.Models;
using LmjHotelBusiness.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LmjHotelDesktopApp
{
    /* Como os formulários do Windows Form tem suas próprias Controllers disponíveis em suas estruturas,
       utilizamos essa classe para interagir com a classe de QuartoService do LmjHotelBusiness,
       receber as operações correspondentes as regras de negócio impostas */
    public partial class FrmQuartos : Form
    {
        //Declarando a dependência com a classe ReservaService
        private QuartoService _quartoService;

        public FrmQuartos()
        {
            InitializeComponent();
        }

        //Injetando a dependência com a classe QuartoService manualmente
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

        /* Método Genérico usado por todos os métodos de listagem de quartos, na qual tem a mesma,
           estrutura, mudando apenas as informações que serão exibidas por estes. */
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
