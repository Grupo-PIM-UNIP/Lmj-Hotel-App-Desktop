using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LmjHotelBusiness.Services;
using System.Windows.Forms;
using DatabaseConfig;

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
            frmQuartos.SetQuartoService(new QuartoService());
            frmQuartos.ShowDialog();
        }

        private void toolStripConsultarReservas_Click(object sender, EventArgs e)
        {
            var frmReservas = new FrmReservas();
            frmReservas.SetReservaService(new ReservaService());
            frmReservas.ShowDialog();
        }

        private void toolStripFecharAplicacao_Click(object sender, EventArgs e)
        {
            DbSqlServer.FecharConexao();
            this.Close();
        }
    }
}
