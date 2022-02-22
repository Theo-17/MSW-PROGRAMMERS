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


        //Declarar variables **************************************************
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
        public struct Fecha
        {
            public String nacimiento;
        }
        static public Persona persona;
        static public Fecha fN;





        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            txaDescripcion.AppendText("Nombres: " + txtNombres.Text+"\n");
            txaDescripcion.AppendText("Apellidos: " + txtApellidos.Text+"\n");
            txaDescripcion.AppendText("Pasaporte: " + txtPasaporte.Text + "\n");
            txaDescripcion.AppendText("Lugar de nacimiento: " + txtLugar.Text + ",ECU"+"\n");
            txaDescripcion.AppendText("cell: " + txtCelular.Text + "\n");
            txaDescripcion.AppendText("Email: " + txtEmail.Text + "\n");
            txaDescripcion.AppendText("Sexo: "+persona.sexo+"\n");
            DateTime fecha = dateNacimiento.Value;
            fN.nacimiento = fecha.ToShortDateString();
            txaDescripcion.AppendText("Fecha de nacimiento: " + fN.nacimiento + "\n");

        }

        private void rbtM_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtM.Checked == true)
            {
                persona.sexo = "Masculino";
            }
        }

        private void rbtF_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtF.Checked == true)
            {
                persona.sexo = "Femenino";
            }

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            persona.apellido =  txtApellidos.Text;
            persona.nombre = txtNombres.Text;
            persona.pasaporte = txtPasaporte.Text;  
            persona.correo = txtEmail.Text; 
            persona.celular = txtCelular.Text;
            persona.lugarDeNacimiento = txtLugar.Text;
            DateTime fecha = dateNacimiento.Value;
            fN.nacimiento = fecha.ToShortDateString();
            MessageBox.Show("Datos Guardados Corectamente", "CONFIRMAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnSiguiente.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txaDescripcion.Clear(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(DESTINOS.numAsientoArg>50 && DESTINOS.numAsientoBra > 50 && DESTINOS.numAsientoChi > 50)
            {
                btnSiguiente.Enabled = false;
                MessageBox.Show("NO HAY VUELOS DISPONIBLES", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult dr= MessageBox.Show("Estás seguro de cerrar el programa", "CERRAR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }    

        }
    }
}
