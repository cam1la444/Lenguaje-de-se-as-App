namespace Lenguaje_de_señas_App
{
    partial class Numero9
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
            this.btnRegresar9 = new System.Windows.Forms.Button();
            this.btnAtras9 = new System.Windows.Forms.Button();
            this.btnSiguiente9 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegresar9
            // 
            this.btnRegresar9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegresar9.Location = new System.Drawing.Point(118, 227);
            this.btnRegresar9.Name = "btnRegresar9";
            this.btnRegresar9.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar9.TabIndex = 7;
            this.btnRegresar9.Text = "Regresar";
            this.btnRegresar9.UseVisualStyleBackColor = true;
            this.btnRegresar9.Click += new System.EventHandler(this.btnRegresar9_Click);
            // 
            // btnAtras9
            // 
            this.btnAtras9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtras9.Location = new System.Drawing.Point(27, 174);
            this.btnAtras9.Name = "btnAtras9";
            this.btnAtras9.Size = new System.Drawing.Size(75, 23);
            this.btnAtras9.TabIndex = 6;
            this.btnAtras9.Text = "Atras";
            this.btnAtras9.UseVisualStyleBackColor = true;
            this.btnAtras9.Click += new System.EventHandler(this.btnAtras9_Click);
            // 
            // btnSiguiente9
            // 
            this.btnSiguiente9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSiguiente9.Location = new System.Drawing.Point(226, 174);
            this.btnSiguiente9.Name = "btnSiguiente9";
            this.btnSiguiente9.Size = new System.Drawing.Size(75, 23);
            this.btnSiguiente9.TabIndex = 5;
            this.btnSiguiente9.Text = "Siguiente";
            this.btnSiguiente9.UseVisualStyleBackColor = true;
            this.btnSiguiente9.Click += new System.EventHandler(this.btnSiguiente9_Click);
            // 
            // Numero9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 424);
            this.Controls.Add(this.btnRegresar9);
            this.Controls.Add(this.btnAtras9);
            this.Controls.Add(this.btnSiguiente9);
            this.Name = "Numero9";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Numero9";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegresar9;
        private System.Windows.Forms.Button btnAtras9;
        private System.Windows.Forms.Button btnSiguiente9;
    }
}