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

    public partial class fDESTINOS : Form
    {
        static public int numAsientoArg = 1;
        static public int numAsientoChi = 1;
        static public int numAsientoBra = 1;

        public struct Destino
        {
            public String paisSalida;
            public String paisLLegada;
            public double precio;
        }
        public struct Aerolinea
        {
            public int asiento;
            public String aerolinea;
            public Destino destino;
        }

        static public Aerolinea Info;
        public fDESTINOS()
        {
            InitializeComponent();
            Info.destino.paisSalida = "Ecuador";
        }

        private void DESTINOS_Load_1(object sender, EventArgs e)
        {
            btnSiguiente.Enabled = false;
            if (Info.destino.paisLLegada=="Argentina")
            {
                rbtEaArgentina.Checked = true;
                btnSiguiente.Enabled = true;
            }
            else
            {
                if (Info.destino.paisLLegada == "Brasil")
                {
                    rbtEaBrasil.Checked = true;
                    btnSiguiente.Enabled = true;
                }
                else
                {
                    if (Info.destino.paisLLegada == "Chile")
                    {
                        rbtEaChile.Checked = true;
                        btnSiguiente.Enabled = true;
                    }
                    else
                    {
                        if (Info.destino.paisLLegada == "")
                        {
                            rbtEaArgentina.Checked= false;
                            rbtEaBrasil.Checked= false;
                            rbtEaChile.Checked= false;
                            btnSiguiente.Enabled = false;   
                        }
                    }
                }
            }
            
            lblSinAsienArg.Hide();
            lblSinAsienChi.Hide();
            lblSinAsienBra.Hide();
            

            if (numAsientoArg>50)
            {
                lblSinAsienArg.Show();
            }
            if (numAsientoBra > 50)
            {
                lblSinAsienBra.Show();
            }
            if (numAsientoChi > 50)
            {
                lblSinAsienChi.Show();
            }

        }

        private void rbtEaChile_CheckedChanged(object sender, EventArgs e)
        {

            if (rbtEaChile.Checked==true && numAsientoChi<=50)
            {
                Info.asiento = numAsientoChi;
                Info.aerolinea = "Ryanair (FR)";
                Info.destino.paisLLegada = "Chile";
                Info.destino.precio = 336;
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
                Info.asiento = numAsientoBra;
                Info.aerolinea = "Wizz Air (W6)";
                Info.destino.paisLLegada = "Brasil";
                Info.destino.precio = 210;
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
                Info.asiento = numAsientoArg;
                Info.aerolinea = "easyJet (U2)";
                Info.destino.paisLLegada = "Argentina";
                Info.destino.precio = 460;
                btnSiguiente.Enabled = true;
            }
            else
            {
                btnSiguiente.Enabled = false;
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            fFACTURA factura = new fFACTURA();
            this.Hide();
            factura.ShowDialog();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            fDATOS datos = new fDATOS();
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
