namespace Lenguaje_de_señas_App
{
    partial class Numero60
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
            this.btnRegresar60 = new System.Windows.Forms.Button();
            this.btnAtras60 = new System.Windows.Forms.Button();
            this.btnSiguiente60 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegresar60
            // 
            this.btnRegresar60.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegresar60.Location = new System.Drawing.Point(118, 227);
            this.btnRegresar60.Name = "btnRegresar60";
            this.btnRegresar60.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar60.TabIndex = 7;
            this.btnRegresar60.Text = "Regresar";
            this.btnRegresar60.UseVisualStyleBackColor = true;
            this.btnRegresar60.Click += new System.EventHandler(this.btnRegresar60_Click);
            // 
            // btnAtras60
            // 
            this.btnAtras60.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtras60.Location = new System.Drawing.Point(27, 174);
            this.btnAtras60.Name = "btnAtras60";
            this.btnAtras60.Size = new System.Drawing.Size(75, 23);
            this.btnAtras60.TabIndex = 6;
            this.btnAtras60.Text = "Atras";
            this.btnAtras60.UseVisualStyleBackColor = true;
            this.btnAtras60.Click += new System.EventHandler(this.btnAtras60_Click);
            // 
            // btnSiguiente60
            // 
            this.btnSiguiente60.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSiguiente60.Location = new System.Drawing.Point(226, 174);
            this.btnSiguiente60.Name = "btnSiguiente60";
            this.btnSiguiente60.Size = new System.Drawing.Size(75, 23);
            this.btnSiguiente60.TabIndex = 5;
            this.btnSiguiente60.Text = "Siguiente";
            this.btnSiguiente60.UseVisualStyleBackColor = true;
            this.btnSiguiente60.Click += new System.EventHandler(this.btnSiguiente60_Click);
            // 
            // Numero60
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 424);
            this.Controls.Add(this.btnRegresar60);
            this.Controls.Add(this.btnAtras60);
            this.Controls.Add(this.btnSiguiente60);
            this.Name = "Numero60";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Numero60";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegresar60;
        private System.Windows.Forms.Button btnAtras60;
        private System.Windows.Forms.Button btnSiguiente60;
    }
}