namespace Lenguaje_de_señas_App
{
    partial class LetraD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LetraD));
            this.axWMPD = new AxWMPLib.AxWindowsMediaPlayer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRegresarD = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axWMPD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // axWMPD
            // 
            this.axWMPD.Enabled = true;
            this.axWMPD.Location = new System.Drawing.Point(59, 184);
            this.axWMPD.Name = "axWMPD";
            this.axWMPD.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWMPD.OcxState")));
            this.axWMPD.Size = new System.Drawing.Size(222, 192);
            this.axWMPD.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(91, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnRegresarD
            // 
            this.btnRegresarD.BackColor = System.Drawing.Color.PaleGreen;
            this.btnRegresarD.Font = new System.Drawing.Font("HP Simplified", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresarD.Location = new System.Drawing.Point(116, 399);
            this.btnRegresarD.Name = "btnRegresarD";
            this.btnRegresarD.Size = new System.Drawing.Size(98, 33);
            this.btnRegresarD.TabIndex = 3;
            this.btnRegresarD.Text = "Regresar";
            this.btnRegresarD.UseVisualStyleBackColor = false;
            this.btnRegresarD.Click += new System.EventHandler(this.btnRegresarD_Click);
            // 
            // LetraD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(397, 494);
            this.Controls.Add(this.axWMPD);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRegresarD);
            this.MaximizeBox = false;
            this.Name = "LetraD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LetraD";
            ((System.ComponentModel.ISupportInitialize)(this.axWMPD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWMPD;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRegresarD;
    }
}