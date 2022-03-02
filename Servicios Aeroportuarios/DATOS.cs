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
    public partial class fDATOS : Form
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


        public fDATOS()
        {
            InitializeComponent();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            fDESTINOS destino = new fDESTINOS();
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
            public UInt64 celular;
            public UInt64 pasaporte;
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
            if (rbtFemenino.Checked == true)
            {
                persona.sexo = "Femenino";
            }
            else
            {
                if (rbtMasculino.Checked == true)
                {
                    persona.sexo = "Masculino";
                }
            }
            rtbDescripcion.Text = "";
            lblConfirme.Show();
            btnConfirmar.Enabled = true;
            rtbDescripcion.AppendText("Nombres: " + txtNombres.Text+"\n");
            rtbDescripcion.AppendText("Apellidos: " + txtApellidos.Text+"\n");
            rtbDescripcion.AppendText("Pasaporte: " + txtPasaporte.Text + "\n");
            rtbDescripcion.AppendText("Lugar de nacimiento: " + txtLugar.Text + ",ECU"+"\n");
            rtbDescripcion.AppendText("cell: " + txtCelular.Text + "\n");
            rtbDescripcion.AppendText("Email: " + txtEmail.Text + "\n");
            rtbDescripcion.AppendText("Sexo: "+persona.sexo+"\n");
            DateTime fecha = dtpNacimiento.Value;
            fN.nacimiento = fecha.ToShortDateString();
            rtbDescripcion.AppendText("Fecha de nacimiento: " + fN.nacimiento + "\n");

        }

        String aux = "aux";
        int aux2;

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (string.IsNullOrEmpty(txtApellidos.Text) || string.IsNullOrEmpty(txtCelular.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtLugar.Text) || string.IsNullOrEmpty(txtNombres.Text) || string.IsNullOrEmpty(txtPasaporte.Text) || string.IsNullOrEmpty(persona.sexo) || dtpNacimiento.Value.ToShortDateString()== DateTime.Now.ToShortDateString() || dtpNacimiento.Value.Year>DateTime.Now.Year || txtPasaporte.TextLength <= 9 || txtCelular.TextLength <= 9)
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
                    DateTime fecha = dtpNacimiento.Value;
                    fN.nacimiento = fecha.ToShortDateString();
                    persona.pasaporte = Convert.ToUInt64(txtPasaporte.Text);
                    persona.celular = Convert.ToUInt64(txtCelular.Text);
                    MessageBox.Show("Datos Guardados Corectamente", "CONFIRMAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnSiguiente.Enabled = true;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Por favor\nLLene todos los datos correctamente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSiguiente.Enabled=false;
                btnConfirmar.Enabled = false;
                rtbDescripcion.Text = "";
                lblConfirme.Hide();
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
                rbtFemenino.Checked = false;
                rbtMasculino.Checked = false;
                dtpNacimiento.ResetText();
                btnConfirmar.Enabled = false;
                btnSiguiente.Enabled = false;
                rtbDescripcion.Clear();
            }
            
        }

        static public int aux3 = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            if (aux3==0)
            {
                txtCelular.Text = "";
                txtPasaporte.Text = "";
                aux3 = 1;
            }
            else
            {
                txtPasaporte.Text = Convert.ToString(persona.pasaporte);
                txtCelular.Text = Convert.ToString(persona.celular);
                if (persona.sexo=="Masculino")
                {
                    rbtMasculino.Checked = true;
                }
                else
                {
                    rbtFemenino.Checked = true;
                }
            }
            
            txtApellidos.Text = persona.apellido;
            txtEmail.Text = persona.correo;
            txtLugar.Text = persona.lugarDeNacimiento;
            txtNombres.Text=persona.nombre;
            dtpNacimiento.Value=DateTime.Now;
            persona.sexo = "";

            lblConfirme.Hide();
            if(fDESTINOS.numAsientoArg>50 && fDESTINOS.numAsientoBra > 50 && fDESTINOS.numAsientoChi > 50)
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
