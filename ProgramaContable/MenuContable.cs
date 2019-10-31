using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramaContable
{
    public partial class MenuContable : Form
    {
        public MenuContable()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            LibroDiario libroDiario = new LibroDiario();
            libroDiario.Visible = true;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            TotalActual totalCuenta = new TotalActual();
            totalCuenta.Visible = true;
        }
    }
}
