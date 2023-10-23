namespace Lenguaje_de_señas_App
{
    partial class Numero5
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
            this.btnRegresar5 = new System.Windows.Forms.Button();
            this.btnAtras5 = new System.Windows.Forms.Button();
            this.btnSiguiente5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegresar5
            // 
            this.btnRegresar5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegresar5.Location = new System.Drawing.Point(118, 227);
            this.btnRegresar5.Name = "btnRegresar5";
            this.btnRegresar5.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar5.TabIndex = 7;
            this.btnRegresar5.Text = "Regresar";
            this.btnRegresar5.UseVisualStyleBackColor = true;
            this.btnRegresar5.Click += new System.EventHandler(this.btnRegresar5_Click);
            // 
            // btnAtras5
            // 
            this.btnAtras5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtras5.Location = new System.Drawing.Point(27, 174);
            this.btnAtras5.Name = "btnAtras5";
            this.btnAtras5.Size = new System.Drawing.Size(75, 23);
            this.btnAtras5.TabIndex = 6;
            this.btnAtras5.Text = "Atras";
            this.btnAtras5.UseVisualStyleBackColor = true;
            this.btnAtras5.Click += new System.EventHandler(this.btnAtras5_Click);
            // 
            // btnSiguiente5
            // 
            this.btnSiguiente5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSiguiente5.Location = new System.Drawing.Point(226, 174);
            this.btnSiguiente5.Name = "btnSiguiente5";
            this.btnSiguiente5.Size = new System.Drawing.Size(75, 23);
            this.btnSiguiente5.TabIndex = 5;
            this.btnSiguiente5.Text = "Siguiente";
            this.btnSiguiente5.UseVisualStyleBackColor = true;
            this.btnSiguiente5.Click += new System.EventHandler(this.btnSiguiente5_Click);
            // 
            // Numero5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 424);
            this.Controls.Add(this.btnRegresar5);
            this.Controls.Add(this.btnAtras5);
            this.Controls.Add(this.btnSiguiente5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Numero5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Numero5";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegresar5;
        private System.Windows.Forms.Button btnAtras5;
        private System.Windows.Forms.Button btnSiguiente5;
    }
}