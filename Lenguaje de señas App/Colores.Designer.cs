namespace Lenguaje_de_señas_App
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
            this.btnBlanco = new System.Windows.Forms.Button();
            this.btnAzul = new System.Windows.Forms.Button();
            this.btnAmarillo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            this.btnNegro.Location = new System.Drawing.Point(182, 12);
            this.btnNegro.Name = "btnNegro";
            this.btnNegro.Size = new System.Drawing.Size(136, 51);
            this.btnNegro.TabIndex = 1;
            this.btnNegro.Text = "Negro";
            this.btnNegro.UseVisualStyleBackColor = false;
            // 
            // btnBlanco
            // 
            this.btnBlanco.BackColor = System.Drawing.Color.White;
            this.btnBlanco.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlanco.Location = new System.Drawing.Point(366, 12);
            this.btnBlanco.Name = "btnBlanco";
            this.btnBlanco.Size = new System.Drawing.Size(136, 51);
            this.btnBlanco.TabIndex = 2;
            this.btnBlanco.Text = "Blanco";
            this.btnBlanco.UseVisualStyleBackColor = false;
            // 
            // btnAzul
            // 
            this.btnAzul.BackColor = System.Drawing.Color.Blue;
            this.btnAzul.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAzul.Location = new System.Drawing.Point(533, 12);
            this.btnAzul.Name = "btnAzul";
            this.btnAzul.Size = new System.Drawing.Size(136, 51);
            this.btnAzul.TabIndex = 3;
            this.btnAzul.Text = "Azul";
            this.btnAzul.UseVisualStyleBackColor = false;
            // 
            // btnAmarillo
            // 
            this.btnAmarillo.BackColor = System.Drawing.Color.Yellow;
            this.btnAmarillo.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAmarillo.Location = new System.Drawing.Point(13, 96);
            this.btnAmarillo.Name = "btnAmarillo";
            this.btnAmarillo.Size = new System.Drawing.Size(136, 51);
            this.btnAmarillo.TabIndex = 4;
            this.btnAmarillo.Text = "Amarillo";
            this.btnAmarillo.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Pink;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(182, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 51);
            this.button1.TabIndex = 5;
            this.button1.Text = "Rosado";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Colores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAmarillo);
            this.Controls.Add(this.btnAzul);
            this.Controls.Add(this.btnBlanco);
            this.Controls.Add(this.btnNegro);
            this.Controls.Add(this.btnRojo);
            this.Name = "Colores";
            this.Text = "Colores";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRojo;
        private System.Windows.Forms.Button btnNegro;
        private System.Windows.Forms.Button btnBlanco;
        private System.Windows.Forms.Button btnAzul;
        private System.Windows.Forms.Button btnAmarillo;
        private System.Windows.Forms.Button button1;
    }
}