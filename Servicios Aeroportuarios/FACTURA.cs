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
    public partial class fFACTURA : Form
    {

        public fFACTURA()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fDESTINOS destinos = new fDESTINOS();
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


            txtAsiento.AppendText(Convert.ToString(fDESTINOS.Info.asiento));
            txtAerolinea.AppendText(fDESTINOS.Info.aerolinea);
            
            
            if (fDESTINOS.Info.destino.paisLLegada == "Chile")
            {
                txtTime.Text = "7:00 am";
            }
            if (fDESTINOS.Info.destino.paisLLegada == "Brasil")
            {
                txtTime.Text = "11:00 am";
            }
            if (fDESTINOS.Info.destino.paisLLegada == "Argentina")
            {
                txtTime.Text = "15:00 pm";
            }

            txtName.AppendText(fDATOS.persona.nombre+" "+fDATOS.persona.apellido);
            txtFrom.AppendText(fDESTINOS.Info.destino.paisSalida);
            txtTo.AppendText(fDESTINOS.Info.destino.paisLLegada);

            DateTime fecha = dtpVuelo.Value;
            dtpVuelo.Value = DateTime.Today.AddDays(10);
            txtDate.AppendText(Convert.ToString(dtpVuelo.Value.ToShortDateString()));

            rtbDatoTotal.AppendText(fDATOS.persona.apellido+'/'+fDATOS.persona.nombre+"\n\nAsiento: "+ 
                Convert.ToString(fDESTINOS.Info.asiento)+'\n'+'\n'+ fDESTINOS.Info.destino.paisSalida+'/'+ fDESTINOS.Info.destino.paisLLegada +
                "\n\nHora Salida: "+ txtTime.Text);
     
        }

        private void btnNuevaCompra_Click(object sender, EventArgs e)
        {
            
            if (fDESTINOS.Info.destino.paisLLegada == "Chile")
            {
                fDESTINOS.numAsientoChi++;
            }
            if (fDESTINOS.Info.destino.paisLLegada == "Brasil")
            {
                fDESTINOS.numAsientoBra++;
            }
            if (fDESTINOS.Info.destino.paisLLegada == "Argentina")
            {
                fDESTINOS.numAsientoArg++;
            }
            fDESTINOS.Info.destino.paisLLegada = "";

            fDATOS.persona.apellido = "";
            fDATOS.persona.nombre = "";
            fDATOS.aux3 = 0;
            fDATOS.persona.correo = "";
            fDATOS.persona.sexo = "";
            fDATOS.persona.lugarDeNacimiento = "";
            
            fDATOS formaInicial = new fDATOS();
            this.Hide();
            formaInicial.Show();

        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Estás seguro de cerrar el programa", "CERRAR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
