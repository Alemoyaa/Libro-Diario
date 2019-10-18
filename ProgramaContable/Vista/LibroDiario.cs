using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;


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
            if (cmbCuentas.Text.Length == 0 || (cmbCuentas.Text.Length != 0 && (txtHaber.Text.Length == 0 && txtDebe.Text.Length == 0))) //Si no se selecciona una cuenta o Se selecciona una cuenta pero los campos con valores estan vacion
            {
                MessageBox.Show("Complete los campos", "No registrado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtDebe.Text.Length == 0) //Si escribe en el Haber
            {
                try
                {
                    int enteroParseado;
                    if (Int32.TryParse(txtHaber.Text, out enteroParseado)) {

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
                    else
                    {
                        MessageBox.Show("Por favor ingrese un numero", "No registrado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch(Exception)
                {

                }
            }
            else if (txtHaber.Text.Length == 0) // Si escribe en el debe
            {
                try
                {
                    int enteroParseado;
                    if (Int32.TryParse(txtDebe.Text, out enteroParseado))
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
                    else
                    {
                        MessageBox.Show("Por favor ingrese un numero", "No registrado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception)
                {

                }
            }
            else if (txtHaber.Text.Length != 0 && txtDebe.Text.Length != 0)
            {
                MessageBox.Show("No se puede anotar en el debe y el haber al mismo tiempo", "No registrado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("No se pudo registrar vuelva a intentarlo", "No registrado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        /* Excel
         * 
         * private void ExportarDataGridViewExcel(DataGridView grd)
        {
            SaveFileDialog fichero = new SaveFileDialog();
            fichero.Filter = "Excel (*.xls)|*.xls";
            if (fichero.ShowDialog() == DialogResult.OK)
            {
                Microsoft.Office.Interop.Excel.Application aplicacion;
                Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
                Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;
                aplicacion = new Microsoft.Office.Interop.Excel.Application();
                libros_trabajo = aplicacion.Workbooks.Add();
                hoja_trabajo = (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);

                //Recorremos el DataGridView rellenando la hoja de trabajo, aca va guardan todas las filas y columnas
                for (int i = 0; i < grd.Rows.Count; i++)
                {
                    for (int j = 0; j < grd.Columns.Count; j++)
                    {
                        hoja_trabajo.Cells[i + 1, j + 1] = grd.Rows[i].Cells[j].Value;
                    }
                }

                libros_trabajo.SaveAs(fichero.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                libros_trabajo.Close(true);
                aplicacion.Quit();
            }
        }*/

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try {
                //ExportarDataGridViewExcel(dgvData); //Guarda el excel
                MessageBox.Show("Se pudo registrar de manera correcta", "Registrado");
                this.Hide();//Hacemos invisible el form de libro diario una vez dejamos de usarlo
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo registrar vuelva a intentarlo", "No registrado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
