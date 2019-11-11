namespace ProgramaContable.Vista
{
    partial class VerLibroMayor
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
            this.textBoxMayores = new System.Windows.Forms.TextBox();
            this.botonVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxMayores
            // 
            this.textBoxMayores.Location = new System.Drawing.Point(40, 31);
            this.textBoxMayores.Multiline = true;
            this.textBoxMayores.Name = "textBoxMayores";
            this.textBoxMayores.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxMayores.Size = new System.Drawing.Size(666, 300);
            this.textBoxMayores.TabIndex = 0;
            // 
            // botonVolver
            // 
            this.botonVolver.Location = new System.Drawing.Point(631, 349);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(75, 23);
            this.botonVolver.TabIndex = 1;
            this.botonVolver.Text = "Volver Atras";
            this.botonVolver.UseVisualStyleBackColor = true;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
            // 
            // VerLibroMayor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 396);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.textBoxMayores);
            this.Name = "VerLibroMayor";
            this.Text = "VerLibroMayor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VerLibroMayor_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMayores;
        private System.Windows.Forms.Button botonVolver;
    }
}