using ProgramaContable.Modelo;
using System.Windows.Forms;

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
            this.dataGridMovimientos = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTipoCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSaldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.textBoxDescr = new System.Windows.Forms.TextBox();
            this.textBoxNumero = new System.Windows.Forms.TextBox();
            this.dateTimePickerFecha = new System.Windows.Forms.DateTimePicker();
            this.labelDesc = new System.Windows.Forms.Label();
            this.labelNumero = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.botonRefrescar = new System.Windows.Forms.Button();
            this.groupBoxAsiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMovimientos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxAsiento
            // 
            this.groupBoxAsiento.Controls.Add(this.botonRefrescar);
            this.groupBoxAsiento.Controls.Add(this.botonCancelar);
            this.groupBoxAsiento.Controls.Add(this.botonGuardar);
            this.groupBoxAsiento.Controls.Add(this.botonNuevo);
            this.groupBoxAsiento.Controls.Add(this.dataGridMovimientos);
            this.groupBoxAsiento.Controls.Add(this.textBoxDescr);
            this.groupBoxAsiento.Controls.Add(this.textBoxNumero);
            this.groupBoxAsiento.Controls.Add(this.dateTimePickerFecha);
            this.groupBoxAsiento.Controls.Add(this.labelDesc);
            this.groupBoxAsiento.Controls.Add(this.labelNumero);
            this.groupBoxAsiento.Controls.Add(this.labelFecha);
            this.groupBoxAsiento.Location = new System.Drawing.Point(23, 23);
            this.groupBoxAsiento.Name = "groupBoxAsiento";
            this.groupBoxAsiento.Size = new System.Drawing.Size(749, 394);
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
            this.botonGuardar.Click += new System.EventHandler(this.botonGuardar_Click);
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
            // dataGridMovimientos
            // 
            this.dataGridMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMovimientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ColNombre,
            this.ColTipoCuenta,
            this.ColValor,
            this.ColSaldo,
            this.ColEditar,
            this.ColEliminar});
            this.dataGridMovimientos.Location = new System.Drawing.Point(25, 147);
            this.dataGridMovimientos.Name = "dataGridMovimientos";
            this.dataGridMovimientos.Size = new System.Drawing.Size(718, 150);
            this.dataGridMovimientos.TabIndex = 6;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // ColNombre
            // 
            this.ColNombre.FillWeight = 200F;
            this.ColNombre.HeaderText = "Nombre Cuenta";
            this.ColNombre.Name = "ColNombre";
            this.ColNombre.ReadOnly = true;
            this.ColNombre.Width = 200;
            // 
            // ColTipoCuenta
            // 
            this.ColTipoCuenta.FillWeight = 130F;
            this.ColTipoCuenta.HeaderText = "Tipo de Cuenta";
            this.ColTipoCuenta.Name = "ColTipoCuenta";
            this.ColTipoCuenta.ReadOnly = true;
            this.ColTipoCuenta.Width = 130;
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
            // ColEditar
            // 
            this.ColEditar.HeaderText = "Editar";
            this.ColEditar.Name = "ColEditar";
            this.ColEditar.UseColumnTextForButtonValue = true;
            this.ColEditar.Width = 70;
            // 
            // ColEliminar
            // 
            this.ColEliminar.HeaderText = "Eliminar";
            this.ColEliminar.Name = "ColEliminar";
            this.ColEliminar.UseColumnTextForButtonValue = true;
            this.ColEliminar.Width = 70;
            // 
            // textBoxDescr
            // 
            this.textBoxDescr.Location = new System.Drawing.Point(206, 74);
            this.textBoxDescr.Multiline = true;
            this.textBoxDescr.Name = "textBoxDescr";
            this.textBoxDescr.Size = new System.Drawing.Size(483, 46);
            this.textBoxDescr.TabIndex = 5;
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.Location = new System.Drawing.Point(206, 35);
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(59, 20);
            this.textBoxNumero.TabIndex = 4;
            // 
            // dateTimePickerFecha
            // 
            this.dateTimePickerFecha.Location = new System.Drawing.Point(489, 35);
            this.dateTimePickerFecha.Name = "dateTimePickerFecha";
            this.dateTimePickerFecha.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFecha.TabIndex = 3;
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
            // botonRefrescar
            // 
            this.botonRefrescar.Location = new System.Drawing.Point(25, 316);
            this.botonRefrescar.Name = "botonRefrescar";
            this.botonRefrescar.Size = new System.Drawing.Size(75, 23);
            this.botonRefrescar.TabIndex = 10;
            this.botonRefrescar.Text = "Refrescar";
            this.botonRefrescar.UseVisualStyleBackColor = true;
            this.botonRefrescar.Click += new System.EventHandler(this.botonRefrescar_Click);
            // 
            // VerAsiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 450);
            this.Controls.Add(this.groupBoxAsiento);
            this.Name = "VerAsiento";
            this.Text = "VerAsiento";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VerAsiento_FormClosing);
            this.groupBoxAsiento.ResumeLayout(false);
            this.groupBoxAsiento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMovimientos)).EndInit();
            this.ResumeLayout(false);

        }
        private void eventosClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridMovimientos.Columns["ColEditar"].Index)
            {
                int idmovimiento = int.Parse(dataGridMovimientos.Rows[e.RowIndex].Cells[0].Value.ToString());
                Movimiento mov = Movimiento.TraerMovimientosporId(idmovimiento);
                AgregarMovimiento nuevoMovi = new AgregarMovimiento(2, asiento, mov);
                nuevoMovi.Visible = true;
              
            }
            else if (e.ColumnIndex == dataGridMovimientos.Columns["ColEliminar"].Index)
            {
                int idmovimiento = int.Parse(dataGridMovimientos.Rows[e.RowIndex].Cells[0].Value.ToString());
                Movimiento mov = Movimiento.TraerMovimientosporId(idmovimiento);
                AgregarMovimiento nuevoMovi = new AgregarMovimiento(3, asiento, mov);
                nuevoMovi.Visible = true;
            }
        }



        #endregion

        private System.Windows.Forms.GroupBox groupBoxAsiento;
        private System.Windows.Forms.TextBox textBoxDescr;
        private System.Windows.Forms.TextBox textBoxNumero;
        private System.Windows.Forms.DateTimePicker dateTimePickerFecha;
        private System.Windows.Forms.Label labelDesc;
        private System.Windows.Forms.Label labelNumero;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Button botonCancelar;
        private System.Windows.Forms.Button botonGuardar;
        private System.Windows.Forms.Button botonNuevo;
        private System.Windows.Forms.DataGridView dataGridMovimientos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTipoCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSaldo;
        private System.Windows.Forms.DataGridViewButtonColumn ColEditar;
        private System.Windows.Forms.DataGridViewButtonColumn ColEliminar;
        private Button botonRefrescar;
    }
}