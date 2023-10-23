namespace Lenguaje_de_señas_App
{
    partial class Numero2
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
            this.btnRegresar2 = new System.Windows.Forms.Button();
            this.btnAtras2 = new System.Windows.Forms.Button();
            this.btnSiguiente2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegresar2
            // 
            this.btnRegresar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegresar2.Location = new System.Drawing.Point(118, 227);
            this.btnRegresar2.Name = "btnRegresar2";
            this.btnRegresar2.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar2.TabIndex = 10;
            this.btnRegresar2.Text = "Regresar";
            this.btnRegresar2.UseVisualStyleBackColor = true;
            this.btnRegresar2.Click += new System.EventHandler(this.btnRegresar2_Click);
            // 
            // btnAtras2
            // 
            this.btnAtras2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtras2.Location = new System.Drawing.Point(27, 174);
            this.btnAtras2.Name = "btnAtras2";
            this.btnAtras2.Size = new System.Drawing.Size(75, 23);
            this.btnAtras2.TabIndex = 9;
            this.btnAtras2.Text = "Atras";
            this.btnAtras2.UseVisualStyleBackColor = true;
            this.btnAtras2.Click += new System.EventHandler(this.btnAtras2_Click);
            // 
            // btnSiguiente2
            // 
            this.btnSiguiente2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSiguiente2.Location = new System.Drawing.Point(226, 174);
            this.btnSiguiente2.Name = "btnSiguiente2";
            this.btnSiguiente2.Size = new System.Drawing.Size(75, 23);
            this.btnSiguiente2.TabIndex = 8;
            this.btnSiguiente2.Text = "Siguiente";
            this.btnSiguiente2.UseVisualStyleBackColor = true;
            this.btnSiguiente2.Click += new System.EventHandler(this.btnSiguiente2_Click);
            // 
            // Numero2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 424);
            this.Controls.Add(this.btnRegresar2);
            this.Controls.Add(this.btnAtras2);
            this.Controls.Add(this.btnSiguiente2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Numero2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Numero2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegresar2;
        private System.Windows.Forms.Button btnAtras2;
        private System.Windows.Forms.Button btnSiguiente2;
    }
}