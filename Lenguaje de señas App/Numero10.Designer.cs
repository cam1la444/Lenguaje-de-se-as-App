namespace Lenguaje_de_señas_App
{
    partial class Numero10
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
            this.btnRegresar10 = new System.Windows.Forms.Button();
            this.btnAtras10 = new System.Windows.Forms.Button();
            this.btnSiguiente10 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegresar10
            // 
            this.btnRegresar10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegresar10.Location = new System.Drawing.Point(118, 227);
            this.btnRegresar10.Name = "btnRegresar10";
            this.btnRegresar10.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar10.TabIndex = 7;
            this.btnRegresar10.Text = "Regresar";
            this.btnRegresar10.UseVisualStyleBackColor = true;
            this.btnRegresar10.Click += new System.EventHandler(this.btnRegresar10_Click);
            // 
            // btnAtras10
            // 
            this.btnAtras10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtras10.Location = new System.Drawing.Point(27, 174);
            this.btnAtras10.Name = "btnAtras10";
            this.btnAtras10.Size = new System.Drawing.Size(75, 23);
            this.btnAtras10.TabIndex = 6;
            this.btnAtras10.Text = "Atras";
            this.btnAtras10.UseVisualStyleBackColor = true;
            this.btnAtras10.Click += new System.EventHandler(this.btnAtras10_Click);
            // 
            // btnSiguiente10
            // 
            this.btnSiguiente10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSiguiente10.Location = new System.Drawing.Point(226, 174);
            this.btnSiguiente10.Name = "btnSiguiente10";
            this.btnSiguiente10.Size = new System.Drawing.Size(75, 23);
            this.btnSiguiente10.TabIndex = 5;
            this.btnSiguiente10.Text = "Siguiente";
            this.btnSiguiente10.UseVisualStyleBackColor = true;
            this.btnSiguiente10.Click += new System.EventHandler(this.btnSiguiente10_Click);
            // 
            // Numero10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 424);
            this.Controls.Add(this.btnRegresar10);
            this.Controls.Add(this.btnAtras10);
            this.Controls.Add(this.btnSiguiente10);
            this.Name = "Numero10";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Numero10";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegresar10;
        private System.Windows.Forms.Button btnAtras10;
        private System.Windows.Forms.Button btnSiguiente10;
    }
}