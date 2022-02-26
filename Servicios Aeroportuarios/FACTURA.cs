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
            txtAerolinea.AppendText(DESTINOS.Info.aerolinea);
            
            
            if (DESTINOS.Info.destino.paisLLegada == "Chile")
            {
                txtTime.Text = "7:00 am";
            }
            if (DESTINOS.Info.destino.paisLLegada == "Brasil")
            {
                txtTime.Text = "11:00 am";
            }
            if (DESTINOS.Info.destino.paisLLegada == "Argentina")
            {
                txtTime.Text = "15:00 pm";
            }

            txtName.AppendText(Form1.persona.nombre+" "+Form1.persona.apellido);
            txtFrom.AppendText(DESTINOS.Info.destino.paisSalida);
            txtTo.AppendText(DESTINOS.Info.destino.paisLLegada);

            DateTime fecha = fechaVuelo.Value;
            fechaVuelo.Value = DateTime.Today.AddDays(10);
            txtDate.AppendText(Convert.ToString(fechaVuelo.Value.ToShortDateString()));

            rtbDatoTotal.AppendText(Form1.persona.apellido+'/'+Form1.persona.nombre+"\n\nAsiento: "+ 
                Convert.ToString(DESTINOS.Info.asiento)+'\n'+'\n'+ DESTINOS.Info.destino.paisSalida+'/'+ DESTINOS.Info.destino.paisLLegada +
                "\n\nHora Salida: "+ txtTime.Text);
     
        }

        private void btnNuevaCompra_Click(object sender, EventArgs e)
        {
    
            if (DESTINOS.Info.destino.paisLLegada == "Chile")
            {
                DESTINOS.numAsientoChi++;
            }
            if (DESTINOS.Info.destino.paisLLegada == "Brasil")
            {
                DESTINOS.numAsientoBra++;
            }
            if (DESTINOS.Info.destino.paisLLegada == "Arg")
            {
                DESTINOS.numAsientoArg++;
            }

            Form1 formaInicial = new Form1();
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
