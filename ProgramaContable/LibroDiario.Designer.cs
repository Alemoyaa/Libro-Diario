namespace ProgramaContable
{
    partial class LibroDiario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotalAbono = new System.Windows.Forms.TextBox();
            this.txtTotalCargo = new System.Windows.Forms.TextBox();
            this.gpboxAgregar = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmbCuentas = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.txtAbono = new System.Windows.Forms.TextBox();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAbono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpboxAgregar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(481, 303);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Haber Total";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(484, 277);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Debe Total";
            // 
            // txtTotalAbono
            // 
            this.txtTotalAbono.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalAbono.Location = new System.Drawing.Point(573, 301);
            this.txtTotalAbono.Margin = new System.Windows.Forms.Padding(1, 2, 2, 2);
            this.txtTotalAbono.Name = "txtTotalAbono";
            this.txtTotalAbono.Size = new System.Drawing.Size(167, 20);
            this.txtTotalAbono.TabIndex = 27;
            // 
            // txtTotalCargo
            // 
            this.txtTotalCargo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalCargo.Location = new System.Drawing.Point(574, 275);
            this.txtTotalCargo.Margin = new System.Windows.Forms.Padding(2, 2, 1, 2);
            this.txtTotalCargo.Name = "txtTotalCargo";
            this.txtTotalCargo.Size = new System.Drawing.Size(167, 20);
            this.txtTotalCargo.TabIndex = 26;
            // 
            // gpboxAgregar
            // 
            this.gpboxAgregar.Controls.Add(this.dateTimePicker1);
            this.gpboxAgregar.Controls.Add(this.cmbCuentas);
            this.gpboxAgregar.Controls.Add(this.btnAgregar);
            this.gpboxAgregar.Controls.Add(this.txtCargo);
            this.gpboxAgregar.Controls.Add(this.txtAbono);
            this.gpboxAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpboxAgregar.Location = new System.Drawing.Point(9, 25);
            this.gpboxAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.gpboxAgregar.Name = "gpboxAgregar";
            this.gpboxAgregar.Padding = new System.Windows.Forms.Padding(2);
            this.gpboxAgregar.Size = new System.Drawing.Size(729, 57);
            this.gpboxAgregar.TabIndex = 25;
            this.gpboxAgregar.TabStop = false;
            this.gpboxAgregar.Text = "Agregar nuevo movimiento";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(5, 24);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(125, 23);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // cmbCuentas
            // 
            this.cmbCuentas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCuentas.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCuentas.FormattingEnabled = true;
            this.cmbCuentas.Items.AddRange(new object[] {
            "Caja Y Banco"});
            this.cmbCuentas.Location = new System.Drawing.Point(135, 23);
            this.cmbCuentas.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCuentas.Name = "cmbCuentas";
            this.cmbCuentas.Size = new System.Drawing.Size(243, 24);
            this.cmbCuentas.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.AutoSize = true;
            this.btnAgregar.BackColor = System.Drawing.Color.Navy;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(622, 19);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(103, 29);
            this.btnAgregar.TabIndex = 14;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(382, 24);
            this.txtCargo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(116, 23);
            this.txtCargo.TabIndex = 1;
            this.txtCargo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtAbono
            // 
            this.txtAbono.Location = new System.Drawing.Point(502, 24);
            this.txtAbono.Margin = new System.Windows.Forms.Padding(2);
            this.txtAbono.Name = "txtAbono";
            this.txtAbono.Size = new System.Drawing.Size(116, 23);
            this.txtAbono.TabIndex = 2;
            this.txtAbono.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvData.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.colCuenta,
            this.colCargo,
            this.colAbono});
            this.dgvData.Location = new System.Drawing.Point(9, 97);
            this.dgvData.Margin = new System.Windows.Forms.Padding(2);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowHeadersVisible = false;
            this.dgvData.RowTemplate.Height = 28;
            this.dgvData.Size = new System.Drawing.Size(730, 174);
            this.dgvData.TabIndex = 24;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.AutoSize = true;
            this.btnAceptar.BackColor = System.Drawing.Color.Navy;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(574, 333);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(76, 30);
            this.btnAceptar.TabIndex = 23;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.BackColor = System.Drawing.Color.Navy;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(655, 333);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(84, 30);
            this.btnCancelar.TabIndex = 22;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            // 
            // colCuenta
            // 
            this.colCuenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCuenta.HeaderText = "Cuenta";
            this.colCuenta.Name = "colCuenta";
            // 
            // colCargo
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle1.Format = "C2";
            this.colCargo.DefaultCellStyle = dataGridViewCellStyle1;
            this.colCargo.HeaderText = "Debe";
            this.colCargo.Name = "colCargo";
            this.colCargo.Width = 200;
            // 
            // colAbono
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle2.Format = "C2";
            this.colAbono.DefaultCellStyle = dataGridViewCellStyle2;
            this.colAbono.HeaderText = "Haber";
            this.colAbono.Name = "colAbono";
            this.colAbono.Width = 200;
            // 
            // LibroDiario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 389);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTotalAbono);
            this.Controls.Add(this.txtTotalCargo);
            this.Controls.Add(this.gpboxAgregar);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Name = "LibroDiario";
            this.Text = "LibroDiario";
            this.gpboxAgregar.ResumeLayout(false);
            this.gpboxAgregar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotalAbono;
        private System.Windows.Forms.TextBox txtTotalCargo;
        private System.Windows.Forms.GroupBox gpboxAgregar;
        private System.Windows.Forms.ComboBox cmbCuentas;
        public System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.TextBox txtAbono;
        private System.Windows.Forms.DataGridView dgvData;
        public System.Windows.Forms.Button btnAceptar;
        public System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAbono;
    }
}