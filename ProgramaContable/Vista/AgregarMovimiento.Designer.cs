namespace ProgramaContable.Vista
{
    partial class AgregarMovimiento
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
            this.groupBoxMovimiento = new System.Windows.Forms.GroupBox();
            this.botonCancelar = new System.Windows.Forms.Button();
            this.botonGuardar = new System.Windows.Forms.Button();
            this.radioButtonHaber = new System.Windows.Forms.RadioButton();
            this.radioButtonDebe = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBoxNombre = new System.Windows.Forms.ComboBox();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.labelSaldo = new System.Windows.Forms.Label();
            this.labelCuenta = new System.Windows.Forms.Label();
            this.labelTipo = new System.Windows.Forms.Label();
            this.groupBoxMovimiento.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxMovimiento
            // 
            this.groupBoxMovimiento.Controls.Add(this.botonCancelar);
            this.groupBoxMovimiento.Controls.Add(this.botonGuardar);
            this.groupBoxMovimiento.Controls.Add(this.radioButtonHaber);
            this.groupBoxMovimiento.Controls.Add(this.radioButtonDebe);
            this.groupBoxMovimiento.Controls.Add(this.textBox1);
            this.groupBoxMovimiento.Controls.Add(this.comboBoxNombre);
            this.groupBoxMovimiento.Controls.Add(this.comboBoxTipo);
            this.groupBoxMovimiento.Controls.Add(this.labelSaldo);
            this.groupBoxMovimiento.Controls.Add(this.labelCuenta);
            this.groupBoxMovimiento.Controls.Add(this.labelTipo);
            this.groupBoxMovimiento.Location = new System.Drawing.Point(27, 13);
            this.groupBoxMovimiento.Name = "groupBoxMovimiento";
            this.groupBoxMovimiento.Size = new System.Drawing.Size(357, 256);
            this.groupBoxMovimiento.TabIndex = 0;
            this.groupBoxMovimiento.TabStop = false;
            this.groupBoxMovimiento.Text = "Editar Movimiento";
            // 
            // botonCancelar
            // 
            this.botonCancelar.Location = new System.Drawing.Point(210, 205);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(75, 23);
            this.botonCancelar.TabIndex = 9;
            this.botonCancelar.Text = "Cancelar";
            this.botonCancelar.UseVisualStyleBackColor = true;
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // botonGuardar
            // 
            this.botonGuardar.Location = new System.Drawing.Point(107, 205);
            this.botonGuardar.Name = "botonGuardar";
            this.botonGuardar.Size = new System.Drawing.Size(75, 23);
            this.botonGuardar.TabIndex = 8;
            this.botonGuardar.Text = "Guardar";
            this.botonGuardar.UseVisualStyleBackColor = true;
            this.botonGuardar.Click += new System.EventHandler(this.botonGuardar_Click);
            // 
            // radioButtonHaber
            // 
            this.radioButtonHaber.AutoSize = true;
            this.radioButtonHaber.Location = new System.Drawing.Point(231, 165);
            this.radioButtonHaber.Name = "radioButtonHaber";
            this.radioButtonHaber.Size = new System.Drawing.Size(54, 17);
            this.radioButtonHaber.TabIndex = 7;
            this.radioButtonHaber.Text = "Haber";
            this.radioButtonHaber.UseVisualStyleBackColor = true;
            // 
            // radioButtonDebe
            // 
            this.radioButtonDebe.AutoSize = true;
            this.radioButtonDebe.Checked = true;
            this.radioButtonDebe.Location = new System.Drawing.Point(163, 165);
            this.radioButtonDebe.Name = "radioButtonDebe";
            this.radioButtonDebe.Size = new System.Drawing.Size(51, 17);
            this.radioButtonDebe.TabIndex = 6;
            this.radioButtonDebe.TabStop = true;
            this.radioButtonDebe.Text = "Debe";
            this.radioButtonDebe.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(164, 118);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 5;
            // 
            // comboBoxNombre
            // 
            this.comboBoxNombre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNombre.FormattingEnabled = true;
            this.comboBoxNombre.Location = new System.Drawing.Point(164, 80);
            this.comboBoxNombre.Name = "comboBoxNombre";
            this.comboBoxNombre.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNombre.TabIndex = 4;
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Location = new System.Drawing.Point(164, 37);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTipo.TabIndex = 3;
            this.comboBoxTipo.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipo_SelectedIndexChanged);
            // 
            // labelSaldo
            // 
            this.labelSaldo.AutoSize = true;
            this.labelSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSaldo.Location = new System.Drawing.Point(103, 118);
            this.labelSaldo.Name = "labelSaldo";
            this.labelSaldo.Size = new System.Drawing.Size(54, 20);
            this.labelSaldo.TabIndex = 2;
            this.labelSaldo.Text = "Saldo:";
            // 
            // labelCuenta
            // 
            this.labelCuenta.AutoSize = true;
            this.labelCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCuenta.Location = new System.Drawing.Point(92, 80);
            this.labelCuenta.Name = "labelCuenta";
            this.labelCuenta.Size = new System.Drawing.Size(65, 20);
            this.labelCuenta.TabIndex = 1;
            this.labelCuenta.Text = "Cuenta:";
            // 
            // labelTipo
            // 
            this.labelTipo.AutoSize = true;
            this.labelTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipo.Location = new System.Drawing.Point(36, 39);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Size = new System.Drawing.Size(121, 20);
            this.labelTipo.TabIndex = 0;
            this.labelTipo.Text = "Tipo de Cuenta:";
            // 
            // AgregarMovimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 307);
            this.Controls.Add(this.groupBoxMovimiento);
            this.Name = "AgregarMovimiento";
            this.Text = "VerMovimiento";
            this.groupBoxMovimiento.ResumeLayout(false);
            this.groupBoxMovimiento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxMovimiento;
        private System.Windows.Forms.Button botonCancelar;
        private System.Windows.Forms.Button botonGuardar;
        private System.Windows.Forms.RadioButton radioButtonHaber;
        private System.Windows.Forms.RadioButton radioButtonDebe;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBoxNombre;
        private System.Windows.Forms.ComboBox comboBoxTipo;
        private System.Windows.Forms.Label labelSaldo;
        private System.Windows.Forms.Label labelCuenta;
        private System.Windows.Forms.Label labelTipo;
    }
}