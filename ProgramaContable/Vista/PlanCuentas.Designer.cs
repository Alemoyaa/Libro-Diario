namespace ProgramaContable.Vista
{
    partial class PlanCuentas
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
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.Numero_Cuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Cuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_Cuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
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
            this.Numero_Cuenta,
            this.Nombre_Cuenta,
            this.Tipo_Cuenta});
            this.dgvData.Location = new System.Drawing.Point(11, 25);
            this.dgvData.Margin = new System.Windows.Forms.Padding(2);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowHeadersVisible = false;
            this.dgvData.RowTemplate.Height = 28;
            this.dgvData.Size = new System.Drawing.Size(656, 212);
            this.dgvData.TabIndex = 25;
            // 
            // Numero_Cuenta
            // 
            this.Numero_Cuenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Numero_Cuenta.HeaderText = "Numero de cuenta";
            this.Numero_Cuenta.Name = "Numero_Cuenta";
            // 
            // Nombre_Cuenta
            // 
            this.Nombre_Cuenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre_Cuenta.HeaderText = "Nombre de cuenta";
            this.Nombre_Cuenta.Name = "Nombre_Cuenta";
            // 
            // Tipo_Cuenta
            // 
            this.Tipo_Cuenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tipo_Cuenta.HeaderText = "Tipo de cuenta";
            this.Tipo_Cuenta.Name = "Tipo_Cuenta";
            // 
            // PlanCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 275);
            this.Controls.Add(this.dgvData);
            this.Name = "PlanCuentas";
            this.Text = "PlanCuentas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero_Cuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Cuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_Cuenta;
    }
}