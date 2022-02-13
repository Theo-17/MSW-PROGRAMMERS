using System;
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
    public partial class DESTINOS : Form
    {
        public DESTINOS()
        {
            InitializeComponent();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            FACTURA aerolineas = new FACTURA();
            this.Hide();
            aerolineas.ShowDialog();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Form1 datos = new Form1();
            this.Hide();
            datos.ShowDialog();
        }
    }
}
