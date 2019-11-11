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
            double saldoIngresado;
            Boolean debeOHaber;

            try
            {
                saldoIngresado = Convert.ToDouble(textBox1.Text); //Recupero el saldo del textBox
                debeOHaber = Convert.ToBoolean(radioButtonDebe.Checked); //Guardo en true si es debe, false si es haber
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese un saldo para registrar");
            }
           
        }

        private void CargadorDeDatos()
        {
            try
            {
                comboBoxTipo_load();
                comboBoxNombre_load();
                comboBoxTipo.SelectedIndex = 0;
                comboBoxNombre.SelectedIndex = 0;
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema. Vuelva a intentarlo mas tarde.");
                this.Close();
                Application.Exit();
            }
        }

        private void comboBoxTipo_load()
        {
            try
            {
                List<TipodeCuenta> lista = TipodeCuenta.TraerTipos();
                foreach (TipodeCuenta i in lista)
                {
                    this.comboBoxTipo.Items.Add(new ComboBoxItem(i.DescripcionTipo, i.Id));
                }
            }   catch (Exception)
            {
                MessageBox.Show("Error al cargar tipo de cuentas. Por favor vuelva a intentarlo mas tarde");
            }
        }

        private void comboBoxNombre_load()
        {
            try
            {
                List<Cuenta> lista = Cuenta.ListarCuentas(1);
                foreach (Cuenta i in lista)
                {
                    this.comboBoxNombre.Items.Add(new ComboBoxItem(i.NombreCuenta, i.IdCuenta));
                }
            }   catch (Exception)
            {
                MessageBox.Show("Error al cargar nombre de cuentas. Por favor vuelva a intentarlo mas tarde");
            }
        }

        private void comboBoxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
            comboBoxNombre.Items.Clear();
            int hValue = ((ComboBoxItem)comboBoxTipo.SelectedItem).HiddenValue;
            List<Cuenta> lista = Cuenta.ListarCuentas(hValue);
            foreach (Cuenta i in lista)
            {
                this.comboBoxNombre.Items.Add(new ComboBoxItem(i.NombreCuenta, i.IdCuenta));
            }
            comboBoxNombre.SelectedIndex = 0;
            }   catch (Exception)
            {
                MessageBox.Show("Error al cargar tipo de cuentas. Por favor vuelva a intentarlo mas tarde.");
            }
        }

        private void AgregarMovimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }
    }
}
