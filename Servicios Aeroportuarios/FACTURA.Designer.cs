namespace Servicios_Aeroportuarios
{
    partial class fFACTURA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fFACTURA));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnRegresar3 = new System.Windows.Forms.Button();
            this.btnNuevaCompra = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.txtAerolinea = new System.Windows.Forms.TextBox();
            this.lblAerolinea = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtAsiento = new System.Windows.Forms.TextBox();
            this.lblSeat = new System.Windows.Forms.Label();
            this.rtbDatoTotal = new System.Windows.Forms.RichTextBox();
            this.pbCodigoDeBarra = new System.Windows.Forms.PictureBox();
            this.pbCorte = new System.Windows.Forms.PictureBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.dtpVuelo = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pbCodigoDeBarra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCorte)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Broadway", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(181, 11);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(680, 68);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "PASE DE ABORDAJE";
            // 
            // btnRegresar3
            // 
            this.btnRegresar3.Location = new System.Drawing.Point(16, 400);
            this.btnRegresar3.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegresar3.Name = "btnRegresar3";
            this.btnRegresar3.Size = new System.Drawing.Size(168, 39);
            this.btnRegresar3.TabIndex = 1;
            this.btnRegresar3.Text = "Regresar";
            this.btnRegresar3.UseVisualStyleBackColor = true;
            this.btnRegresar3.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNuevaCompra
            // 
            this.btnNuevaCompra.Location = new System.Drawing.Point(621, 400);
            this.btnNuevaCompra.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevaCompra.Name = "btnNuevaCompra";
            this.btnNuevaCompra.Size = new System.Drawing.Size(193, 39);
            this.btnNuevaCompra.TabIndex = 2;
            this.btnNuevaCompra.Text = "Iniciar Nueva Compra";
            this.btnNuevaCompra.UseVisualStyleBackColor = true;
            this.btnNuevaCompra.Click += new System.EventHandler(this.btnNuevaCompra_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(823, 400);
            this.btnFinalizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(171, 39);
            this.btnFinalizar.TabIndex = 3;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(56, 165);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(97, 16);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Nombre/Name";
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.Location = new System.Drawing.Point(60, 137);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(540, 23);
            this.txtName.TabIndex = 5;
            // 
            // txtFrom
            // 
            this.txtFrom.Enabled = false;
            this.txtFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFrom.ForeColor = System.Drawing.Color.Black;
            this.txtFrom.Location = new System.Drawing.Point(60, 196);
            this.txtFrom.Margin = new System.Windows.Forms.Padding(4);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(155, 23);
            this.txtFrom.TabIndex = 6;
            this.txtFrom.TabStop = false;
            // 
            // txtTo
            // 
            this.txtTo.Enabled = false;
            this.txtTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTo.ForeColor = System.Drawing.Color.Black;
            this.txtTo.Location = new System.Drawing.Point(60, 254);
            this.txtTo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(155, 23);
            this.txtTo.TabIndex = 7;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(56, 224);
            this.lblFrom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(83, 16);
            this.lblFrom.TabIndex = 8;
            this.lblFrom.Text = "Desde/From";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(56, 282);
            this.lblTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(37, 16);
            this.lblTo.TabIndex = 9;
            this.lblTo.Text = "A/To";
            // 
            // txtAerolinea
            // 
            this.txtAerolinea.Enabled = false;
            this.txtAerolinea.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAerolinea.ForeColor = System.Drawing.Color.Black;
            this.txtAerolinea.Location = new System.Drawing.Point(224, 196);
            this.txtAerolinea.Margin = new System.Windows.Forms.Padding(4);
            this.txtAerolinea.Name = "txtAerolinea";
            this.txtAerolinea.Size = new System.Drawing.Size(237, 23);
            this.txtAerolinea.TabIndex = 10;
            // 
            // lblAerolinea
            // 
            this.lblAerolinea.AutoSize = true;
            this.lblAerolinea.Location = new System.Drawing.Point(220, 224);
            this.lblAerolinea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAerolinea.Name = "lblAerolinea";
            this.lblAerolinea.Size = new System.Drawing.Size(109, 16);
            this.lblAerolinea.TabIndex = 11;
            this.lblAerolinea.Text = "Aerolínea/Carrier";
            // 
            // txtDate
            // 
            this.txtDate.Enabled = false;
            this.txtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.ForeColor = System.Drawing.Color.Black;
            this.txtDate.Location = new System.Drawing.Point(224, 254);
            this.txtDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(187, 23);
            this.txtDate.TabIndex = 12;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(220, 282);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(78, 16);
            this.lblDate.TabIndex = 13;
            this.lblDate.Text = "Fecha/Date";
            // 
            // txtAsiento
            // 
            this.txtAsiento.BackColor = System.Drawing.Color.White;
            this.txtAsiento.Enabled = false;
            this.txtAsiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAsiento.ForeColor = System.Drawing.Color.Black;
            this.txtAsiento.Location = new System.Drawing.Point(471, 196);
            this.txtAsiento.Margin = new System.Windows.Forms.Padding(4);
            this.txtAsiento.Name = "txtAsiento";
            this.txtAsiento.Size = new System.Drawing.Size(129, 23);
            this.txtAsiento.TabIndex = 16;
            // 
            // lblSeat
            // 
            this.lblSeat.AutoSize = true;
            this.lblSeat.Location = new System.Drawing.Point(467, 224);
            this.lblSeat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSeat.Name = "lblSeat";
            this.lblSeat.Size = new System.Drawing.Size(84, 16);
            this.lblSeat.TabIndex = 17;
            this.lblSeat.Text = "Asiento/Seat";
            // 
            // rtbDatoTotal
            // 
            this.rtbDatoTotal.Enabled = false;
            this.rtbDatoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbDatoTotal.Location = new System.Drawing.Point(735, 126);
            this.rtbDatoTotal.Margin = new System.Windows.Forms.Padding(4);
            this.rtbDatoTotal.Name = "rtbDatoTotal";
            this.rtbDatoTotal.Size = new System.Drawing.Size(279, 179);
            this.rtbDatoTotal.TabIndex = 22;
            this.rtbDatoTotal.Text = "";
            // 
            // pbCodigoDeBarra
            // 
            this.pbCodigoDeBarra.Image = ((System.Drawing.Image)(resources.GetObject("pbCodigoDeBarra.Image")));
            this.pbCodigoDeBarra.Location = new System.Drawing.Point(609, 137);
            this.pbCodigoDeBarra.Margin = new System.Windows.Forms.Padding(4);
            this.pbCodigoDeBarra.Name = "pbCodigoDeBarra";
            this.pbCodigoDeBarra.Size = new System.Drawing.Size(65, 161);
            this.pbCodigoDeBarra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCodigoDeBarra.TabIndex = 23;
            this.pbCodigoDeBarra.TabStop = false;
            // 
            // pbCorte
            // 
            this.pbCorte.Image = ((System.Drawing.Image)(resources.GetObject("pbCorte.Image")));
            this.pbCorte.Location = new System.Drawing.Point(703, 137);
            this.pbCorte.Margin = new System.Windows.Forms.Padding(4);
            this.pbCorte.Name = "pbCorte";
            this.pbCorte.Size = new System.Drawing.Size(6, 136);
            this.pbCorte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbCorte.TabIndex = 24;
            this.pbCorte.TabStop = false;
            // 
            // txtTime
            // 
            this.txtTime.Enabled = false;
            this.txtTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTime.ForeColor = System.Drawing.Color.Black;
            this.txtTime.Location = new System.Drawing.Point(420, 254);
            this.txtTime.Margin = new System.Windows.Forms.Padding(4);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(180, 23);
            this.txtTime.TabIndex = 14;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(416, 282);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(72, 16);
            this.lblTime.TabIndex = 15;
            this.lblTime.Text = "Hora/Time";
            // 
            // dtpVuelo
            // 
            this.dtpVuelo.Location = new System.Drawing.Point(60, 82);
            this.dtpVuelo.Margin = new System.Windows.Forms.Padding(4);
            this.dtpVuelo.Name = "dtpVuelo";
            this.dtpVuelo.Size = new System.Drawing.Size(265, 22);
            this.dtpVuelo.TabIndex = 25;
            this.dtpVuelo.Visible = false;
            // 
            // fFACTURA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1041, 454);
            this.Controls.Add(this.dtpVuelo);
            this.Controls.Add(this.pbCorte);
            this.Controls.Add(this.pbCodigoDeBarra);
            this.Controls.Add(this.rtbDatoTotal);
            this.Controls.Add(this.lblSeat);
            this.Controls.Add(this.txtAsiento);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.lblAerolinea);
            this.Controls.Add(this.txtAerolinea);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.btnNuevaCompra);
            this.Controls.Add(this.btnRegresar3);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "fFACTURA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FACTURA";
            this.Load += new System.EventHandler(this.FACTURA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCodigoDeBarra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCorte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnRegresar3;
        private System.Windows.Forms.Button btnNuevaCompra;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.TextBox txtAerolinea;
        private System.Windows.Forms.Label lblAerolinea;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtAsiento;
        private System.Windows.Forms.Label lblSeat;
        private System.Windows.Forms.RichTextBox rtbDatoTotal;
        private System.Windows.Forms.PictureBox pbCodigoDeBarra;
        private System.Windows.Forms.PictureBox pbCorte;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.DateTimePicker dtpVuelo;
    }
}