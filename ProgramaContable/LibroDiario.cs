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
            ;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (cmbCuentas.Text.Length == 0 || (cmbCuentas.Text.Length != 0 && (txtHaber.Text.Length == 0 && txtDebe.Text.Length == 0))) //Si no se selecciona una cuenta
            {
                MessageBox.Show("Complete los campos", "No registrado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtDebe.Text.Length == 0) //Si escribe en el debe
            {
                //Adicionamos nuevo renglon
                int n = dgvData.Rows.Add();

                //Colocamos la informacion 
                dgvData.Rows[n].Cells[0].Value = dgvData.Rows.Count; //Contador de filas
                dgvData.Rows[n].Cells[1].Value = dateTimePicker1.Text;
                dgvData.Rows[n].Cells[2].Value = cmbCuentas.Text;
                dgvData.Rows[n].Cells[4].Value = txtHaber.Text;

                //Limpiamos los txt
                cmbCuentas.Text = "";
                txtDebe.Text = "";
                txtHaber.Text = "";
            }
            else if (txtHaber.Text.Length == 0)
            {
                //Adicionamos nuevo renglon
                int n = dgvData.Rows.Add();

                //Colocamos la informacion 
                dgvData.Rows[n].Cells[0].Value = dgvData.Rows.Count;
                dgvData.Rows[n].Cells[1].Value = dateTimePicker1.Text;
                dgvData.Rows[n].Cells[2].Value = cmbCuentas.Text;
                dgvData.Rows[n].Cells[3].Value = txtDebe.Text;

                //Limpiamos los txt
                cmbCuentas.Text = "";
                txtDebe.Text = "";
                txtHaber.Text = "";
            }
            else if (txtHaber.Text.Length != 0 && txtDebe.Text.Length != 0)
            {
                MessageBox.Show("No se puede anotar en el debe y el haber al mismo tiempo", "No registrado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
