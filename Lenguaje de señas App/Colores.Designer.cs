﻿namespace Lenguaje_de_señas_App
{
    partial class Colores
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
            this.btnRojo = new System.Windows.Forms.Button();
            this.btnNegro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRojo
            // 
            this.btnRojo.BackColor = System.Drawing.Color.Red;
            this.btnRojo.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRojo.Location = new System.Drawing.Point(13, 13);
            this.btnRojo.Name = "btnRojo";
            this.btnRojo.Size = new System.Drawing.Size(136, 51);
            this.btnRojo.TabIndex = 0;
            this.btnRojo.Text = "Rojo";
            this.btnRojo.UseVisualStyleBackColor = false;
            // 
            // btnNegro
            // 
            this.btnNegro.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnNegro.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNegro.ForeColor = System.Drawing.Color.White;
            this.btnNegro.Location = new System.Drawing.Point(156, 13);
            this.btnNegro.Name = "btnNegro";
            this.btnNegro.Size = new System.Drawing.Size(132, 51);
            this.btnNegro.TabIndex = 1;
            this.btnNegro.Text = "Negro";
            this.btnNegro.UseVisualStyleBackColor = false;
            // 
            // Colores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNegro);
            this.Controls.Add(this.btnRojo);
            this.Name = "Colores";
            this.Text = "Colores";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRojo;
        private System.Windows.Forms.Button btnNegro;
    }
}