using LmjHotelBusiness.Services;
using LmjHotelBusiness.DAO;
using LmjHotelBusiness.DAO.Contratos;
using LmjHotelBusiness.Models;
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
    public partial class FrmQuartos : Form
    {
        private QuartoService quartoService;

        public FrmQuartos()
        {
            InitializeComponent();
        }

        public void SetQuartoService(QuartoService service)
        {
            quartoService = service;
        }

        private void FrmQuartos_Load(object sender, EventArgs e)
        {
        }

        private void btnListaQuartosDisponiveis_Click(object sender, EventArgs e)
        {
            dataGridListaDeQuartos.DataSource = quartoService.ListarQuartosDisponiveis();
        }
    }
}
