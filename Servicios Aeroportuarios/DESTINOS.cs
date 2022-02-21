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

        private void DESTINOS_Load(object sender, EventArgs e)
        {
            lblSinAsienArg.Hide();
            lblSinAsienChi.Hide();
            lblSinAsienBra.Hide();
            if (Variables.numAsientoArg >50)
            {
                lblSinAsienArg.Show();
            }
            if (Variables.numAsientoChi > 50)
            {
                lblSinAsienChi.Show();
            }
            if (Variables.numAsientoBra > 50)
            {
                lblSinAsienBra.Show();
            }
        }

        private void rbtEaChile_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtEaChile.Checked == true && Variables.numAsientoChi <= 50)
            {
                
                Variables.Aerolinea.asiento = Variables.numAsientoChi;
                Variables.Aerolinea.aerolinea = "Ryanair (FR)";
                Variables.Destino.paisSalida = "Ecuador";
                Variables.Destino.paisLLegada = "Chile";
                Variables.Destino.precio = 336;
                btnSiguiente.Enabled = true;
            }
            else
            {
                btnSiguiente.Enabled = false;
            }

        }
        /*
        private void rbtEaArgentina_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtEaArgentina.Checked == true && Variables.numAsientoArg <= 50)
            {
                aerolinea.asiento = Variables.numAsientoArg;
                aerolinea.aerolinea = "easyJet (U2)";
                aerolinea.destino.paisSalida = "Ecuador";
                aerolinea.destino.paisSalida = "Argentina";
                aerolinea.destino.precio = 460;
                btnSiguiente.Enabled = true;
            }
            else
            {
                btnSiguiente.Enabled = false;
            }
        }

        private void rbtEaBrasil_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtEaBrasil.Checked == true && Variables.numAsientoBra <= 50)
            {
                aerolinea.asiento = Variables.numAsientoBra;
                aerolinea.aerolinea = "Wizz Air (W6)";
                aerolinea.destino.paisSalida = "Ecuador";
                aerolinea.destino.paisSalida = "Brasil";
                aerolinea.destino.precio = 210;
                btnSiguiente.Enabled = true;
            }
            else
            {
                btnSiguiente.Enabled = false;
            }
        }
        */
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            FACTURA factura = new FACTURA();
            this.Hide();
            factura.ShowDialog();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Form1 datos = new Form1();
            this.Hide();
            datos.ShowDialog();
        }

        private void lnkRyanair_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lnkRyanair.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.ryanair.com/fr/fr");
        }

        private void lnkWizz_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lnkWizz.LinkVisited = true;
            System.Diagnostics.Process.Start("https://wizzair.com/#/");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lnkEasyJet.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.easyjet.com/es");
        }

        
    }
}
