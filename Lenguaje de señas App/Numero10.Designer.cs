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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(179)))), ((int)(((byte)(213)))));
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 34);
            this.panel1.TabIndex = 41;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(291, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(38, 34);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(40, 34);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::Lenguaje_de_señas_App.Properties.Resources.Untitled7_20230810144444;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // Numero10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 424);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRegresar10);
            this.Controls.Add(this.btnAtras10);
            this.Controls.Add(this.btnSiguiente10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Numero10";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Numero10";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegresar10;
        private System.Windows.Forms.Button btnAtras10;
        private System.Windows.Forms.Button btnSiguiente10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}