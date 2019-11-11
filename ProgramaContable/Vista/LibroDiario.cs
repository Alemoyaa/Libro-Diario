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
        private Form vistaAnterior;

        public Form VistaAnterior { get => vistaAnterior; set => vistaAnterior = value; }

        public LibroDiario(Form vistaanterior)
        {
            VistaAnterior = vistaanterior;
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
            VistaAnterior.Visible = true;
            this.Dispose();
        }

        private void BotonFechaS_Click(object sender, EventArgs e)
        {

        }

        private void LibroDiario_FormClosing(object sender, FormClosingEventArgs e)
        {
            VistaAnterior.Visible = true;
            this.Dispose();
        }
    }
}
