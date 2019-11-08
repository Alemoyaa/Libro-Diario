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
            menuAnterior = vista;
            InitializeComponent();
        }

        private void botonNuevo_Click(object sender, EventArgs e)
        {
            AgregarMovimiento nuevoMovi = new AgregarMovimiento();
            nuevoMovi.Visible = true;
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            menuAnterior.Visible = true;
            this.Dispose();
        }
    }
}
