namespace Lenguaje_de_señas_App
{
    partial class Numero80
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
            this.btnRegresar80 = new System.Windows.Forms.Button();
            this.btnAtras80 = new System.Windows.Forms.Button();
            this.btnSiguiente80 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegresar80
            // 
            this.btnRegresar80.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegresar80.Location = new System.Drawing.Point(118, 227);
            this.btnRegresar80.Name = "btnRegresar80";
            this.btnRegresar80.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar80.TabIndex = 7;
            this.btnRegresar80.Text = "Regresar";
            this.btnRegresar80.UseVisualStyleBackColor = true;
            this.btnRegresar80.Click += new System.EventHandler(this.btnRegresar80_Click);
            // 
            // btnAtras80
            // 
            this.btnAtras80.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtras80.Location = new System.Drawing.Point(27, 174);
            this.btnAtras80.Name = "btnAtras80";
            this.btnAtras80.Size = new System.Drawing.Size(75, 23);
            this.btnAtras80.TabIndex = 6;
            this.btnAtras80.Text = "Atras";
            this.btnAtras80.UseVisualStyleBackColor = true;
            this.btnAtras80.Click += new System.EventHandler(this.btnAtras80_Click);
            // 
            // btnSiguiente80
            // 
            this.btnSiguiente80.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSiguiente80.Location = new System.Drawing.Point(226, 174);
            this.btnSiguiente80.Name = "btnSiguiente80";
            this.btnSiguiente80.Size = new System.Drawing.Size(75, 23);
            this.btnSiguiente80.TabIndex = 5;
            this.btnSiguiente80.Text = "Siguiente";
            this.btnSiguiente80.UseVisualStyleBackColor = true;
            this.btnSiguiente80.Click += new System.EventHandler(this.btnSiguiente80_Click);
            // 
            // Numero80
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 424);
            this.Controls.Add(this.btnRegresar80);
            this.Controls.Add(this.btnAtras80);
            this.Controls.Add(this.btnSiguiente80);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Numero80";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Numero80";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegresar80;
        private System.Windows.Forms.Button btnAtras80;
        private System.Windows.Forms.Button btnSiguiente80;
    }
}