namespace NavajaHectorSala
{
    partial class Principal
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
            this.botonFactorial = new System.Windows.Forms.Button();
            this.botonFibonacci = new System.Windows.Forms.Button();
            this.botonPrimos = new System.Windows.Forms.Button();
            this.botonPalindromo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botonFactorial
            // 
            this.botonFactorial.Location = new System.Drawing.Point(183, 12);
            this.botonFactorial.Name = "botonFactorial";
            this.botonFactorial.Size = new System.Drawing.Size(215, 93);
            this.botonFactorial.TabIndex = 0;
            this.botonFactorial.Text = "Multiplicacion Factorial";
            this.botonFactorial.UseVisualStyleBackColor = true;
            this.botonFactorial.Click += new System.EventHandler(this.button1_Click);
            // 
            // botonFibonacci
            // 
            this.botonFibonacci.Location = new System.Drawing.Point(7, 111);
            this.botonFibonacci.Name = "botonFibonacci";
            this.botonFibonacci.Size = new System.Drawing.Size(215, 93);
            this.botonFibonacci.TabIndex = 1;
            this.botonFibonacci.Text = "Fibonacci";
            this.botonFibonacci.UseVisualStyleBackColor = true;
            this.botonFibonacci.Click += new System.EventHandler(this.button2_Click);
            // 
            // botonPrimos
            // 
            this.botonPrimos.Location = new System.Drawing.Point(362, 111);
            this.botonPrimos.Name = "botonPrimos";
            this.botonPrimos.Size = new System.Drawing.Size(215, 93);
            this.botonPrimos.TabIndex = 2;
            this.botonPrimos.Text = "Primos";
            this.botonPrimos.UseVisualStyleBackColor = true;
            this.botonPrimos.Click += new System.EventHandler(this.button3_Click);
            // 
            // botonPalindromo
            // 
            this.botonPalindromo.Location = new System.Drawing.Point(183, 210);
            this.botonPalindromo.Name = "botonPalindromo";
            this.botonPalindromo.Size = new System.Drawing.Size(215, 93);
            this.botonPalindromo.TabIndex = 3;
            this.botonPalindromo.Text = "Palindromo";
            this.botonPalindromo.UseVisualStyleBackColor = true;
            this.botonPalindromo.Click += new System.EventHandler(this.button4_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 319);
            this.Controls.Add(this.botonPalindromo);
            this.Controls.Add(this.botonPrimos);
            this.Controls.Add(this.botonFibonacci);
            this.Controls.Add(this.botonFactorial);
            this.Name = "Principal";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botonFactorial;
        private System.Windows.Forms.Button botonFibonacci;
        private System.Windows.Forms.Button botonPrimos;
        private System.Windows.Forms.Button botonPalindromo;
    }
}

