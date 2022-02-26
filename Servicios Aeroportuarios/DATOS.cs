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
            public Int32 celular;
            public Int32 pasaporte;
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
            lblConfirme.Show();
            btnConfirmar.Enabled = true;
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

        String aux = "aux";
        int aux2;

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (txtApellidos.Text == "" || txtCelular.Text == "" || txtEmail.Text == "" || txtLugar.Text == "" || txtNombres.Text == "" || txtPasaporte.Text == "" || persona.sexo=="")
                {
                    aux2=Convert.ToInt16(aux);
                }
                else
                {
                    lblConfirme.Hide();
                    persona.apellido = txtApellidos.Text;
                    persona.nombre = txtNombres.Text;
                    persona.correo = txtEmail.Text;
                    persona.lugarDeNacimiento = txtLugar.Text;
                    DateTime fecha = dateNacimiento.Value;
                    fN.nacimiento = fecha.ToShortDateString();
                    persona.pasaporte = Convert.ToInt32(txtPasaporte.Text);
                    persona.celular = Convert.ToInt32(txtCelular.Text);
                    MessageBox.Show("Datos Guardados Corectamente", "CONFIRMAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnSiguiente.Enabled = true;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Por favor\nLLene todos los datos correctamente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSiguiente.Enabled=false;
                btnConfirmar.Enabled = false;
                txaDescripcion.Text = "";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Se eliminarán todos los datos ingresados.\n¿Está Seguro?", "BORRAR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                txtNombres.Text = "";
                txtPasaporte.Text = "";
                txtApellidos.Text = "";
                txtCelular.Text = "";
                txtEmail.Text = "";
                txtLugar.Text = "";
                rbtF.Checked = false;
                rbtM.Checked = false;
                dateNacimiento.ResetText();
                btnConfirmar.Enabled = false;
                btnSiguiente.Enabled = false;
                txaDescripcion.Clear();
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            persona.sexo = "";
            lblConfirme.Hide();
            if(DESTINOS.numAsientoArg>50 && DESTINOS.numAsientoBra > 50 && DESTINOS.numAsientoChi > 50)
            {
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
