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
    public partial class LibroMayor : Form
    {
        private static Form menuAnterior;
        public LibroMayor(Form menu)
        {
            menuAnterior = menu;
            InitializeComponent();
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            menuAnterior.Visible = true;
            this.Dispose();
        }

        private void botonVerCuenta_Click(object sender, EventArgs e)
        {
            VerLibroMayor verlibro = new VerLibroMayor();
            verlibro.Visible = true;
        }

        private void botonVerTipoCuenta_Click(object sender, EventArgs e)
        {
            VerLibroMayor verlibro = new VerLibroMayor();
            verlibro.Visible = true;
        }

        private void botonVerTodo_Click(object sender, EventArgs e)
        {
            VerLibroMayor verlibro = new VerLibroMayor();
            verlibro.Visible = true;
        }
    }
}
