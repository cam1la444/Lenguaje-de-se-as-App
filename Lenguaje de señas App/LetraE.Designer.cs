namespace Lenguaje_de_señas_App
{
    partial class LetraE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LetraE));
            this.axWMPE = new AxWMPLib.AxWindowsMediaPlayer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axWMPE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // axWMPE
            // 
            this.axWMPE.Enabled = true;
            this.axWMPE.Location = new System.Drawing.Point(59, 184);
            this.axWMPE.Name = "axWMPE";
            this.axWMPE.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWMPE.OcxState")));
            this.axWMPE.Size = new System.Drawing.Size(222, 192);
            this.axWMPE.TabIndex = 5;
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
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.PaleGreen;
            this.btnRegresar.Font = new System.Drawing.Font("HP Simplified", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Location = new System.Drawing.Point(116, 399);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(98, 33);
            this.btnRegresar.TabIndex = 3;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // LetraE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(397, 494);
            this.Controls.Add(this.axWMPE);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRegresar);
            this.MaximizeBox = false;
            this.Name = "LetraE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LetraE";
            ((System.ComponentModel.ISupportInitialize)(this.axWMPE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWMPE;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRegresar;
    }
}