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

namespace LmjHotelDesktopApp
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void ListarQuartosDisponiveis(object sender, EventArgs e)
        {
            var frmQuartos = new FrmQuartos();
            frmQuartos.SetQuartoService(new QuartoService());
            frmQuartos.ShowDialog();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
