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
        public DESTINOS()
        {
            InitializeComponent();
        }

 

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (rbtEaArgentina.Checked==true)
            {
                aerolinea.asiento=numAsientoArg;
                aerolinea.aerolinea = "easyJet (U2)";
                numAsientoArg++;
                aerolinea.destino.paisSalida = "Ecuador";
                aerolinea.destino.paisSalida = "Argentina";

            }
            
            
            
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
