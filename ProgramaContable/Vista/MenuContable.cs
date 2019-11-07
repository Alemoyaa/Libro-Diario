
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ProgramaContable.Controlador;
using ProgramaContable.Vista;

namespace ProgramaContable
{
    public partial class MenuContable : Form
    {
        public MenuContable()
        {
            InitializeComponent();
        }

        private void BotonLibroDiario_Click(object sender, EventArgs e)
        {

            ControladorLibroDiario controlador = new ControladorLibroDiario(this);
            this.Visible = false;
        }

        private void botonLibroMayor_Click(object sender, EventArgs e)
        {
            ControladorLibroMayor controlador = new ControladorLibroMayor(this);
            this.Visible = false;
        }
    }
}
