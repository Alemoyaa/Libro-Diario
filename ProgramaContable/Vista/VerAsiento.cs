using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramaContable.Vista
{
    public partial class VerAsiento : Form
    {
        private static Form menuAnterior;
        public VerAsiento(Form vista)
        {
            try { 
                menuAnterior = vista;
                InitializeComponent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void botonNuevo_Click(object sender, EventArgs e)
        {
            try { 
                AgregarMovimiento nuevoMovi = new AgregarMovimiento();
                nuevoMovi.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            try { 
                menuAnterior.Visible = true;
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
