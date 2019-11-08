
namespace ProgramaContable
{
    partial class MenuContable
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.botonLibroMayor = new System.Windows.Forms.Button();
            this.botonLibroDiario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botonLibroMayor
            // 
            this.botonLibroMayor.Location = new System.Drawing.Point(220, 51);
            this.botonLibroMayor.Name = "botonLibroMayor";
            this.botonLibroMayor.Size = new System.Drawing.Size(138, 44);
            this.botonLibroMayor.TabIndex = 3;
            this.botonLibroMayor.Text = "Libro Mayor";
            this.botonLibroMayor.UseVisualStyleBackColor = true;
            this.botonLibroMayor.Click += new System.EventHandler(this.botonLibroMayor_Click);
            // 
            // botonLibroDiario
            // 
            this.botonLibroDiario.Location = new System.Drawing.Point(33, 51);
            this.botonLibroDiario.Name = "botonLibroDiario";
            this.botonLibroDiario.Size = new System.Drawing.Size(138, 44);
            this.botonLibroDiario.TabIndex = 0;
            this.botonLibroDiario.Text = "Libro Diario";
            this.botonLibroDiario.UseVisualStyleBackColor = true;
            this.botonLibroDiario.Click += new System.EventHandler(this.BotonLibroDiario_Click);
            // 
            // MenuContable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 140);
            this.Controls.Add(this.botonLibroMayor);
            this.Controls.Add(this.botonLibroDiario);
            this.Name = "MenuContable";
            this.Text = "Menu Principal";
            this.ResumeLayout(false);

        }



        #endregion

        private System.Windows.Forms.Button botonLibroMayor;
        private System.Windows.Forms.Button botonLibroDiario;
    }
}

