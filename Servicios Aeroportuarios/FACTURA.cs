﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Servicios_Aeroportuarios
{
    public partial class FACTURA : Form
    {
        public FACTURA()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DESTINOS destinos = new DESTINOS();
            this.Hide();
            destinos.Show();
        }
    }
}
