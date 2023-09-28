namespace Lenguaje_de_señas_App
{
    partial class Numero1
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
            this.btnSiguiente1 = new System.Windows.Forms.Button();
            this.btnAtras1 = new System.Windows.Forms.Button();
            this.btnRegresar1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSiguiente1
            // 
            this.btnSiguiente1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSiguiente1.Location = new System.Drawing.Point(230, 340);
            this.btnSiguiente1.Name = "btnSiguiente1";
            this.btnSiguiente1.Size = new System.Drawing.Size(75, 23);
            this.btnSiguiente1.TabIndex = 2;
            this.btnSiguiente1.Text = "Siguiente";
            this.btnSiguiente1.UseVisualStyleBackColor = true;
            this.btnSiguiente1.Click += new System.EventHandler(this.btnSiguiente2_Click);
            // 
            // btnAtras1
            // 
            this.btnAtras1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtras1.Location = new System.Drawing.Point(31, 340);
            this.btnAtras1.Name = "btnAtras1";
            this.btnAtras1.Size = new System.Drawing.Size(75, 23);
            this.btnAtras1.TabIndex = 3;
            this.btnAtras1.Text = "Atras";
            this.btnAtras1.UseVisualStyleBackColor = true;
            this.btnAtras1.Click += new System.EventHandler(this.btnAtras0_Click);
            // 
            // btnRegresar1
            // 
            this.btnRegresar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegresar1.Location = new System.Drawing.Point(122, 393);
            this.btnRegresar1.Name = "btnRegresar1";
            this.btnRegresar1.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar1.TabIndex = 4;
            this.btnRegresar1.Text = "Regresar";
            this.btnRegresar1.UseVisualStyleBackColor = true;
            this.btnRegresar1.Click += new System.EventHandler(this.btnRegresar1_Click);
            // 
            // Numero1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 424);
            this.Controls.Add(this.btnRegresar1);
            this.Controls.Add(this.btnAtras1);
            this.Controls.Add(this.btnSiguiente1);
            this.Name = "Numero1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Numero1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSiguiente1;
        private System.Windows.Forms.Button btnAtras1;
        private System.Windows.Forms.Button btnRegresar1;
    }
}