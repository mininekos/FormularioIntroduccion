namespace Ejercicio3
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rdAscendente = new System.Windows.Forms.RadioButton();
            this.rdDescente = new System.Windows.Forms.RadioButton();
            this.txtTabla = new System.Windows.Forms.TextBox();
            this.Numero = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Numero)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NÚMERO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "TABLA DE MULTIPLICAR";
            // 
            // rdAscendente
            // 
            this.rdAscendente.AutoSize = true;
            this.rdAscendente.Location = new System.Drawing.Point(57, 102);
            this.rdAscendente.Name = "rdAscendente";
            this.rdAscendente.Size = new System.Drawing.Size(98, 17);
            this.rdAscendente.TabIndex = 2;
            this.rdAscendente.Text = "ASCENDENTE";
            this.rdAscendente.UseVisualStyleBackColor = true;
            this.rdAscendente.CheckedChanged += new System.EventHandler(this.rdAscendente_CheckedChanged);
            // 
            // rdDescente
            // 
            this.rdDescente.AutoSize = true;
            this.rdDescente.Location = new System.Drawing.Point(180, 102);
            this.rdDescente.Name = "rdDescente";
            this.rdDescente.Size = new System.Drawing.Size(106, 17);
            this.rdDescente.TabIndex = 3;
            this.rdDescente.Text = "DESCENDENTE";
            this.rdDescente.UseVisualStyleBackColor = true;
            this.rdDescente.CheckedChanged += new System.EventHandler(this.rdDescente_CheckedChanged);
            // 
            // txtTabla
            // 
            this.txtTabla.Location = new System.Drawing.Point(57, 160);
            this.txtTabla.Multiline = true;
            this.txtTabla.Name = "txtTabla";
            this.txtTabla.Size = new System.Drawing.Size(188, 169);
            this.txtTabla.TabIndex = 4;
            // 
            // Numero
            // 
            this.Numero.Location = new System.Drawing.Point(113, 34);
            this.Numero.Name = "Numero";
            this.Numero.Size = new System.Drawing.Size(120, 20);
            this.Numero.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Numero);
            this.Controls.Add(this.txtTabla);
            this.Controls.Add(this.rdDescente);
            this.Controls.Add(this.rdAscendente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Numero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdAscendente;
        private System.Windows.Forms.RadioButton rdDescente;
        private System.Windows.Forms.TextBox txtTabla;
        private System.Windows.Forms.NumericUpDown Numero;
    }
}

