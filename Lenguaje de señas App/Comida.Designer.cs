namespace Lenguaje_de_señas_App
{
    partial class Comida
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
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAcercade = new System.Windows.Forms.Button();
            this.btnMasInforms = new System.Windows.Forms.Button();
            this.btnLecciones = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLimon = new System.Windows.Forms.Button();
            this.btnMandarina = new System.Windows.Forms.Button();
            this.btnSandia = new System.Windows.Forms.Button();
            this.btnPiña = new System.Windows.Forms.Button();
            this.btnDurazno = new System.Windows.Forms.Button();
            this.btnFresa = new System.Windows.Forms.Button();
            this.btnNaranja = new System.Windows.Forms.Button();
            this.btnManzana = new System.Windows.Forms.Button();
            this.btnMango = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(752, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(38, 34);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(179)))), ((int)(((byte)(213)))));
            this.panel1.Controls.Add(this.btnAcercade);
            this.panel1.Controls.Add(this.btnMasInforms);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnLecciones);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(790, 34);
            this.panel1.TabIndex = 21;
            // 
            // btnAcercade
            // 
            this.btnAcercade.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAcercade.FlatAppearance.BorderSize = 0;
            this.btnAcercade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcercade.Location = new System.Drawing.Point(252, 0);
            this.btnAcercade.Name = "btnAcercade";
            this.btnAcercade.Size = new System.Drawing.Size(106, 34);
            this.btnAcercade.TabIndex = 6;
            this.btnAcercade.Text = "Acerca de ";
            this.btnAcercade.UseVisualStyleBackColor = true;
            this.btnAcercade.Click += new System.EventHandler(this.btnAcercade_Click);
            // 
            // btnMasInforms
            // 
            this.btnMasInforms.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMasInforms.FlatAppearance.BorderSize = 0;
            this.btnMasInforms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMasInforms.Location = new System.Drawing.Point(146, 0);
            this.btnMasInforms.Name = "btnMasInforms";
            this.btnMasInforms.Size = new System.Drawing.Size(106, 34);
            this.btnMasInforms.TabIndex = 5;
            this.btnMasInforms.Text = "Más información";
            this.btnMasInforms.UseVisualStyleBackColor = true;
            // 
            // btnLecciones
            // 
            this.btnLecciones.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLecciones.FlatAppearance.BorderSize = 0;
            this.btnLecciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLecciones.Location = new System.Drawing.Point(40, 0);
            this.btnLecciones.Name = "btnLecciones";
            this.btnLecciones.Size = new System.Drawing.Size(106, 34);
            this.btnLecciones.TabIndex = 2;
            this.btnLecciones.Text = "Lecciones";
            this.btnLecciones.UseVisualStyleBackColor = true;
            this.btnLecciones.Click += new System.EventHandler(this.btnMasInfo_Click);
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
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(706, 452);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(72, 32);
            this.btnVolver.TabIndex = 39;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(270, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 42);
            this.label1.TabIndex = 60;
            this.label1.Text = "Lección Comida";
            // 
            // btnLimon
            // 
            this.btnLimon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimon.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnLimon.FlatAppearance.BorderSize = 2;
            this.btnLimon.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnLimon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnLimon.Location = new System.Drawing.Point(309, 182);
            this.btnLimon.Name = "btnLimon";
            this.btnLimon.Size = new System.Drawing.Size(135, 51);
            this.btnLimon.TabIndex = 80;
            this.btnLimon.Text = "Limón";
            this.btnLimon.UseVisualStyleBackColor = true;
            this.btnLimon.Click += new System.EventHandler(this.btnLimon_Click);
            // 
            // btnMandarina
            // 
            this.btnMandarina.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMandarina.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMandarina.FlatAppearance.BorderSize = 2;
            this.btnMandarina.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnMandarina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMandarina.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnMandarina.Location = new System.Drawing.Point(591, 125);
            this.btnMandarina.Name = "btnMandarina";
            this.btnMandarina.Size = new System.Drawing.Size(135, 51);
            this.btnMandarina.TabIndex = 78;
            this.btnMandarina.Text = "Mandarina";
            this.btnMandarina.UseVisualStyleBackColor = true;
            this.btnMandarina.Click += new System.EventHandler(this.btnMandarina_Click);
            // 
            // btnSandia
            // 
            this.btnSandia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSandia.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnSandia.FlatAppearance.BorderSize = 2;
            this.btnSandia.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnSandia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSandia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnSandia.Location = new System.Drawing.Point(168, 182);
            this.btnSandia.Name = "btnSandia";
            this.btnSandia.Size = new System.Drawing.Size(135, 51);
            this.btnSandia.TabIndex = 76;
            this.btnSandia.Text = "Sandia";
            this.btnSandia.UseVisualStyleBackColor = true;
            this.btnSandia.Click += new System.EventHandler(this.btnSandia_Click);
            // 
            // btnPiña
            // 
            this.btnPiña.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPiña.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnPiña.FlatAppearance.BorderSize = 2;
            this.btnPiña.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnPiña.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPiña.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnPiña.Location = new System.Drawing.Point(22, 239);
            this.btnPiña.Name = "btnPiña";
            this.btnPiña.Size = new System.Drawing.Size(135, 51);
            this.btnPiña.TabIndex = 75;
            this.btnPiña.Text = "Piña";
            this.btnPiña.UseVisualStyleBackColor = true;
            this.btnPiña.Click += new System.EventHandler(this.btnPiña_Click);
            // 
            // btnDurazno
            // 
            this.btnDurazno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDurazno.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnDurazno.FlatAppearance.BorderSize = 2;
            this.btnDurazno.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnDurazno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDurazno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnDurazno.Location = new System.Drawing.Point(22, 182);
            this.btnDurazno.Name = "btnDurazno";
            this.btnDurazno.Size = new System.Drawing.Size(135, 51);
            this.btnDurazno.TabIndex = 73;
            this.btnDurazno.Text = "Durazno";
            this.btnDurazno.UseVisualStyleBackColor = true;
            this.btnDurazno.Click += new System.EventHandler(this.btnDurazno_Click);
            // 
            // btnFresa
            // 
            this.btnFresa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFresa.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnFresa.FlatAppearance.BorderSize = 2;
            this.btnFresa.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnFresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnFresa.Location = new System.Drawing.Point(168, 125);
            this.btnFresa.Name = "btnFresa";
            this.btnFresa.Size = new System.Drawing.Size(135, 51);
            this.btnFresa.TabIndex = 72;
            this.btnFresa.Text = "Fresa";
            this.btnFresa.UseVisualStyleBackColor = true;
            this.btnFresa.Click += new System.EventHandler(this.btnFresa_Click);
            // 
            // btnNaranja
            // 
            this.btnNaranja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNaranja.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnNaranja.FlatAppearance.BorderSize = 2;
            this.btnNaranja.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnNaranja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNaranja.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnNaranja.Location = new System.Drawing.Point(22, 299);
            this.btnNaranja.Name = "btnNaranja";
            this.btnNaranja.Size = new System.Drawing.Size(135, 51);
            this.btnNaranja.TabIndex = 71;
            this.btnNaranja.Text = "Naranja";
            this.btnNaranja.UseVisualStyleBackColor = true;
            this.btnNaranja.Click += new System.EventHandler(this.btnNaranja_Click);
            // 
            // btnManzana
            // 
            this.btnManzana.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManzana.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnManzana.FlatAppearance.BorderSize = 2;
            this.btnManzana.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnManzana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManzana.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnManzana.Location = new System.Drawing.Point(22, 125);
            this.btnManzana.Name = "btnManzana";
            this.btnManzana.Size = new System.Drawing.Size(135, 51);
            this.btnManzana.TabIndex = 69;
            this.btnManzana.Text = "Manzana";
            this.btnManzana.UseVisualStyleBackColor = true;
            this.btnManzana.Click += new System.EventHandler(this.btnManzana_Click);
            // 
            // btnMango
            // 
            this.btnMango.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMango.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMango.FlatAppearance.BorderSize = 2;
            this.btnMango.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnMango.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMango.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnMango.Location = new System.Drawing.Point(309, 353);
            this.btnMango.Name = "btnMango";
            this.btnMango.Size = new System.Drawing.Size(135, 51);
            this.btnMango.TabIndex = 90;
            this.btnMango.Text = "Mango";
            this.btnMango.UseVisualStyleBackColor = true;
            // 
            // Comida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(790, 496);
            this.Controls.Add(this.btnMango);
            this.Controls.Add(this.btnLimon);
            this.Controls.Add(this.btnMandarina);
            this.Controls.Add(this.btnSandia);
            this.Controls.Add(this.btnPiña);
            this.Controls.Add(this.btnDurazno);
            this.Controls.Add(this.btnFresa);
            this.Controls.Add(this.btnNaranja);
            this.Controls.Add(this.btnManzana);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Comida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comida";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLecciones;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLimon;
        private System.Windows.Forms.Button btnMandarina;
        private System.Windows.Forms.Button btnSandia;
        private System.Windows.Forms.Button btnPiña;
        private System.Windows.Forms.Button btnDurazno;
        private System.Windows.Forms.Button btnFresa;
        private System.Windows.Forms.Button btnNaranja;
        private System.Windows.Forms.Button btnManzana;
        private System.Windows.Forms.Button btnAcercade;
        private System.Windows.Forms.Button btnMasInforms;
        private System.Windows.Forms.Button btnMango;
    }
}