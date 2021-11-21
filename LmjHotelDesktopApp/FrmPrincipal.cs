using DatabaseConfig;
using LmjHotelBusiness.Services;
using System;
using System.Windows.Forms;

namespace LmjHotelDesktopApp
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
        }

        private void toolStripConsultarQuartos_Click(object sender, EventArgs e)
        {
            var frmQuartos = new FrmQuartos();

            //Abre instância de QuartoService toda vez que este formulário for aberto.
            frmQuartos.SetQuartoService(new QuartoService());
            frmQuartos.ShowDialog();
        }

        private void toolStripConsultarReservas_Click(object sender, EventArgs e)
        {
            var frmReservas = new FrmReservas();

            //Abre instância de ReservaService toda vez que este formulário for aberto.
            frmReservas.SetReservaService(new ReservaService());
            frmReservas.ShowDialog();
        }

        private void toolStripFecharAplicacao_Click(object sender, EventArgs e)
        {
            try
            {
                DbSqlServer.FecharConexao();
                this.Close();
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
    }
}
