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

        private void FACTURA_Load(object sender, EventArgs e)
        {
            /*
            DESTINOS.numAsientoArg=1;
            DESTINOS.numAsientoBra = 1;
            DESTINOS.numAsientoChi = 1;

            txtAsiento.AppendText(Convert.ToString(DESTINOS.Info.asiento));
            txtAerolinea.AppendText(DESTINOS.Info.aerolinea);
            */


            txtAsiento.AppendText(Convert.ToString(DESTINOS.Info.asiento));
            txtAerolinea.AppendText(Convert.ToString(DESTINOS.Info.aerolinea));
            txtTime.Text = "7:00 am";

        }
    }
}
