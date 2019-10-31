namespace ProgramaContable.Vista
{
    partial class LibroMayor
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
            this.labelTipoDeCuenta = new System.Windows.Forms.Label();
            this.labelNombreDeCuenta = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.groupBoxLibroMayor = new System.Windows.Forms.GroupBox();
            this.botonVerCuenta = new System.Windows.Forms.Button();
            this.botonVerTipoCuenta = new System.Windows.Forms.Button();
            this.botonVerTodo = new System.Windows.Forms.Button();
            this.botonCancelar = new System.Windows.Forms.Button();
            this.labelMesyAnio = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.groupBoxLibroMayor.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTipoDeCuenta
            // 
            this.labelTipoDeCuenta.AutoSize = true;
            this.labelTipoDeCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipoDeCuenta.Location = new System.Drawing.Point(17, 38);
            this.labelTipoDeCuenta.Name = "labelTipoDeCuenta";
            this.labelTipoDeCuenta.Size = new System.Drawing.Size(219, 20);
            this.labelTipoDeCuenta.TabIndex = 0;
            this.labelTipoDeCuenta.Text = "Seleccione el Tipo de Cuenta:";
            // 
            // labelNombreDeCuenta
            // 
            this.labelNombreDeCuenta.AutoSize = true;
            this.labelNombreDeCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreDeCuenta.Location = new System.Drawing.Point(17, 78);
            this.labelNombreDeCuenta.Name = "labelNombreDeCuenta";
            this.labelNombreDeCuenta.Size = new System.Drawing.Size(245, 20);
            this.labelNombreDeCuenta.TabIndex = 1;
            this.labelNombreDeCuenta.Text = "Seleccione el Nombre de Cuenta:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(294, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(196, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(294, 80);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(196, 21);
            this.comboBox2.TabIndex = 3;
            // 
            // groupBoxLibroMayor
            // 
            this.groupBoxLibroMayor.Controls.Add(this.comboBox4);
            this.groupBoxLibroMayor.Controls.Add(this.comboBox3);
            this.groupBoxLibroMayor.Controls.Add(this.labelMesyAnio);
            this.groupBoxLibroMayor.Controls.Add(this.botonCancelar);
            this.groupBoxLibroMayor.Controls.Add(this.botonVerTodo);
            this.groupBoxLibroMayor.Controls.Add(this.botonVerTipoCuenta);
            this.groupBoxLibroMayor.Controls.Add(this.botonVerCuenta);
            this.groupBoxLibroMayor.Controls.Add(this.labelTipoDeCuenta);
            this.groupBoxLibroMayor.Controls.Add(this.comboBox2);
            this.groupBoxLibroMayor.Controls.Add(this.comboBox1);
            this.groupBoxLibroMayor.Controls.Add(this.labelNombreDeCuenta);
            this.groupBoxLibroMayor.Location = new System.Drawing.Point(23, 12);
            this.groupBoxLibroMayor.Name = "groupBoxLibroMayor";
            this.groupBoxLibroMayor.Size = new System.Drawing.Size(527, 274);
            this.groupBoxLibroMayor.TabIndex = 4;
            this.groupBoxLibroMayor.TabStop = false;
            this.groupBoxLibroMayor.Text = "Ver Libro Mayor";
            // 
            // botonVerCuenta
            // 
            this.botonVerCuenta.Location = new System.Drawing.Point(97, 172);
            this.botonVerCuenta.Name = "botonVerCuenta";
            this.botonVerCuenta.Size = new System.Drawing.Size(89, 23);
            this.botonVerCuenta.TabIndex = 4;
            this.botonVerCuenta.Text = "Ver Cuenta";
            this.botonVerCuenta.UseVisualStyleBackColor = true;
            this.botonVerCuenta.Click += new System.EventHandler(this.botonVerCuenta_Click);
            // 
            // botonVerTipoCuenta
            // 
            this.botonVerTipoCuenta.Location = new System.Drawing.Point(224, 172);
            this.botonVerTipoCuenta.Name = "botonVerTipoCuenta";
            this.botonVerTipoCuenta.Size = new System.Drawing.Size(107, 23);
            this.botonVerTipoCuenta.TabIndex = 5;
            this.botonVerTipoCuenta.Text = "Ver Tipo de Cuenta";
            this.botonVerTipoCuenta.UseVisualStyleBackColor = true;
            this.botonVerTipoCuenta.Click += new System.EventHandler(this.botonVerTipoCuenta_Click);
            // 
            // botonVerTodo
            // 
            this.botonVerTodo.Location = new System.Drawing.Point(365, 172);
            this.botonVerTodo.Name = "botonVerTodo";
            this.botonVerTodo.Size = new System.Drawing.Size(136, 23);
            this.botonVerTodo.TabIndex = 6;
            this.botonVerTodo.Text = "Ver Todas las Cuentas";
            this.botonVerTodo.UseVisualStyleBackColor = true;
            this.botonVerTodo.Click += new System.EventHandler(this.botonVerTodo_Click);
            // 
            // botonCancelar
            // 
            this.botonCancelar.Location = new System.Drawing.Point(426, 211);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(75, 23);
            this.botonCancelar.TabIndex = 7;
            this.botonCancelar.Text = "Cancelar";
            this.botonCancelar.UseVisualStyleBackColor = true;
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // labelMesyAnio
            // 
            this.labelMesyAnio.AutoSize = true;
            this.labelMesyAnio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMesyAnio.Location = new System.Drawing.Point(17, 118);
            this.labelMesyAnio.Name = "labelMesyAnio";
            this.labelMesyAnio.Size = new System.Drawing.Size(169, 20);
            this.labelMesyAnio.TabIndex = 8;
            this.labelMesyAnio.Text = "Seleccione Mes y Año:";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(215, 120);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(47, 21);
            this.comboBox3.TabIndex = 9;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(294, 120);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(80, 21);
            this.comboBox4.TabIndex = 10;
            // 
            // LibroMayor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 308);
            this.Controls.Add(this.groupBoxLibroMayor);
            this.Name = "LibroMayor";
            this.Text = "LibroMayor";
            this.groupBoxLibroMayor.ResumeLayout(false);
            this.groupBoxLibroMayor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelTipoDeCuenta;
        private System.Windows.Forms.Label labelNombreDeCuenta;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.GroupBox groupBoxLibroMayor;
        private System.Windows.Forms.Button botonCancelar;
        private System.Windows.Forms.Button botonVerTodo;
        private System.Windows.Forms.Button botonVerTipoCuenta;
        private System.Windows.Forms.Button botonVerCuenta;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label labelMesyAnio;
    }
}