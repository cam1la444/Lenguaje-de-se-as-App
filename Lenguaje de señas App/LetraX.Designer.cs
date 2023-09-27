namespace Lenguaje_de_señas_App
{
    partial class LetraX
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LetraX));
            this.btnReproducir = new System.Windows.Forms.Button();
            this.axWMPE = new AxWMPLib.AxWindowsMediaPlayer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axWMPE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReproducir
            // 
            this.btnReproducir.BackColor = System.Drawing.Color.Khaki;
            this.btnReproducir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReproducir.Font = new System.Drawing.Font("HP Simplified", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReproducir.Location = new System.Drawing.Point(85, 383);
            this.btnReproducir.Name = "btnReproducir";
            this.btnReproducir.Size = new System.Drawing.Size(133, 46);
            this.btnReproducir.TabIndex = 11;
            this.btnReproducir.Text = "Reproducir video";
            this.btnReproducir.UseVisualStyleBackColor = false;
            // 
            // axWMPE
            // 
            this.axWMPE.Enabled = true;
            this.axWMPE.Location = new System.Drawing.Point(35, 168);
            this.axWMPE.Name = "axWMPE";
            this.axWMPE.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWMPE.OcxState")));
            this.axWMPE.Size = new System.Drawing.Size(237, 209);
            this.axWMPE.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(75, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.PaleGreen;
            this.btnRegresar.Font = new System.Drawing.Font("HP Simplified", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Location = new System.Drawing.Point(101, 454);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(98, 33);
            this.btnRegresar.TabIndex = 8;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            // 
            // LetraX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 499);
            this.Controls.Add(this.btnReproducir);
            this.Controls.Add(this.axWMPE);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRegresar);
            this.Name = "LetraX";
            this.Text = "LetraX";
            ((System.ComponentModel.ISupportInitialize)(this.axWMPE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReproducir;
        private AxWMPLib.AxWindowsMediaPlayer axWMPE;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRegresar;
    }
}