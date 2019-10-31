
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ProgramaContable.Modelo;
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
            //List<Cuenta> lista = ListarCuentas(new TipodeCuenta(2,"Pasivo"));
            //foreach (var Cuenta in lista)
            //{
            //    Console.WriteLine("ID: " + Cuenta.IdCuenta + " Cuenta: " + Cuenta.NombreCuenta + " Tipo de Cuenta: " + Cuenta.Tipocuenta.DescripcionTipo);
            //}
            LibroDiario libroDiario = new LibroDiario(this);
            libroDiario.Visible = true;
            this.Visible = false;
        }

        private void botonLibroMayor_Click(object sender, EventArgs e)
        {
            LibroMayor libroMayor = new LibroMayor(this);
            libroMayor.Visible = true;
            this.Visible = false;
        }
    }
}
