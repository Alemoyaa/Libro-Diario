
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            LibroDiario vistaLB = new LibroDiario(this);
            vistaLB.Visible = true;
            this.Visible = false;
        }

        private void botonLibroMayor_Click(object sender, EventArgs e)
        {
            LibroMayor vistaLM = new LibroMayor(this);
            vistaLM.Visible = true;
            this.Visible = false;
        }
    }
}
