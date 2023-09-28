namespace Lenguaje_de_señas_App
{
    partial class Numero8
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
            this.btnRegresar8 = new System.Windows.Forms.Button();
            this.btnAtras8 = new System.Windows.Forms.Button();
            this.btnSiguiente8 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegresar8
            // 
            this.btnRegresar8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegresar8.Location = new System.Drawing.Point(118, 227);
            this.btnRegresar8.Name = "btnRegresar8";
            this.btnRegresar8.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar8.TabIndex = 7;
            this.btnRegresar8.Text = "Regresar";
            this.btnRegresar8.UseVisualStyleBackColor = true;
            this.btnRegresar8.Click += new System.EventHandler(this.btnRegresar8_Click);
            // 
            // btnAtras8
            // 
            this.btnAtras8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtras8.Location = new System.Drawing.Point(27, 174);
            this.btnAtras8.Name = "btnAtras8";
            this.btnAtras8.Size = new System.Drawing.Size(75, 23);
            this.btnAtras8.TabIndex = 6;
            this.btnAtras8.Text = "Atras";
            this.btnAtras8.UseVisualStyleBackColor = true;
            this.btnAtras8.Click += new System.EventHandler(this.btnAtras8_Click);
            // 
            // btnSiguiente8
            // 
            this.btnSiguiente8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSiguiente8.Location = new System.Drawing.Point(226, 174);
            this.btnSiguiente8.Name = "btnSiguiente8";
            this.btnSiguiente8.Size = new System.Drawing.Size(75, 23);
            this.btnSiguiente8.TabIndex = 5;
            this.btnSiguiente8.Text = "Siguiente";
            this.btnSiguiente8.UseVisualStyleBackColor = true;
            this.btnSiguiente8.Click += new System.EventHandler(this.btnSiguiente8_Click);
            // 
            // Numero8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 424);
            this.Controls.Add(this.btnRegresar8);
            this.Controls.Add(this.btnAtras8);
            this.Controls.Add(this.btnSiguiente8);
            this.Name = "Numero8";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Numero8";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegresar8;
        private System.Windows.Forms.Button btnAtras8;
        private System.Windows.Forms.Button btnSiguiente8;
    }
}