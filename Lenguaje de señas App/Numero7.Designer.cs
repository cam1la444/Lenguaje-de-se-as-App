namespace Lenguaje_de_señas_App
{
    partial class Numero7
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
            this.btnRegresar7 = new System.Windows.Forms.Button();
            this.btnAtras7 = new System.Windows.Forms.Button();
            this.btnSiguiente7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegresar7
            // 
            this.btnRegresar7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegresar7.Location = new System.Drawing.Point(118, 227);
            this.btnRegresar7.Name = "btnRegresar7";
            this.btnRegresar7.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar7.TabIndex = 7;
            this.btnRegresar7.Text = "Regresar";
            this.btnRegresar7.UseVisualStyleBackColor = true;
            this.btnRegresar7.Click += new System.EventHandler(this.btnRegresar7_Click);
            // 
            // btnAtras7
            // 
            this.btnAtras7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtras7.Location = new System.Drawing.Point(27, 174);
            this.btnAtras7.Name = "btnAtras7";
            this.btnAtras7.Size = new System.Drawing.Size(75, 23);
            this.btnAtras7.TabIndex = 6;
            this.btnAtras7.Text = "Atras";
            this.btnAtras7.UseVisualStyleBackColor = true;
            this.btnAtras7.Click += new System.EventHandler(this.btnAtras7_Click);
            // 
            // btnSiguiente7
            // 
            this.btnSiguiente7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSiguiente7.Location = new System.Drawing.Point(226, 174);
            this.btnSiguiente7.Name = "btnSiguiente7";
            this.btnSiguiente7.Size = new System.Drawing.Size(75, 23);
            this.btnSiguiente7.TabIndex = 5;
            this.btnSiguiente7.Text = "Siguiente";
            this.btnSiguiente7.UseVisualStyleBackColor = true;
            this.btnSiguiente7.Click += new System.EventHandler(this.btnSiguiente7_Click);
            // 
            // Numero7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 424);
            this.Controls.Add(this.btnRegresar7);
            this.Controls.Add(this.btnAtras7);
            this.Controls.Add(this.btnSiguiente7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Numero7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Numero7";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegresar7;
        private System.Windows.Forms.Button btnAtras7;
        private System.Windows.Forms.Button btnSiguiente7;
    }
}