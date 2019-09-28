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
            LibroDiario l = new LibroDiario();
            l.Visible = true;
        }
    }
}
