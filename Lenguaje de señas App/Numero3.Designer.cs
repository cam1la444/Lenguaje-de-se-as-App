﻿namespace Lenguaje_de_señas_App
{
    partial class Numero3
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
            this.btnRegresar30 = new System.Windows.Forms.Button();
            this.btnAtras30 = new System.Windows.Forms.Button();
            this.btnSiguiente30 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegresar30
            // 
            this.btnRegresar30.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegresar30.Location = new System.Drawing.Point(118, 227);
            this.btnRegresar30.Name = "btnRegresar30";
            this.btnRegresar30.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar30.TabIndex = 7;
            this.btnRegresar30.Text = "Regresar";
            this.btnRegresar30.UseVisualStyleBackColor = true;
            this.btnRegresar30.Click += new System.EventHandler(this.btnRegresar30_Click);
            // 
            // btnAtras30
            // 
            this.btnAtras30.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtras30.Location = new System.Drawing.Point(27, 174);
            this.btnAtras30.Name = "btnAtras30";
            this.btnAtras30.Size = new System.Drawing.Size(75, 23);
            this.btnAtras30.TabIndex = 6;
            this.btnAtras30.Text = "Atras";
            this.btnAtras30.UseVisualStyleBackColor = true;
            this.btnAtras30.Click += new System.EventHandler(this.btnAtras30_Click);
            // 
            // btnSiguiente30
            // 
            this.btnSiguiente30.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSiguiente30.Location = new System.Drawing.Point(226, 174);
            this.btnSiguiente30.Name = "btnSiguiente30";
            this.btnSiguiente30.Size = new System.Drawing.Size(75, 23);
            this.btnSiguiente30.TabIndex = 5;
            this.btnSiguiente30.Text = "Siguiente";
            this.btnSiguiente30.UseVisualStyleBackColor = true;
            this.btnSiguiente30.Click += new System.EventHandler(this.btnSiguiente30_Click);
            // 
            // Numero3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 424);
            this.Controls.Add(this.btnRegresar30);
            this.Controls.Add(this.btnAtras30);
            this.Controls.Add(this.btnSiguiente30);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Numero3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Numero3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegresar30;
        private System.Windows.Forms.Button btnAtras30;
        private System.Windows.Forms.Button btnSiguiente30;
    }
}