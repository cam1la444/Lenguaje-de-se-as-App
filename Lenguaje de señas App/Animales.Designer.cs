namespace Lenguaje_de_señas_App
{
    partial class Animales
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
            this.btnPerro = new System.Windows.Forms.Button();
            this.btnJirafa = new System.Windows.Forms.Button();
            this.btnGato = new System.Windows.Forms.Button();
            this.btnNutria = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPerro
            // 
            this.btnPerro.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerro.Location = new System.Drawing.Point(13, 13);
            this.btnPerro.Name = "btnPerro";
            this.btnPerro.Size = new System.Drawing.Size(135, 51);
            this.btnPerro.TabIndex = 0;
            this.btnPerro.Text = "Perro";
            this.btnPerro.UseVisualStyleBackColor = true;
            // 
            // btnJirafa
            // 
            this.btnJirafa.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJirafa.Location = new System.Drawing.Point(155, 13);
            this.btnJirafa.Name = "btnJirafa";
            this.btnJirafa.Size = new System.Drawing.Size(143, 51);
            this.btnJirafa.TabIndex = 1;
            this.btnJirafa.Text = "Jirafa";
            this.btnJirafa.UseVisualStyleBackColor = true;
            // 
            // btnGato
            // 
            this.btnGato.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGato.Location = new System.Drawing.Point(305, 13);
            this.btnGato.Name = "btnGato";
            this.btnGato.Size = new System.Drawing.Size(144, 51);
            this.btnGato.TabIndex = 2;
            this.btnGato.Text = "Gato";
            this.btnGato.UseVisualStyleBackColor = true;
            // 
            // btnNutria
            // 
            this.btnNutria.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNutria.Location = new System.Drawing.Point(456, 13);
            this.btnNutria.Name = "btnNutria";
            this.btnNutria.Size = new System.Drawing.Size(130, 51);
            this.btnNutria.TabIndex = 3;
            this.btnNutria.Text = "Nutria";
            this.btnNutria.UseVisualStyleBackColor = true;
            // 
            // Animales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 442);
            this.Controls.Add(this.btnNutria);
            this.Controls.Add(this.btnGato);
            this.Controls.Add(this.btnJirafa);
            this.Controls.Add(this.btnPerro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Animales";
            this.Text = "Animales";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPerro;
        private System.Windows.Forms.Button btnJirafa;
        private System.Windows.Forms.Button btnGato;
        private System.Windows.Forms.Button btnNutria;
    }
}