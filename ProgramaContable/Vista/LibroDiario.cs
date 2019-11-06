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
    public partial class LibroDiario : Form
    {
        private static ControladorLibroDiario controlador;
        public static ControladorLibroDiario Controlador { get => controlador; set => controlador = value; }

        public LibroDiario(ControladorLibroDiario control)
        {
            Controlador = control;
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

        private void BotonFechaS_Click(object sender, EventArgs e)
        {

        }
    }
}
