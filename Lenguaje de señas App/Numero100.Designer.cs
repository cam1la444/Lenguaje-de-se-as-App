namespace Lenguaje_de_señas_App
{
    partial class Numero100
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
            this.btnRegresar100 = new System.Windows.Forms.Button();
            this.btnAtras100 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegresar100
            // 
            this.btnRegresar100.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegresar100.Location = new System.Drawing.Point(118, 227);
            this.btnRegresar100.Name = "btnRegresar100";
            this.btnRegresar100.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar100.TabIndex = 7;
            this.btnRegresar100.Text = "Regresar";
            this.btnRegresar100.UseVisualStyleBackColor = true;
            this.btnRegresar100.Click += new System.EventHandler(this.btnRegresar100_Click);
            // 
            // btnAtras100
            // 
            this.btnAtras100.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtras100.Location = new System.Drawing.Point(27, 174);
            this.btnAtras100.Name = "btnAtras100";
            this.btnAtras100.Size = new System.Drawing.Size(75, 23);
            this.btnAtras100.TabIndex = 6;
            this.btnAtras100.Text = "Atras";
            this.btnAtras100.UseVisualStyleBackColor = true;
            this.btnAtras100.Click += new System.EventHandler(this.btnAtras100_Click);
            // 
            // Numero100
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 424);
            this.Controls.Add(this.btnRegresar100);
            this.Controls.Add(this.btnAtras100);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Numero100";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Numero100";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegresar100;
        private System.Windows.Forms.Button btnAtras100;
    }
}