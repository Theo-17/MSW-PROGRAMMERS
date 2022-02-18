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
        
        public struct Aerolinea
        {
            public int asiento;
            public String aerolinea;
            public Destino destino;
        }

        public struct Destino
        {
            public String paisSalida;
            public String paisLLegada;
            public double precio;
        }

    
        Aerolinea aerolinea;

        int numAsientoArg = 1;
        int numAsientoChi = 52;
        int numAsientoBra = 1;
        public DESTINOS()
        {
            InitializeComponent();
        }

        private void rbtEaChile_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtEaChile.Checked == true && numAsientoChi <= 50)
            {
                aerolinea.asiento = numAsientoChi;
                aerolinea.aerolinea = "Ryanair (FR)";
                aerolinea.destino.paisSalida = "Ecuador";
                aerolinea.destino.paisSalida = "Chile";
                aerolinea.destino.precio = 336;
                btnSiguiente.Enabled = true;
            }
            else
            {
                btnSiguiente.Enabled = false;
            }

        }

        private void rbtEaArgentina_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtEaArgentina.Checked == true && numAsientoArg <= 50)
            {
                aerolinea.asiento = numAsientoArg;
                aerolinea.aerolinea = "easyJet (U2)";
                numAsientoArg++;
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
            if (rbtEaBrasil.Checked == true && numAsientoBra <= 50)
            {
                aerolinea.asiento = numAsientoBra;
                aerolinea.aerolinea = "Wizz Air (W6)";
                numAsientoBra++;
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
