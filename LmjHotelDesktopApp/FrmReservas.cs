﻿using System;
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
        public FrmReservas()
        {
            InitializeComponent();
        }

        private void btnVoltarTelaPrincipal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
