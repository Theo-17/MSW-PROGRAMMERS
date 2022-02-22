namespace Servicios_Aeroportuarios
{
    partial class DESTINOS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DESTINOS));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.rbtEaChile = new System.Windows.Forms.RadioButton();
            this.rbtEaBrasil = new System.Windows.Forms.RadioButton();
            this.rbtEaArgentina = new System.Windows.Forms.RadioButton();
            this.lblPrecioEaC = new System.Windows.Forms.Label();
            this.lblPrecioEaB = new System.Windows.Forms.Label();
            this.lblPrecioEaA = new System.Windows.Forms.Label();
            this.pbRyanair = new System.Windows.Forms.PictureBox();
            this.pbWizzAir = new System.Windows.Forms.PictureBox();
            this.pbEasyJet = new System.Windows.Forms.PictureBox();
            this.lblTitRyanair = new System.Windows.Forms.Label();
            this.lblInfoRyanair = new System.Windows.Forms.Label();
            this.lnkRyanair = new System.Windows.Forms.LinkLabel();
            this.lblWizz = new System.Windows.Forms.Label();
            this.lblInfoWizz = new System.Windows.Forms.Label();
            this.lnkWizz = new System.Windows.Forms.LinkLabel();
            this.lnkEasyJet = new System.Windows.Forms.LinkLabel();
            this.lblInfoEasyJet = new System.Windows.Forms.Label();
            this.lbleasyJet = new System.Windows.Forms.Label();
            this.lblSinAsienChi = new System.Windows.Forms.Label();
            this.lblSinAsienBra = new System.Windows.Forms.Label();
            this.lblSinAsienArg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbRyanair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWizzAir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEasyJet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Broadway", 25.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(265, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(545, 48);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "DESTINO Y AEROLÍNEA";
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.Location = new System.Drawing.Point(770, 631);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(169, 43);
            this.btnSiguiente.TabIndex = 1;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Location = new System.Drawing.Point(127, 631);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(169, 43);
            this.btnRegresar.TabIndex = 2;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // rbtEaChile
            // 
            this.rbtEaChile.AutoSize = true;
            this.rbtEaChile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtEaChile.Location = new System.Drawing.Point(27, 89);
            this.rbtEaChile.Name = "rbtEaChile";
            this.rbtEaChile.Size = new System.Drawing.Size(311, 29);
            this.rbtEaChile.TabIndex = 4;
            this.rbtEaChile.TabStop = true;
            this.rbtEaChile.Text = "Salida: Ecuador - Destino: Chile";
            this.rbtEaChile.UseVisualStyleBackColor = true;
            this.rbtEaChile.CheckedChanged += new System.EventHandler(this.rbtEaChile_CheckedChanged);
            // 
            // rbtEaBrasil
            // 
            this.rbtEaBrasil.AutoSize = true;
            this.rbtEaBrasil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtEaBrasil.Location = new System.Drawing.Point(27, 272);
            this.rbtEaBrasil.Name = "rbtEaBrasil";
            this.rbtEaBrasil.Size = new System.Drawing.Size(314, 29);
            this.rbtEaBrasil.TabIndex = 5;
            this.rbtEaBrasil.TabStop = true;
            this.rbtEaBrasil.Text = "Salida: Ecuador - Destino: Brasil";
            this.rbtEaBrasil.UseVisualStyleBackColor = true;
            this.rbtEaBrasil.CheckedChanged += new System.EventHandler(this.rbtEaBrasil_CheckedChanged);
            // 
            // rbtEaArgentina
            // 
            this.rbtEaArgentina.AutoSize = true;
            this.rbtEaArgentina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtEaArgentina.Location = new System.Drawing.Point(27, 450);
            this.rbtEaArgentina.Name = "rbtEaArgentina";
            this.rbtEaArgentina.Size = new System.Drawing.Size(350, 29);
            this.rbtEaArgentina.TabIndex = 6;
            this.rbtEaArgentina.TabStop = true;
            this.rbtEaArgentina.Text = "Salida: Ecuador - Destino: Argentina";
            this.rbtEaArgentina.UseVisualStyleBackColor = true;
            this.rbtEaArgentina.CheckedChanged += new System.EventHandler(this.rbtEaArgentina_CheckedChanged);
            // 
            // lblPrecioEaC
            // 
            this.lblPrecioEaC.AutoSize = true;
            this.lblPrecioEaC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioEaC.Location = new System.Drawing.Point(961, 91);
            this.lblPrecioEaC.Name = "lblPrecioEaC";
            this.lblPrecioEaC.Size = new System.Drawing.Size(56, 25);
            this.lblPrecioEaC.TabIndex = 7;
            this.lblPrecioEaC.Text = "$336";
            // 
            // lblPrecioEaB
            // 
            this.lblPrecioEaB.AutoSize = true;
            this.lblPrecioEaB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioEaB.Location = new System.Drawing.Point(961, 274);
            this.lblPrecioEaB.Name = "lblPrecioEaB";
            this.lblPrecioEaB.Size = new System.Drawing.Size(56, 25);
            this.lblPrecioEaB.TabIndex = 8;
            this.lblPrecioEaB.Text = "$210";
            // 
            // lblPrecioEaA
            // 
            this.lblPrecioEaA.AutoSize = true;
            this.lblPrecioEaA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioEaA.Location = new System.Drawing.Point(961, 452);
            this.lblPrecioEaA.Name = "lblPrecioEaA";
            this.lblPrecioEaA.Size = new System.Drawing.Size(56, 25);
            this.lblPrecioEaA.TabIndex = 9;
            this.lblPrecioEaA.Text = "$460";
            // 
            // pbRyanair
            // 
            this.pbRyanair.Image = ((System.Drawing.Image)(resources.GetObject("pbRyanair.Image")));
            this.pbRyanair.Location = new System.Drawing.Point(62, 124);
            this.pbRyanair.Name = "pbRyanair";
            this.pbRyanair.Size = new System.Drawing.Size(234, 123);
            this.pbRyanair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRyanair.TabIndex = 10;
            this.pbRyanair.TabStop = false;
            // 
            // pbWizzAir
            // 
            this.pbWizzAir.Image = ((System.Drawing.Image)(resources.GetObject("pbWizzAir.Image")));
            this.pbWizzAir.Location = new System.Drawing.Point(62, 307);
            this.pbWizzAir.Name = "pbWizzAir";
            this.pbWizzAir.Size = new System.Drawing.Size(234, 123);
            this.pbWizzAir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbWizzAir.TabIndex = 11;
            this.pbWizzAir.TabStop = false;
            // 
            // pbEasyJet
            // 
            this.pbEasyJet.Image = ((System.Drawing.Image)(resources.GetObject("pbEasyJet.Image")));
            this.pbEasyJet.Location = new System.Drawing.Point(62, 485);
            this.pbEasyJet.Name = "pbEasyJet";
            this.pbEasyJet.Size = new System.Drawing.Size(234, 123);
            this.pbEasyJet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEasyJet.TabIndex = 12;
            this.pbEasyJet.TabStop = false;
            // 
            // lblTitRyanair
            // 
            this.lblTitRyanair.AutoSize = true;
            this.lblTitRyanair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitRyanair.Location = new System.Drawing.Point(311, 137);
            this.lblTitRyanair.Name = "lblTitRyanair";
            this.lblTitRyanair.Size = new System.Drawing.Size(105, 20);
            this.lblTitRyanair.TabIndex = 13;
            this.lblTitRyanair.Text = "Ryanair (FR)";
            // 
            // lblInfoRyanair
            // 
            this.lblInfoRyanair.AutoSize = true;
            this.lblInfoRyanair.Location = new System.Drawing.Point(333, 162);
            this.lblInfoRyanair.Name = "lblInfoRyanair";
            this.lblInfoRyanair.Size = new System.Drawing.Size(541, 48);
            this.lblInfoRyanair.TabIndex = 14;
            this.lblInfoRyanair.Text = resources.GetString("lblInfoRyanair.Text");
            // 
            // lnkRyanair
            // 
            this.lnkRyanair.AutoSize = true;
            this.lnkRyanair.Location = new System.Drawing.Point(333, 219);
            this.lnkRyanair.Name = "lnkRyanair";
            this.lnkRyanair.Size = new System.Drawing.Size(130, 16);
            this.lnkRyanair.TabIndex = 15;
            this.lnkRyanair.TabStop = true;
            this.lnkRyanair.Text = "Visitar Página Oficial";
            this.lnkRyanair.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkRyanair_LinkClicked);
            // 
            // lblWizz
            // 
            this.lblWizz.AutoSize = true;
            this.lblWizz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWizz.Location = new System.Drawing.Point(311, 313);
            this.lblWizz.Name = "lblWizz";
            this.lblWizz.Size = new System.Drawing.Size(115, 20);
            this.lblWizz.TabIndex = 16;
            this.lblWizz.Text = "Wizz Air (W6)";
            // 
            // lblInfoWizz
            // 
            this.lblInfoWizz.AutoSize = true;
            this.lblInfoWizz.Location = new System.Drawing.Point(333, 335);
            this.lblInfoWizz.Name = "lblInfoWizz";
            this.lblInfoWizz.Size = new System.Drawing.Size(576, 64);
            this.lblInfoWizz.TabIndex = 17;
            this.lblInfoWizz.Text = resources.GetString("lblInfoWizz.Text");
            // 
            // lnkWizz
            // 
            this.lnkWizz.AutoSize = true;
            this.lnkWizz.Location = new System.Drawing.Point(333, 406);
            this.lnkWizz.Name = "lnkWizz";
            this.lnkWizz.Size = new System.Drawing.Size(130, 16);
            this.lnkWizz.TabIndex = 18;
            this.lnkWizz.TabStop = true;
            this.lnkWizz.Text = "Visitar Página Oficial";
            this.lnkWizz.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkWizz_LinkClicked);
            // 
            // lnkEasyJet
            // 
            this.lnkEasyJet.AutoSize = true;
            this.lnkEasyJet.Location = new System.Drawing.Point(333, 579);
            this.lnkEasyJet.Name = "lnkEasyJet";
            this.lnkEasyJet.Size = new System.Drawing.Size(130, 16);
            this.lnkEasyJet.TabIndex = 21;
            this.lnkEasyJet.TabStop = true;
            this.lnkEasyJet.Text = "Visitar Página Oficial";
            this.lnkEasyJet.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lblInfoEasyJet
            // 
            this.lblInfoEasyJet.AutoSize = true;
            this.lblInfoEasyJet.Location = new System.Drawing.Point(333, 522);
            this.lblInfoEasyJet.Name = "lblInfoEasyJet";
            this.lblInfoEasyJet.Size = new System.Drawing.Size(581, 48);
            this.lblInfoEasyJet.TabIndex = 20;
            this.lblInfoEasyJet.Text = resources.GetString("lblInfoEasyJet.Text");
            // 
            // lbleasyJet
            // 
            this.lbleasyJet.AutoSize = true;
            this.lbleasyJet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbleasyJet.Location = new System.Drawing.Point(311, 497);
            this.lbleasyJet.Name = "lbleasyJet";
            this.lbleasyJet.Size = new System.Drawing.Size(105, 20);
            this.lbleasyJet.TabIndex = 19;
            this.lbleasyJet.Text = "easyJet (U2)";
            // 
            // lblSinAsienChi
            // 
            this.lblSinAsienChi.AutoSize = true;
            this.lblSinAsienChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSinAsienChi.ForeColor = System.Drawing.Color.Red;
            this.lblSinAsienChi.Location = new System.Drawing.Point(351, 93);
            this.lblSinAsienChi.Name = "lblSinAsienChi";
            this.lblSinAsienChi.Size = new System.Drawing.Size(283, 18);
            this.lblSinAsienChi.TabIndex = 22;
            this.lblSinAsienChi.Text = "(NO HAY ASIENTOS DISPONIBLES)";
            // 
            // lblSinAsienBra
            // 
            this.lblSinAsienBra.AutoSize = true;
            this.lblSinAsienBra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSinAsienBra.ForeColor = System.Drawing.Color.Red;
            this.lblSinAsienBra.Location = new System.Drawing.Point(369, 278);
            this.lblSinAsienBra.Name = "lblSinAsienBra";
            this.lblSinAsienBra.Size = new System.Drawing.Size(283, 18);
            this.lblSinAsienBra.TabIndex = 23;
            this.lblSinAsienBra.Text = "(NO HAY ASIENTOS DISPONIBLES)";
            // 
            // lblSinAsienArg
            // 
            this.lblSinAsienArg.AutoSize = true;
            this.lblSinAsienArg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSinAsienArg.ForeColor = System.Drawing.Color.Red;
            this.lblSinAsienArg.Location = new System.Drawing.Point(401, 457);
            this.lblSinAsienArg.Name = "lblSinAsienArg";
            this.lblSinAsienArg.Size = new System.Drawing.Size(283, 18);
            this.lblSinAsienArg.TabIndex = 24;
            this.lblSinAsienArg.Text = "(NO HAY ASIENTOS DISPONIBLES)";
            // 
            // DESTINOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1050, 686);
            this.Controls.Add(this.lblSinAsienArg);
            this.Controls.Add(this.lblSinAsienBra);
            this.Controls.Add(this.lblSinAsienChi);
            this.Controls.Add(this.lnkEasyJet);
            this.Controls.Add(this.lblInfoEasyJet);
            this.Controls.Add(this.lbleasyJet);
            this.Controls.Add(this.lnkWizz);
            this.Controls.Add(this.lblInfoWizz);
            this.Controls.Add(this.lblWizz);
            this.Controls.Add(this.lnkRyanair);
            this.Controls.Add(this.lblInfoRyanair);
            this.Controls.Add(this.lblTitRyanair);
            this.Controls.Add(this.pbEasyJet);
            this.Controls.Add(this.pbWizzAir);
            this.Controls.Add(this.pbRyanair);
            this.Controls.Add(this.lblPrecioEaA);
            this.Controls.Add(this.lblPrecioEaB);
            this.Controls.Add(this.lblPrecioEaC);
            this.Controls.Add(this.rbtEaArgentina);
            this.Controls.Add(this.rbtEaBrasil);
            this.Controls.Add(this.rbtEaChile);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.lblTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DESTINOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DESTINO Y AEROLÍNEA";
            this.Load += new System.EventHandler(this.DESTINOS_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pbRyanair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWizzAir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEasyJet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.RadioButton rbtEaChile;
        private System.Windows.Forms.RadioButton rbtEaBrasil;
        private System.Windows.Forms.RadioButton rbtEaArgentina;
        private System.Windows.Forms.Label lblPrecioEaC;
        private System.Windows.Forms.Label lblPrecioEaB;
        private System.Windows.Forms.Label lblPrecioEaA;
        private System.Windows.Forms.PictureBox pbRyanair;
        private System.Windows.Forms.PictureBox pbWizzAir;
        private System.Windows.Forms.PictureBox pbEasyJet;
        private System.Windows.Forms.Label lblTitRyanair;
        private System.Windows.Forms.Label lblInfoRyanair;
        private System.Windows.Forms.LinkLabel lnkRyanair;
        private System.Windows.Forms.Label lblWizz;
        private System.Windows.Forms.Label lblInfoWizz;
        private System.Windows.Forms.LinkLabel lnkWizz;
        private System.Windows.Forms.LinkLabel lnkEasyJet;
        private System.Windows.Forms.Label lblInfoEasyJet;
        private System.Windows.Forms.Label lbleasyJet;
        private System.Windows.Forms.Label lblSinAsienChi;
        private System.Windows.Forms.Label lblSinAsienBra;
        private System.Windows.Forms.Label lblSinAsienArg;
    }
}