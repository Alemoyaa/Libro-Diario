using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramaContable
{
    public partial class LibroDiario : Form
    {
        public LibroDiario()
        {
            InitializeComponent();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            //Adicionamos nuevo renglon
            int n = dgvData.Rows.Add();

            //Colocamos la informacion 
            dgvData.Rows[n].Cells[0].Value = dateTimePicker1.Text;
            dgvData.Rows[n].Cells[1].Value = cmbCuentas.Text;
            dgvData.Rows[n].Cells[2].Value = txtCargo.Text;
            dgvData.Rows[n].Cells[3].Value = txtAbono.Text;

            //Limpiamos los txt

            cmbCuentas.Text = "";
            txtCargo.Text = "";
            txtAbono.Text = "";
        }
    }
}
