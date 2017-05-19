namespace NavajaHectorSala.Primos
{
    partial class Primos
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
            this.tNum1 = new System.Windows.Forms.TextBox();
            this.tNum2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tNum1
            // 
            this.tNum1.Location = new System.Drawing.Point(56, 52);
            this.tNum1.MaxLength = 3;
            this.tNum1.Name = "tNum1";
            this.tNum1.Size = new System.Drawing.Size(185, 20);
            this.tNum1.TabIndex = 0;
            // 
            // tNum2
            // 
            this.tNum2.Location = new System.Drawing.Point(56, 107);
            this.tNum2.MaxLength = 3;
            this.tNum2.Name = "tNum2";
            this.tNum2.Size = new System.Drawing.Size(185, 20);
            this.tNum2.TabIndex = 1;
            this.tNum2.TextChanged += new System.EventHandler(this.tNum2_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(92, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "Click";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Primos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tNum2);
            this.Controls.Add(this.tNum1);
            this.Name = "Primos";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tNum1;
        private System.Windows.Forms.TextBox tNum2;
        private System.Windows.Forms.Button button1;
    }
}

