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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.BotonTodosMes = new System.Windows.Forms.Button();
            this.BotonFechaS = new System.Windows.Forms.Button();
            this.groupBoxAsientos = new System.Windows.Forms.GroupBox();
            this.botonVolver = new System.Windows.Forms.Button();
            this.botonAgregar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColNAsiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColVer = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBoxBusqueda.SuspendLayout();
            this.groupBoxAsientos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxBusqueda
            // 
            this.groupBoxBusqueda.Controls.Add(this.dateTimePicker1);
            this.groupBoxBusqueda.Controls.Add(this.BotonTodosMes);
            this.groupBoxBusqueda.Controls.Add(this.BotonFechaS);
            this.groupBoxBusqueda.Location = new System.Drawing.Point(13, 26);
            this.groupBoxBusqueda.Name = "groupBoxBusqueda";
            this.groupBoxBusqueda.Size = new System.Drawing.Size(750, 65);
            this.groupBoxBusqueda.TabIndex = 0;
            this.groupBoxBusqueda.TabStop = false;
            this.groupBoxBusqueda.Text = "Busqueda";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(56, 20);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // BotonTodosMes
            // 
            this.BotonTodosMes.Location = new System.Drawing.Point(592, 21);
            this.BotonTodosMes.Name = "BotonTodosMes";
            this.BotonTodosMes.Size = new System.Drawing.Size(115, 23);
            this.BotonTodosMes.TabIndex = 5;
            this.BotonTodosMes.Text = "Mostrar Todo el Mes";
            this.BotonTodosMes.UseVisualStyleBackColor = true;
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
            this.groupBoxAsientos.Controls.Add(this.dataGridView1);
            this.groupBoxAsientos.Location = new System.Drawing.Point(13, 98);
            this.groupBoxAsientos.Name = "groupBoxAsientos";
            this.groupBoxAsientos.Size = new System.Drawing.Size(750, 289);
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColNAsiento,
            this.ColFecha,
            this.ColDescripcion,
            this.ColVer});
            this.dataGridView1.Location = new System.Drawing.Point(17, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(713, 192);
            this.dataGridView1.TabIndex = 0;
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
            // ColVer
            // 
            this.ColVer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ColVer.HeaderText = "Ver";
            this.ColVer.Name = "ColVer";
            this.ColVer.ReadOnly = true;
            this.ColVer.Text = "Ver";
            this.ColVer.UseColumnTextForButtonValue = true;
            // 
            // LibroDiario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 400);
            this.Controls.Add(this.groupBoxAsientos);
            this.Controls.Add(this.groupBoxBusqueda);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "LibroDiario";
            this.Text = "Ver Libro Diario";
            this.groupBoxBusqueda.ResumeLayout(false);
            this.groupBoxAsientos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxBusqueda;
        private System.Windows.Forms.Button BotonFechaS;
        private System.Windows.Forms.Button BotonTodosMes;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBoxAsientos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.Button botonAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNAsiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDescripcion;
        private System.Windows.Forms.DataGridViewButtonColumn ColVer;
    }
}