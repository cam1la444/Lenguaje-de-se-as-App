namespace Lenguaje_de_señas_App
{
    partial class Numero1
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
            this.btnSiguiente2 = new System.Windows.Forms.Button();
            this.btnAtras0 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSiguiente2
            // 
            this.btnSiguiente2.Location = new System.Drawing.Point(242, 376);
            this.btnSiguiente2.Name = "btnSiguiente2";
            this.btnSiguiente2.Size = new System.Drawing.Size(75, 23);
            this.btnSiguiente2.TabIndex = 2;
            this.btnSiguiente2.Text = "Siguiente";
            this.btnSiguiente2.UseVisualStyleBackColor = true;
            this.btnSiguiente2.Click += new System.EventHandler(this.btnSiguiente2_Click);
            // 
            // btnAtras0
            // 
            this.btnAtras0.Location = new System.Drawing.Point(43, 376);
            this.btnAtras0.Name = "btnAtras0";
            this.btnAtras0.Size = new System.Drawing.Size(75, 23);
            this.btnAtras0.TabIndex = 3;
            this.btnAtras0.Text = "Atras";
            this.btnAtras0.UseVisualStyleBackColor = true;
            this.btnAtras0.Click += new System.EventHandler(this.btnAtras0_Click);
            // 
            // Numero1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 424);
            this.Controls.Add(this.btnAtras0);
            this.Controls.Add(this.btnSiguiente2);
            this.Name = "Numero1";
            this.Text = "Numero1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSiguiente2;
        private System.Windows.Forms.Button btnAtras0;
    }
}