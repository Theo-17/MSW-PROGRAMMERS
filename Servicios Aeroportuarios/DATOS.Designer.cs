namespace Servicios_Aeroportuarios
{
    partial class fDATOS
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fDATOS));
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.lblDatos = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblCódigo = new System.Windows.Forms.Label();
            this.lblPasaporte = new System.Windows.Forms.Label();
            this.lblP = new System.Windows.Forms.Label();
            this.lblCodigoEcu = new System.Windows.Forms.Label();
            this.txtPasaporte = new System.Windows.Forms.TextBox();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblNombres = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.lblNacionalidad = new System.Windows.Forms.Label();
            this.lblEcuatoriano = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblLugar = new System.Windows.Forms.Label();
            this.txtLugar = new System.Windows.Forms.TextBox();
            this.lblECU = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.rbtMasculino = new System.Windows.Forms.RadioButton();
            this.rbtFemenino = new System.Windows.Forms.RadioButton();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.rtbDescripcion = new System.Windows.Forms.RichTextBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblCelular = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblConfirme = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Enabled = false;
            this.btnSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.Location = new System.Drawing.Point(796, 608);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(169, 43);
            this.btnSiguiente.TabIndex = 0;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Font = new System.Drawing.Font("Broadway", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatos.Location = new System.Drawing.Point(62, 9);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(868, 68);
            this.lblDatos.TabIndex = 1;
            this.lblDatos.Text = "REPUBLICA DEL ECUADOR";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(41, 96);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(82, 20);
            this.lblTipo.TabIndex = 2;
            this.lblTipo.Text = "Tipo\\Type";
            // 
            // lblCódigo
            // 
            this.lblCódigo.AutoSize = true;
            this.lblCódigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCódigo.Location = new System.Drawing.Point(322, 96);
            this.lblCódigo.Name = "lblCódigo";
            this.lblCódigo.Size = new System.Drawing.Size(231, 20);
            this.lblCódigo.TabIndex = 4;
            this.lblCódigo.Text = "Código del país\\Country Code";
            // 
            // lblPasaporte
            // 
            this.lblPasaporte.AutoSize = true;
            this.lblPasaporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasaporte.Location = new System.Drawing.Point(774, 96);
            this.lblPasaporte.Name = "lblPasaporte";
            this.lblPasaporte.Size = new System.Drawing.Size(157, 20);
            this.lblPasaporte.TabIndex = 5;
            this.lblPasaporte.Text = "Pasaporte\\Passport";
            // 
            // lblP
            // 
            this.lblP.AutoSize = true;
            this.lblP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP.Location = new System.Drawing.Point(70, 128);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(23, 22);
            this.lblP.TabIndex = 6;
            this.lblP.Text = "P";
            // 
            // lblCodigoEcu
            // 
            this.lblCodigoEcu.AutoSize = true;
            this.lblCodigoEcu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoEcu.Location = new System.Drawing.Point(345, 128);
            this.lblCodigoEcu.Name = "lblCodigoEcu";
            this.lblCodigoEcu.Size = new System.Drawing.Size(188, 22);
            this.lblCodigoEcu.TabIndex = 7;
            this.lblCodigoEcu.Text = "ECU      A65452098";
            // 
            // txtPasaporte
            // 
            this.txtPasaporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasaporte.Location = new System.Drawing.Point(778, 122);
            this.txtPasaporte.MaxLength = 10;
            this.txtPasaporte.Name = "txtPasaporte";
            this.txtPasaporte.Size = new System.Drawing.Size(153, 28);
            this.txtPasaporte.TabIndex = 8;
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidos.Location = new System.Drawing.Point(41, 173);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(168, 20);
            this.lblApellidos.TabIndex = 9;
            this.lblApellidos.Text = "Apellidos \\ Surnames";
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombres.Location = new System.Drawing.Point(41, 244);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(193, 20);
            this.lblNombres.TabIndex = 10;
            this.lblNombres.Text = "Nombres \\ Given Names";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidos.Location = new System.Drawing.Point(45, 196);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(280, 28);
            this.txtApellidos.TabIndex = 11;
            // 
            // txtNombres
            // 
            this.txtNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombres.Location = new System.Drawing.Point(45, 267);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(280, 28);
            this.txtNombres.TabIndex = 12;
            // 
            // lblNacionalidad
            // 
            this.lblNacionalidad.AutoSize = true;
            this.lblNacionalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNacionalidad.Location = new System.Drawing.Point(41, 310);
            this.lblNacionalidad.Name = "lblNacionalidad";
            this.lblNacionalidad.Size = new System.Drawing.Size(193, 20);
            this.lblNacionalidad.TabIndex = 13;
            this.lblNacionalidad.Text = "Nacionalidad\\ Nationality";
            // 
            // lblEcuatoriano
            // 
            this.lblEcuatoriano.AutoSize = true;
            this.lblEcuatoriano.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEcuatoriano.Location = new System.Drawing.Point(277, 310);
            this.lblEcuatoriano.Name = "lblEcuatoriano";
            this.lblEcuatoriano.Size = new System.Drawing.Size(300, 22);
            this.lblEcuatoriano.TabIndex = 14;
            this.lblEcuatoriano.Text = "ECUATORIANO \\ ECUADORIAN";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(542, 173);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(272, 20);
            this.lblFecha.TabIndex = 15;
            this.lblFecha.Text = "Fecha de nacimiento \\ Date of birth";
            // 
            // dtpNacimiento
            // 
            this.dtpNacimiento.CalendarMonthBackground = System.Drawing.SystemColors.HotTrack;
            this.dtpNacimiento.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtpNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNacimiento.Location = new System.Drawing.Point(546, 196);
            this.dtpNacimiento.Name = "dtpNacimiento";
            this.dtpNacimiento.Size = new System.Drawing.Size(399, 24);
            this.dtpNacimiento.TabIndex = 16;
            this.dtpNacimiento.Value = new System.DateTime(2022, 2, 22, 0, 0, 0, 0);
            // 
            // lblLugar
            // 
            this.lblLugar.AutoSize = true;
            this.lblLugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLugar.Location = new System.Drawing.Point(41, 348);
            this.lblLugar.Name = "lblLugar";
            this.lblLugar.Size = new System.Drawing.Size(270, 20);
            this.lblLugar.TabIndex = 17;
            this.lblLugar.Text = "Lugar de nacimiento\\ Place of birth";
            // 
            // txtLugar
            // 
            this.txtLugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLugar.Location = new System.Drawing.Point(45, 371);
            this.txtLugar.Name = "txtLugar";
            this.txtLugar.Size = new System.Drawing.Size(133, 28);
            this.txtLugar.TabIndex = 18;
            // 
            // lblECU
            // 
            this.lblECU.AutoSize = true;
            this.lblECU.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblECU.Location = new System.Drawing.Point(184, 374);
            this.lblECU.Name = "lblECU";
            this.lblECU.Size = new System.Drawing.Size(75, 22);
            this.lblECU.TabIndex = 19;
            this.lblECU.Text = ",   ECU";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.Location = new System.Drawing.Point(740, 348);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(89, 20);
            this.lblSexo.TabIndex = 20;
            this.lblSexo.Text = "Sexo \\ Sex";
            // 
            // rbtMasculino
            // 
            this.rbtMasculino.AutoSize = true;
            this.rbtMasculino.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtMasculino.Location = new System.Drawing.Point(744, 378);
            this.rbtMasculino.Name = "rbtMasculino";
            this.rbtMasculino.Size = new System.Drawing.Size(45, 26);
            this.rbtMasculino.TabIndex = 21;
            this.rbtMasculino.TabStop = true;
            this.rbtMasculino.Text = "M";
            this.rbtMasculino.UseVisualStyleBackColor = true;
            // 
            // rbtFemenino
            // 
            this.rbtFemenino.AutoSize = true;
            this.rbtFemenino.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtFemenino.Location = new System.Drawing.Point(744, 405);
            this.rbtFemenino.Name = "rbtFemenino";
            this.rbtFemenino.Size = new System.Drawing.Size(42, 26);
            this.rbtFemenino.TabIndex = 22;
            this.rbtFemenino.TabStop = true;
            this.rbtFemenino.Text = "F";
            this.rbtFemenino.UseVisualStyleBackColor = true;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Enabled = false;
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(281, 746);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(244, 31);
            this.btnConfirmar.TabIndex = 23;
            this.btnConfirmar.Text = "CONFIRMAR DATOS";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // rtbDescripcion
            // 
            this.rtbDescripcion.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rtbDescripcion.Enabled = false;
            this.rtbDescripcion.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.rtbDescripcion.Location = new System.Drawing.Point(156, 596);
            this.rtbDescripcion.Name = "rtbDescripcion";
            this.rtbDescripcion.Size = new System.Drawing.Size(484, 144);
            this.rtbDescripcion.TabIndex = 24;
            this.rtbDescripcion.Text = "";
            // 
            // btnMostrar
            // 
            this.btnMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.Location = new System.Drawing.Point(415, 560);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(225, 30);
            this.btnMostrar.TabIndex = 25;
            this.btnMostrar.Text = "MOSTRAR DATOS";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(41, 420);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(199, 20);
            this.lblEmail.TabIndex = 26;
            this.lblEmail.Text = "Correo electrónico\\ Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(45, 443);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(321, 28);
            this.txtEmail.TabIndex = 27;
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelular.Location = new System.Drawing.Point(41, 489);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(151, 20);
            this.lblCelular.TabIndex = 28;
            this.lblCelular.Text = "Celular\\ Cell phone";
            // 
            // txtCelular
            // 
            this.txtCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelular.Location = new System.Drawing.Point(45, 512);
            this.txtCelular.MaxLength = 10;
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(133, 28);
            this.txtCelular.TabIndex = 29;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(156, 560);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(225, 30);
            this.btnBorrar.TabIndex = 30;
            this.btnBorrar.Text = "BORRAR DATOS";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(775, 683);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(211, 43);
            this.btnCerrar.TabIndex = 31;
            this.btnCerrar.Text = "Cerrar Programa";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblConfirme
            // 
            this.lblConfirme.AutoSize = true;
            this.lblConfirme.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirme.ForeColor = System.Drawing.Color.Red;
            this.lblConfirme.Location = new System.Drawing.Point(741, 589);
            this.lblConfirme.Name = "lblConfirme";
            this.lblConfirme.Size = new System.Drawing.Size(279, 16);
            this.lblConfirme.TabIndex = 32;
            this.lblConfirme.Text = "CONFIRME DATOS PARA CONTINUAR";
            // 
            // fDATOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1075, 788);
            this.Controls.Add(this.lblConfirme);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.lblCelular);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.rtbDescripcion);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.rbtFemenino);
            this.Controls.Add(this.rbtMasculino);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblECU);
            this.Controls.Add(this.txtLugar);
            this.Controls.Add(this.lblLugar);
            this.Controls.Add(this.dtpNacimiento);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblEcuatoriano);
            this.Controls.Add(this.lblNacionalidad);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.lblNombres);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.txtPasaporte);
            this.Controls.Add(this.lblCodigoEcu);
            this.Controls.Add(this.lblP);
            this.Controls.Add(this.lblPasaporte);
            this.Controls.Add(this.lblCódigo);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblDatos);
            this.Controls.Add(this.btnSiguiente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fDATOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DATOS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblCódigo;
        private System.Windows.Forms.Label lblPasaporte;
        private System.Windows.Forms.Label lblP;
        private System.Windows.Forms.Label lblCodigoEcu;
        private System.Windows.Forms.TextBox txtPasaporte;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label lblNacionalidad;
        private System.Windows.Forms.Label lblEcuatoriano;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpNacimiento;
        private System.Windows.Forms.Label lblLugar;
        private System.Windows.Forms.TextBox txtLugar;
        private System.Windows.Forms.Label lblECU;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.RadioButton rbtMasculino;
        private System.Windows.Forms.RadioButton rbtFemenino;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.RichTextBox rtbDescripcion;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblConfirme;
    }
}

