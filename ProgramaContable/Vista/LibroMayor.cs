using ProgramaContable.Controlador;
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
        private static ControladorLibroMayor controlador;
        public static ControladorLibroMayor Controlador { get => controlador; set => controlador = value; }

        public LibroMayor(ControladorLibroMayor control)
        {
            Controlador = control;
            InitializeComponent();
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            controlador.Volver();
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
