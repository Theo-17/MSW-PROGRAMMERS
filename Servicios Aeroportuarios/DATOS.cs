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
    public partial class Form1 : Form
    {

        /*
         * EJEMPLO DECLARACION DE ESTRUCTURA
        public struct Aerolinea
        {
            public int asiento;
            public String aerolinea;
            public Destino destino;

        }
        static public Aerolinea Info;




        public struct Persona
        {
            public String nombre;
        }


        static public Persona persona;



        */


        public Form1()
        {
            InitializeComponent();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            DESTINOS destino = new DESTINOS();
            this.Hide();
            destino.ShowDialog();

        }


        private void lblDatos_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //txaDescripcion.AppendText("Apellidos: " + txtApellidos.Text);
        }


        //Declarar variables
        public struct Persona
        {
            public String nombre;
            public String apellido;
            public String lugarDeNacimiento;
            public String correo;
            public String celular;
            public String pasaporte;
            public String sexo;

        }



        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            txaDescripcion.AppendText("Nombres: " + txtNombres.Text);
            txaDescripcion.AppendText("Apellidos: " + txtApellidos.Text);
        }
    }
}
