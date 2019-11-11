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
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.comboBoxNombre = new System.Windows.Forms.ComboBox();
            this.groupBoxLibroMayor = new System.Windows.Forms.GroupBox();
            this.comboBoxAnio = new System.Windows.Forms.ComboBox();
            this.comboBoxMes = new System.Windows.Forms.ComboBox();
            this.labelMesyAnio = new System.Windows.Forms.Label();
            this.botonCancelar = new System.Windows.Forms.Button();
            this.botonVerTodo = new System.Windows.Forms.Button();
            this.botonVerTipoCuenta = new System.Windows.Forms.Button();
            this.botonVerCuenta = new System.Windows.Forms.Button();
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
            // comboBoxTipo
            // 
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Location = new System.Drawing.Point(294, 40);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(196, 21);
            this.comboBoxTipo.TabIndex = 2;
            this.comboBoxTipo.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipo_SelectedIndexChanged);
            // 
            // comboBoxNombre
            // 
            this.comboBoxNombre.FormattingEnabled = true;
            this.comboBoxNombre.Location = new System.Drawing.Point(294, 80);
            this.comboBoxNombre.Name = "comboBoxNombre";
            this.comboBoxNombre.Size = new System.Drawing.Size(196, 21);
            this.comboBoxNombre.TabIndex = 3;
            // 
            // groupBoxLibroMayor
            // 
            this.groupBoxLibroMayor.Controls.Add(this.comboBoxAnio);
            this.groupBoxLibroMayor.Controls.Add(this.comboBoxMes);
            this.groupBoxLibroMayor.Controls.Add(this.labelMesyAnio);
            this.groupBoxLibroMayor.Controls.Add(this.botonCancelar);
            this.groupBoxLibroMayor.Controls.Add(this.botonVerTodo);
            this.groupBoxLibroMayor.Controls.Add(this.botonVerTipoCuenta);
            this.groupBoxLibroMayor.Controls.Add(this.botonVerCuenta);
            this.groupBoxLibroMayor.Controls.Add(this.labelTipoDeCuenta);
            this.groupBoxLibroMayor.Controls.Add(this.comboBoxNombre);
            this.groupBoxLibroMayor.Controls.Add(this.comboBoxTipo);
            this.groupBoxLibroMayor.Controls.Add(this.labelNombreDeCuenta);
            this.groupBoxLibroMayor.Location = new System.Drawing.Point(23, 12);
            this.groupBoxLibroMayor.Name = "groupBoxLibroMayor";
            this.groupBoxLibroMayor.Size = new System.Drawing.Size(527, 274);
            this.groupBoxLibroMayor.TabIndex = 4;
            this.groupBoxLibroMayor.TabStop = false;
            this.groupBoxLibroMayor.Text = "Ver Libro Mayor";
            // 
            // comboBoxAnio
            // 
            this.comboBoxAnio.FormattingEnabled = true;
            this.comboBoxAnio.Items.AddRange(new object[] {
            "1990",
            "1991",
            "1992",
            "1993",
            "1994",
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019"});
            this.comboBoxAnio.Location = new System.Drawing.Point(294, 120);
            this.comboBoxAnio.Name = "comboBoxAnio";
            this.comboBoxAnio.Size = new System.Drawing.Size(80, 21);
            this.comboBoxAnio.TabIndex = 10;
            // 
            // comboBoxMes
            // 
            this.comboBoxMes.FormattingEnabled = true;
            this.comboBoxMes.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.comboBoxMes.Location = new System.Drawing.Point(215, 120);
            this.comboBoxMes.Name = "comboBoxMes";
            this.comboBoxMes.Size = new System.Drawing.Size(47, 21);
            this.comboBoxMes.TabIndex = 9;
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
            // botonCancelar
            // 
            this.botonCancelar.Location = new System.Drawing.Point(426, 211);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(75, 23);
            this.botonCancelar.TabIndex = 7;
            this.botonCancelar.Text = "Volver Menu";
            this.botonCancelar.UseVisualStyleBackColor = true;
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
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
            // LibroMayor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 308);
            this.Controls.Add(this.groupBoxLibroMayor);
            this.Name = "LibroMayor";
            this.Text = "LibroMayor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LibroMayor_FormClosing);
            this.Load += new System.EventHandler(this.LibroMayor_Load);
            this.groupBoxLibroMayor.ResumeLayout(false);
            this.groupBoxLibroMayor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelTipoDeCuenta;
        private System.Windows.Forms.Label labelNombreDeCuenta;
        private System.Windows.Forms.ComboBox comboBoxTipo;
        private System.Windows.Forms.ComboBox comboBoxNombre;
        private System.Windows.Forms.GroupBox groupBoxLibroMayor;
        private System.Windows.Forms.Button botonCancelar;
        private System.Windows.Forms.Button botonVerTodo;
        private System.Windows.Forms.Button botonVerTipoCuenta;
        private System.Windows.Forms.Button botonVerCuenta;
        private System.Windows.Forms.ComboBox comboBoxAnio;
        private System.Windows.Forms.ComboBox comboBoxMes;
        private System.Windows.Forms.Label labelMesyAnio;
    }
}