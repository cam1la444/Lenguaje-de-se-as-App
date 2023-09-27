namespace Lenguaje_de_señas_App
{
    partial class Numero2
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
            this.btnAtras1 = new System.Windows.Forms.Button();
            this.btnSiguiente3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAtras1
            // 
            this.btnAtras1.Location = new System.Drawing.Point(29, 351);
            this.btnAtras1.Name = "btnAtras1";
            this.btnAtras1.Size = new System.Drawing.Size(75, 23);
            this.btnAtras1.TabIndex = 5;
            this.btnAtras1.Text = "Atras";
            this.btnAtras1.UseVisualStyleBackColor = true;
            this.btnAtras1.Click += new System.EventHandler(this.btnAtras1_Click);
            // 
            // btnSiguiente3
            // 
            this.btnSiguiente3.Location = new System.Drawing.Point(228, 351);
            this.btnSiguiente3.Name = "btnSiguiente3";
            this.btnSiguiente3.Size = new System.Drawing.Size(75, 23);
            this.btnSiguiente3.TabIndex = 4;
            this.btnSiguiente3.Text = "Siguiente";
            this.btnSiguiente3.UseVisualStyleBackColor = true;
            this.btnSiguiente3.Click += new System.EventHandler(this.btnSiguiente3_Click);
            // 
            // Numero2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 424);
            this.Controls.Add(this.btnAtras1);
            this.Controls.Add(this.btnSiguiente3);
            this.Name = "Numero2";
            this.Text = "Numero2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAtras1;
        private System.Windows.Forms.Button btnSiguiente3;
    }
}