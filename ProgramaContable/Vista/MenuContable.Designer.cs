
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
            this.button1 = new System.Windows.Forms.Button();
            this.BAgregarCuenta = new System.Windows.Forms.Button();
            this.BPlanCuentas = new System.Windows.Forms.Button();
            this.BLibroMayor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Libro Diario";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // BAgregarCuenta
            // 
            this.BAgregarCuenta.Location = new System.Drawing.Point(13, 71);
            this.BAgregarCuenta.Name = "BAgregarCuenta";
            this.BAgregarCuenta.Size = new System.Drawing.Size(198, 23);
            this.BAgregarCuenta.TabIndex = 2;
            this.BAgregarCuenta.Text = "Agregar cuenta";
            this.BAgregarCuenta.UseVisualStyleBackColor = true;
            // 
            // BPlanCuentas
            // 
            this.BPlanCuentas.Location = new System.Drawing.Point(13, 42);
            this.BPlanCuentas.Name = "BPlanCuentas";
            this.BPlanCuentas.Size = new System.Drawing.Size(198, 23);
            this.BPlanCuentas.TabIndex = 3;
            this.BPlanCuentas.Text = "Plan de cuentas";
            this.BPlanCuentas.UseVisualStyleBackColor = true;
            this.BPlanCuentas.Click += new System.EventHandler(this.Button4_Click);
            // 
            // BLibroMayor
            // 
            this.BLibroMayor.Location = new System.Drawing.Point(12, 100);
            this.BLibroMayor.Name = "BLibroMayor";
            this.BLibroMayor.Size = new System.Drawing.Size(198, 23);
            this.BLibroMayor.TabIndex = 4;
            this.BLibroMayor.Text = "Libro mayor";
            this.BLibroMayor.UseVisualStyleBackColor = true;
            this.BLibroMayor.Click += new System.EventHandler(this.BLibroMayor_Click);
            // 
            // MenuContable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 450);
            this.Controls.Add(this.BLibroMayor);
            this.Controls.Add(this.BPlanCuentas);
            this.Controls.Add(this.BAgregarCuenta);
            this.Controls.Add(this.button1);
            this.Name = "MenuContable";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BAgregarCuenta;
        private System.Windows.Forms.Button BPlanCuentas;
        private System.Windows.Forms.Button BLibroMayor;
    }
}

