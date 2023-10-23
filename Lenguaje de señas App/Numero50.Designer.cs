namespace Lenguaje_de_señas_App
{
    partial class Numero50
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
            this.btnRegresar50 = new System.Windows.Forms.Button();
            this.btnAtras50 = new System.Windows.Forms.Button();
            this.btnSiguiente50 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegresar50
            // 
            this.btnRegresar50.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegresar50.Location = new System.Drawing.Point(118, 227);
            this.btnRegresar50.Name = "btnRegresar50";
            this.btnRegresar50.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar50.TabIndex = 7;
            this.btnRegresar50.Text = "Regresar";
            this.btnRegresar50.UseVisualStyleBackColor = true;
            this.btnRegresar50.Click += new System.EventHandler(this.btnRegresar50_Click);
            // 
            // btnAtras50
            // 
            this.btnAtras50.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtras50.Location = new System.Drawing.Point(27, 174);
            this.btnAtras50.Name = "btnAtras50";
            this.btnAtras50.Size = new System.Drawing.Size(75, 23);
            this.btnAtras50.TabIndex = 6;
            this.btnAtras50.Text = "Atras";
            this.btnAtras50.UseVisualStyleBackColor = true;
            this.btnAtras50.Click += new System.EventHandler(this.btnAtras50_Click);
            // 
            // btnSiguiente50
            // 
            this.btnSiguiente50.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSiguiente50.Location = new System.Drawing.Point(226, 174);
            this.btnSiguiente50.Name = "btnSiguiente50";
            this.btnSiguiente50.Size = new System.Drawing.Size(75, 23);
            this.btnSiguiente50.TabIndex = 5;
            this.btnSiguiente50.Text = "Siguiente";
            this.btnSiguiente50.UseVisualStyleBackColor = true;
            this.btnSiguiente50.Click += new System.EventHandler(this.btnSiguiente50_Click);
            // 
            // Numero50
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 424);
            this.Controls.Add(this.btnRegresar50);
            this.Controls.Add(this.btnAtras50);
            this.Controls.Add(this.btnSiguiente50);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Numero50";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Numero50";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegresar50;
        private System.Windows.Forms.Button btnAtras50;
        private System.Windows.Forms.Button btnSiguiente50;
    }
}