namespace Lenguaje_de_señas_App
{
    partial class Numero6
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
            this.btnRegresar6 = new System.Windows.Forms.Button();
            this.btnAtras6 = new System.Windows.Forms.Button();
            this.btnSiguiente6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegresar6
            // 
            this.btnRegresar6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegresar6.Location = new System.Drawing.Point(118, 227);
            this.btnRegresar6.Name = "btnRegresar6";
            this.btnRegresar6.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar6.TabIndex = 7;
            this.btnRegresar6.Text = "Regresar";
            this.btnRegresar6.UseVisualStyleBackColor = true;
            this.btnRegresar6.Click += new System.EventHandler(this.btnRegresar6_Click);
            // 
            // btnAtras6
            // 
            this.btnAtras6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtras6.Location = new System.Drawing.Point(27, 174);
            this.btnAtras6.Name = "btnAtras6";
            this.btnAtras6.Size = new System.Drawing.Size(75, 23);
            this.btnAtras6.TabIndex = 6;
            this.btnAtras6.Text = "Atras";
            this.btnAtras6.UseVisualStyleBackColor = true;
            this.btnAtras6.Click += new System.EventHandler(this.btnAtras6_Click);
            // 
            // btnSiguiente6
            // 
            this.btnSiguiente6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSiguiente6.Location = new System.Drawing.Point(226, 174);
            this.btnSiguiente6.Name = "btnSiguiente6";
            this.btnSiguiente6.Size = new System.Drawing.Size(75, 23);
            this.btnSiguiente6.TabIndex = 5;
            this.btnSiguiente6.Text = "Siguiente";
            this.btnSiguiente6.UseVisualStyleBackColor = true;
            this.btnSiguiente6.Click += new System.EventHandler(this.btnSiguiente6_Click);
            // 
            // Numero6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 424);
            this.Controls.Add(this.btnRegresar6);
            this.Controls.Add(this.btnAtras6);
            this.Controls.Add(this.btnSiguiente6);
            this.Name = "Numero6";
            this.Text = "Numero6";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegresar6;
        private System.Windows.Forms.Button btnAtras6;
        private System.Windows.Forms.Button btnSiguiente6;
    }
}