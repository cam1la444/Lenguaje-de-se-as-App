namespace Lenguaje_de_señas_App
{
    partial class Blanco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Blanco));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnReproducir = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(133, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnReproducir
            // 
            this.btnReproducir.BackColor = System.Drawing.Color.Khaki;
            this.btnReproducir.Location = new System.Drawing.Point(294, 219);
            this.btnReproducir.Name = "btnReproducir";
            this.btnReproducir.Size = new System.Drawing.Size(75, 53);
            this.btnReproducir.TabIndex = 1;
            this.btnReproducir.Text = "Reproducir video";
            this.btnReproducir.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.PaleGreen;
            this.button2.Location = new System.Drawing.Point(133, 374);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 39);
            this.button2.TabIndex = 2;
            this.button2.Text = "Regresar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Blanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnReproducir);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Blanco";
            this.Text = "Blanco";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnReproducir;
        private System.Windows.Forms.Button button2;
    }
}