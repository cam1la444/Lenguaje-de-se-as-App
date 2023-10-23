namespace Lenguaje_de_señas_App
{
    partial class Numero0
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
            this.btnRegresar0 = new System.Windows.Forms.Button();
            this.btnSiguiente0 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegresar0
            // 
            this.btnRegresar0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegresar0.Location = new System.Drawing.Point(134, 376);
            this.btnRegresar0.Name = "btnRegresar0";
            this.btnRegresar0.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar0.TabIndex = 7;
            this.btnRegresar0.Text = "Regresar";
            this.btnRegresar0.UseVisualStyleBackColor = true;
            this.btnRegresar0.Click += new System.EventHandler(this.btnRegresar0_Click);
            // 
            // btnSiguiente0
            // 
            this.btnSiguiente0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSiguiente0.Location = new System.Drawing.Point(242, 323);
            this.btnSiguiente0.Name = "btnSiguiente0";
            this.btnSiguiente0.Size = new System.Drawing.Size(75, 23);
            this.btnSiguiente0.TabIndex = 5;
            this.btnSiguiente0.Text = "Siguiente";
            this.btnSiguiente0.UseVisualStyleBackColor = true;
            this.btnSiguiente0.Click += new System.EventHandler(this.btnSiguiente0_Click);
            // 
            // Numero0
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 424);
            this.Controls.Add(this.btnRegresar0);
            this.Controls.Add(this.btnSiguiente0);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Numero0";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Numero0";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegresar0;
        private System.Windows.Forms.Button btnSiguiente0;
    }
}