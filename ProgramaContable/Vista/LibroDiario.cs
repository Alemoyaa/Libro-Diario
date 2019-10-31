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
    public partial class LibroDiario : Form
    {
        private static Form menuAnterior;
        public LibroDiario(Form vista)
        {
            menuAnterior = vista;
            InitializeComponent();
        }

        private void botonAgregar_Click(object sender, EventArgs e)
        {
            VerAsiento vistaAgregar = new VerAsiento(this);
            vistaAgregar.Visible = true;
            this.Visible = false;
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            menuAnterior.Visible = true;
            this.Dispose();
        }
    }
}
