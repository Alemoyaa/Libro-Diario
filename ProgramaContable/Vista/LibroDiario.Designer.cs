using ProgramaContable.Modelo;
using System;
using System.Windows.Forms;

namespace ProgramaContable.Vista
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
            this.groupBoxBusqueda = new System.Windows.Forms.GroupBox();
            this.dateTimePickerFecha = new System.Windows.Forms.DateTimePicker();
            this.BotonTodosMes = new System.Windows.Forms.Button();
            this.BotonFechaS = new System.Windows.Forms.Button();
            this.groupBoxAsientos = new System.Windows.Forms.GroupBox();
            this.botonVolver = new System.Windows.Forms.Button();
            this.botonAgregar = new System.Windows.Forms.Button();
            this.dataGridAsientos = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNAsiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBoxBusqueda.SuspendLayout();
            this.groupBoxAsientos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAsientos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxBusqueda
            // 
            this.groupBoxBusqueda.Controls.Add(this.dateTimePickerFecha);
            this.groupBoxBusqueda.Controls.Add(this.BotonTodosMes);
            this.groupBoxBusqueda.Controls.Add(this.BotonFechaS);
            this.groupBoxBusqueda.Location = new System.Drawing.Point(13, 26);
            this.groupBoxBusqueda.Name = "groupBoxBusqueda";
            this.groupBoxBusqueda.Size = new System.Drawing.Size(776, 65);
            this.groupBoxBusqueda.TabIndex = 0;
            this.groupBoxBusqueda.TabStop = false;
            this.groupBoxBusqueda.Text = "Busqueda";
            // 
            // dateTimePickerFecha
            // 
            this.dateTimePickerFecha.Location = new System.Drawing.Point(56, 20);
            this.dateTimePickerFecha.Name = "dateTimePickerFecha";
            this.dateTimePickerFecha.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFecha.TabIndex = 6;
            // 
            // BotonTodosMes
            // 
            this.BotonTodosMes.Location = new System.Drawing.Point(592, 21);
            this.BotonTodosMes.Name = "BotonTodosMes";
            this.BotonTodosMes.Size = new System.Drawing.Size(115, 23);
            this.BotonTodosMes.TabIndex = 5;
            this.BotonTodosMes.Text = "Mostrar Todo el Mes";
            this.BotonTodosMes.UseVisualStyleBackColor = true;
            this.BotonTodosMes.Click += new System.EventHandler(this.BotonTodosMes_Click);
            // 
            // BotonFechaS
            // 
            this.BotonFechaS.Location = new System.Drawing.Point(478, 21);
            this.BotonFechaS.Name = "BotonFechaS";
            this.BotonFechaS.Size = new System.Drawing.Size(98, 23);
            this.BotonFechaS.TabIndex = 4;
            this.BotonFechaS.Text = "Mostrar Fecha";
            this.BotonFechaS.UseVisualStyleBackColor = true;
            this.BotonFechaS.Click += new System.EventHandler(this.BotonFechaS_Click);
            // 
            // groupBoxAsientos
            // 
            this.groupBoxAsientos.Controls.Add(this.botonVolver);
            this.groupBoxAsientos.Controls.Add(this.botonAgregar);
            this.groupBoxAsientos.Controls.Add(this.dataGridAsientos);
            this.groupBoxAsientos.Location = new System.Drawing.Point(13, 98);
            this.groupBoxAsientos.Name = "groupBoxAsientos";
            this.groupBoxAsientos.Size = new System.Drawing.Size(776, 289);
            this.groupBoxAsientos.TabIndex = 1;
            this.groupBoxAsientos.TabStop = false;
            this.groupBoxAsientos.Text = "Asientos Contables";
            // 
            // botonVolver
            // 
            this.botonVolver.Location = new System.Drawing.Point(620, 243);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(87, 23);
            this.botonVolver.TabIndex = 2;
            this.botonVolver.Text = "Volver al Menu";
            this.botonVolver.UseVisualStyleBackColor = true;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
            // 
            // botonAgregar
            // 
            this.botonAgregar.Location = new System.Drawing.Point(525, 243);
            this.botonAgregar.Name = "botonAgregar";
            this.botonAgregar.Size = new System.Drawing.Size(75, 23);
            this.botonAgregar.TabIndex = 1;
            this.botonAgregar.Text = "Agregar Nuevo";
            this.botonAgregar.UseVisualStyleBackColor = true;
            this.botonAgregar.Click += new System.EventHandler(this.botonAgregar_Click);
            // 
            // dataGridAsientos
            // 
            this.dataGridAsientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAsientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ColNAsiento,
            this.ColFecha,
            this.ColDescripcion,
            this.ColEditar,
            this.ColEliminar});
            this.dataGridAsientos.Location = new System.Drawing.Point(17, 19);
            this.dataGridAsientos.Name = "dataGridAsientos";
            this.dataGridAsientos.Size = new System.Drawing.Size(743, 192);
            this.dataGridAsientos.TabIndex = 0;
            this.dataGridAsientos.CellClick += eventosClick;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // ColNAsiento
            // 
            this.ColNAsiento.FillWeight = 60F;
            this.ColNAsiento.HeaderText = "N°Asiento";
            this.ColNAsiento.Name = "ColNAsiento";
            this.ColNAsiento.ReadOnly = true;
            this.ColNAsiento.Width = 60;
            // 
            // ColFecha
            // 
            this.ColFecha.HeaderText = "Fecha";
            this.ColFecha.Name = "ColFecha";
            this.ColFecha.ReadOnly = true;
            // 
            // ColDescripcion
            // 
            this.ColDescripcion.FillWeight = 400F;
            this.ColDescripcion.HeaderText = "Descripción";
            this.ColDescripcion.Name = "ColDescripcion";
            this.ColDescripcion.ReadOnly = true;
            this.ColDescripcion.Width = 400;
            // 
            // ColEditar
            // 
            this.ColEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ColEditar.HeaderText = "Editar";
            this.ColEditar.Name = "ColEditar";
            this.ColEditar.ReadOnly = true;
            this.ColEditar.Text = "Editar";
            this.ColEditar.UseColumnTextForButtonValue = true;
            this.ColEditar.Width = 70;
            // 
            // ColEliminar
            // 
            this.ColEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ColEliminar.HeaderText = "Eliminar";
            this.ColEliminar.Name = "ColEliminar";
            this.ColEliminar.ReadOnly = true;
            this.ColEliminar.Text = "Eliminar";
            this.ColEliminar.UseColumnTextForButtonValue = true;
            this.ColEliminar.Width = 70;
            // 
            // LibroDiario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 400);
            this.Controls.Add(this.groupBoxAsientos);
            this.Controls.Add(this.groupBoxBusqueda);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "LibroDiario";
            this.Text = "Ver Libro Diario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LibroDiario_FormClosing);
            this.Load += new System.EventHandler(this.LibroDiario_Load);
            this.groupBoxBusqueda.ResumeLayout(false);
            this.groupBoxAsientos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAsientos)).EndInit();
            this.ResumeLayout(false);

        }

        private void eventosClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridAsientos.Columns["ColEditar"].Index)
            {
                int idasiento = int.Parse(dataGridAsientos.Rows[e.RowIndex].Cells[0].Value.ToString());
                VerAsiento vistaAgregar = new VerAsiento(true, idasiento, this);
                vistaAgregar.Visible = true;
                this.Visible = false;
            }
            else if (e.ColumnIndex == dataGridAsientos.Columns["ColEliminar"].Index)
            {
                int idasiento = int.Parse(dataGridAsientos.Rows[e.RowIndex].Cells[0].Value.ToString());
                VerAsiento vistaAgregar = new VerAsiento(false, idasiento, this);
                vistaAgregar.Visible = true;
                this.Visible = false;
            }
        }



        #endregion

        private System.Windows.Forms.GroupBox groupBoxBusqueda;
        private System.Windows.Forms.Button BotonFechaS;
        private System.Windows.Forms.Button BotonTodosMes;
        private System.Windows.Forms.DateTimePicker dateTimePickerFecha;
        private System.Windows.Forms.GroupBox groupBoxAsientos;
        private System.Windows.Forms.DataGridView dataGridAsientos;
        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.Button botonAgregar;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn ColNAsiento;
        private DataGridViewTextBoxColumn ColFecha;
        private DataGridViewTextBoxColumn ColDescripcion;
        private DataGridViewButtonColumn ColEditar;
        private DataGridViewButtonColumn ColEliminar;
    }
}