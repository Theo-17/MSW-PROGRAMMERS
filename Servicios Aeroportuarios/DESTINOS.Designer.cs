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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.rbtEaChile = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Broadway", 25.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(164, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(249, 50);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "DESTINOS";
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.Location = new System.Drawing.Point(395, 378);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(169, 43);
            this.btnSiguiente.TabIndex = 1;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(31, 378);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(169, 43);
            this.button2.TabIndex = 2;
            this.button2.Text = "Regresar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // rbtEaChile
            // 
            this.rbtEaChile.AutoSize = true;
            this.rbtEaChile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtEaChile.Location = new System.Drawing.Point(72, 111);
            this.rbtEaChile.Name = "rbtEaChile";
            this.rbtEaChile.Size = new System.Drawing.Size(311, 29);
            this.rbtEaChile.TabIndex = 4;
            this.rbtEaChile.TabStop = true;
            this.rbtEaChile.Text = "Salida: Ecuador - Destino: Chile";
            this.rbtEaChile.UseVisualStyleBackColor = true;
            // 
            // DESTINOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(588, 450);
            this.Controls.Add(this.rbtEaChile);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.lblTitulo);
            this.Name = "DESTINOS";
            this.Text = "DESTINOS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton rbtEaChile;
    }
}