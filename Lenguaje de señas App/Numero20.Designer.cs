namespace Lenguaje_de_señas_App
{
    partial class Numero20
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
            this.btnRegresar20 = new System.Windows.Forms.Button();
            this.btnAtras20 = new System.Windows.Forms.Button();
            this.btnSiguiente20 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegresar20
            // 
            this.btnRegresar20.Location = new System.Drawing.Point(118, 227);
            this.btnRegresar20.Name = "btnRegresar20";
            this.btnRegresar20.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar20.TabIndex = 7;
            this.btnRegresar20.Text = "Regresar";
            this.btnRegresar20.UseVisualStyleBackColor = true;
            this.btnRegresar20.Click += new System.EventHandler(this.btnRegresar20_Click);
            // 
            // btnAtras20
            // 
            this.btnAtras20.Location = new System.Drawing.Point(27, 174);
            this.btnAtras20.Name = "btnAtras20";
            this.btnAtras20.Size = new System.Drawing.Size(75, 23);
            this.btnAtras20.TabIndex = 6;
            this.btnAtras20.Text = "Atras";
            this.btnAtras20.UseVisualStyleBackColor = true;
            this.btnAtras20.Click += new System.EventHandler(this.btnAtras20_Click);
            // 
            // btnSiguiente20
            // 
            this.btnSiguiente20.Location = new System.Drawing.Point(226, 174);
            this.btnSiguiente20.Name = "btnSiguiente20";
            this.btnSiguiente20.Size = new System.Drawing.Size(75, 23);
            this.btnSiguiente20.TabIndex = 5;
            this.btnSiguiente20.Text = "Siguiente";
            this.btnSiguiente20.UseVisualStyleBackColor = true;
            this.btnSiguiente20.Click += new System.EventHandler(this.btnSiguiente20_Click);
            // 
            // Numero20
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 424);
            this.Controls.Add(this.btnRegresar20);
            this.Controls.Add(this.btnAtras20);
            this.Controls.Add(this.btnSiguiente20);
            this.Name = "Numero20";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Numero20";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegresar20;
        private System.Windows.Forms.Button btnAtras20;
        private System.Windows.Forms.Button btnSiguiente20;
    }
}