namespace ProgramaContable.Vista
{
    partial class VerAsiento
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
            this.groupBoxAsiento = new System.Windows.Forms.GroupBox();
            this.botonCancelar = new System.Windows.Forms.Button();
            this.botonGuardar = new System.Windows.Forms.Button();
            this.botonNuevo = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSaldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelDesc = new System.Windows.Forms.Label();
            this.labelNumero = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.groupBoxAsiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxAsiento
            // 
            this.groupBoxAsiento.Controls.Add(this.botonCancelar);
            this.groupBoxAsiento.Controls.Add(this.botonGuardar);
            this.groupBoxAsiento.Controls.Add(this.botonNuevo);
            this.groupBoxAsiento.Controls.Add(this.dataGridView1);
            this.groupBoxAsiento.Controls.Add(this.textBox2);
            this.groupBoxAsiento.Controls.Add(this.textBox1);
            this.groupBoxAsiento.Controls.Add(this.dateTimePicker1);
            this.groupBoxAsiento.Controls.Add(this.labelDesc);
            this.groupBoxAsiento.Controls.Add(this.labelNumero);
            this.groupBoxAsiento.Controls.Add(this.labelFecha);
            this.groupBoxAsiento.Location = new System.Drawing.Point(23, 23);
            this.groupBoxAsiento.Name = "groupBoxAsiento";
            this.groupBoxAsiento.Size = new System.Drawing.Size(737, 394);
            this.groupBoxAsiento.TabIndex = 0;
            this.groupBoxAsiento.TabStop = false;
            this.groupBoxAsiento.Text = "Editar Asiento";
            // 
            // botonCancelar
            // 
            this.botonCancelar.Location = new System.Drawing.Point(614, 317);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(75, 23);
            this.botonCancelar.TabIndex = 9;
            this.botonCancelar.Text = "Cancelar";
            this.botonCancelar.UseVisualStyleBackColor = true;
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // botonGuardar
            // 
            this.botonGuardar.Location = new System.Drawing.Point(521, 317);
            this.botonGuardar.Name = "botonGuardar";
            this.botonGuardar.Size = new System.Drawing.Size(75, 23);
            this.botonGuardar.TabIndex = 8;
            this.botonGuardar.Text = "Guardar";
            this.botonGuardar.UseVisualStyleBackColor = true;
            // 
            // botonNuevo
            // 
            this.botonNuevo.Location = new System.Drawing.Point(423, 317);
            this.botonNuevo.Name = "botonNuevo";
            this.botonNuevo.Size = new System.Drawing.Size(75, 23);
            this.botonNuevo.TabIndex = 7;
            this.botonNuevo.Text = "Nuevo";
            this.botonNuevo.UseVisualStyleBackColor = true;
            this.botonNuevo.Click += new System.EventHandler(this.botonNuevo_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColNombre,
            this.colTipoCuenta,
            this.ColValor,
            this.ColSaldo});
            this.dataGridView1.Location = new System.Drawing.Point(46, 147);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 150);
            this.dataGridView1.TabIndex = 6;
            // 
            // ColNombre
            // 
            this.ColNombre.FillWeight = 250F;
            this.ColNombre.HeaderText = "Nombre Cuenta";
            this.ColNombre.Name = "ColNombre";
            this.ColNombre.ReadOnly = true;
            this.ColNombre.Width = 250;
            // 
            // colTipoCuenta
            // 
            this.colTipoCuenta.FillWeight = 150F;
            this.colTipoCuenta.HeaderText = "Tipo de Cuenta";
            this.colTipoCuenta.Name = "colTipoCuenta";
            this.colTipoCuenta.ReadOnly = true;
            this.colTipoCuenta.Width = 150;
            // 
            // ColValor
            // 
            this.ColValor.HeaderText = "Valor";
            this.ColValor.Name = "ColValor";
            this.ColValor.ReadOnly = true;
            // 
            // ColSaldo
            // 
            this.ColSaldo.HeaderText = "Saldo";
            this.ColSaldo.Name = "ColSaldo";
            this.ColSaldo.ReadOnly = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(206, 74);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(483, 46);
            this.textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(206, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(59, 20);
            this.textBox1.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(489, 35);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // labelDesc
            // 
            this.labelDesc.AutoSize = true;
            this.labelDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDesc.Location = new System.Drawing.Point(21, 74);
            this.labelDesc.Name = "labelDesc";
            this.labelDesc.Size = new System.Drawing.Size(179, 20);
            this.labelDesc.TabIndex = 2;
            this.labelDesc.Text = "Descripción del Asiento:";
            // 
            // labelNumero
            // 
            this.labelNumero.AutoSize = true;
            this.labelNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumero.Location = new System.Drawing.Point(21, 35);
            this.labelNumero.Name = "labelNumero";
            this.labelNumero.Size = new System.Drawing.Size(149, 20);
            this.labelNumero.TabIndex = 1;
            this.labelNumero.Text = "Número de Asiento:";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.Location = new System.Drawing.Point(318, 33);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(139, 20);
            this.labelFecha.TabIndex = 0;
            this.labelFecha.Text = "Fecha del asiento:";
            // 
            // VerAsiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 450);
            this.Controls.Add(this.groupBoxAsiento);
            this.Name = "VerAsiento";
            this.Text = "VerAsiento";
            this.groupBoxAsiento.ResumeLayout(false);
            this.groupBoxAsiento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAsiento;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelDesc;
        private System.Windows.Forms.Label labelNumero;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Button botonCancelar;
        private System.Windows.Forms.Button botonGuardar;
        private System.Windows.Forms.Button botonNuevo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSaldo;
    }
}