﻿namespace Lenguaje_de_señas_App
{
    partial class Esta_Noche
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
            this.btnReproducir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReproducir
            // 
            this.btnReproducir.BackColor = System.Drawing.Color.Khaki;
            this.btnReproducir.Location = new System.Drawing.Point(335, 166);
            this.btnReproducir.Name = "btnReproducir";
            this.btnReproducir.Size = new System.Drawing.Size(75, 56);
            this.btnReproducir.TabIndex = 2;
            this.btnReproducir.Text = "Reproducir video";
            this.btnReproducir.UseVisualStyleBackColor = false;
            // 
            // Esta_Noche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(422, 450);
            this.Controls.Add(this.btnReproducir);
            this.Name = "Esta_Noche";
            this.Text = "Esta_Noche";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReproducir;
    }
}