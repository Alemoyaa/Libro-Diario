using ProgramaContable.Modelo;
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
    public partial class AgregarMovimiento : Form
    {
        public AgregarMovimiento()
        {
            InitializeComponent();
            CargadorDeDatos();
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            
            /*Boolean debeOHaber;
            if (radioButtonDebe.Checked)
            {
                debeOHaber = true;
            }else if (radioButtonHaber.Checked)
            {
                debeOHaber = false;
            }*/

        }

        private void CargadorDeDatos()
        {
            comboBoxTipo_load();
            comboBoxNombre_load();
            comboBoxTipo.SelectedIndex = 0;
            comboBoxNombre.SelectedIndex = 0;
        }

        private void comboBoxTipo_load()
        {
            List<TipodeCuenta> lista = TipodeCuenta.TraerTipos();
            foreach (TipodeCuenta i in lista)
            {
                this.comboBoxTipo.Items.Add(new ComboBoxItem(i.DescripcionTipo, i.Id));
            }
        }

        private void comboBoxNombre_load()
        {
            List<Cuenta> lista = Cuenta.ListarCuentas(1);
            foreach (Cuenta i in lista)
            {
                this.comboBoxNombre.Items.Add(new ComboBoxItem(i.NombreCuenta, i.IdCuenta));
            }
        }

        private void comboBoxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxNombre.Items.Clear();
            int hValue = ((ComboBoxItem)comboBoxTipo.SelectedItem).HiddenValue;
            List<Cuenta> lista = Cuenta.ListarCuentas(hValue);
            foreach (Cuenta i in lista)
            {
                this.comboBoxNombre.Items.Add(new ComboBoxItem(i.NombreCuenta, i.IdCuenta));
            }
            comboBoxNombre.SelectedIndex = 0;
        }
    }
}
