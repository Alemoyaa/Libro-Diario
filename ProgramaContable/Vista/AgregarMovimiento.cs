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
        private Movimiento movimientoactual;
        private Asiento asientoactual;
        private int opciones;

        public AgregarMovimiento(int op, Asiento asi, Movimiento mov)
        {
            InitializeComponent();
            CargadorDeDatos();
            movimientoactual = mov;
            asientoactual = asi;
            opciones = op;
            if (op == 1)
            {
                groupBoxMovimiento.Text = "Crear Movimiento";
                this.Text = "Crear Movimiento";
            }
            else if(op == 2){
                groupBoxMovimiento.Text = "Editar Movimiento";
                this.Text = "Editar Movimiento";
                ComboBoxItem com = new ComboBoxItem(mov.Cuenta.Tipocuenta.DescripcionTipo, mov.Cuenta.Tipocuenta.Id);
                comboBoxTipo.SelectedItem = com;
                ComboBoxItem com2 = new ComboBoxItem(mov.Cuenta.NombreCuenta, mov.Cuenta.IdCuenta);
                comboBoxNombre.SelectedItem = com2;
                textBox1.Text = mov.Valor.ToString();
                if (!mov.Debe_haber)
                {
                    radioButtonHaber.Select();
                }
            }
            else
            {
                groupBoxMovimiento.Text = "Eliminar Movimiento";
                this.Text = "Eliminar Movimiento";
                ComboBoxItem com = new ComboBoxItem(mov.Cuenta.Tipocuenta.DescripcionTipo, mov.Cuenta.Tipocuenta.Id);
                comboBoxTipo.SelectedItem = com;
                ComboBoxItem com2 = new ComboBoxItem(mov.Cuenta.NombreCuenta, mov.Cuenta.IdCuenta);
                comboBoxNombre.SelectedItem = com2;
                textBox1.Text = mov.Valor.ToString();
                if (!mov.Debe_haber)
                {
                    radioButtonHaber.Select();
                }
            }
            
          
            
            
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            if (opciones == 1)
            {
                DialogResult result = MessageBox.Show("¿Desea agregar el movimiento?", "Crear Movimiento", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.OK)
                {
                    try
                    {
                        movimientoactual.Valor = float.Parse(textBox1.Text); //Recupero el saldo del textBox
                        movimientoactual.Debe_haber = Convert.ToBoolean(radioButtonDebe.Checked); //Guardo en true si es debe, false si es haber
                        movimientoactual.Cuenta = new Cuenta();
                        movimientoactual.Cuenta.IdCuenta = ((ComboBoxItem)comboBoxNombre.SelectedItem).HiddenValue;
                        movimientoactual.Cuenta.NombreCuenta = comboBoxNombre.SelectedItem.ToString();
                        movimientoactual.Cuenta.Tipocuenta = new TipodeCuenta();
                        movimientoactual.Cuenta.Tipocuenta.Id = ((ComboBoxItem)comboBoxTipo.SelectedItem).HiddenValue;
                        movimientoactual.Cuenta.Tipocuenta.DescripcionTipo = comboBoxTipo.SelectedItem.ToString();
                        asientoactual.Asiento_movimiento.Add(movimientoactual);

                        this.Visible = false;

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Los datos son incorrectos");
                    }
                }
            }
            else if (opciones == 2)
            {
                DialogResult result = MessageBox.Show("¿Desea guardar los cambios realizados?", "Guardar Cambios", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.OK)
                {
                    Movimiento mov2 = asientoactual.Asiento_movimiento.Find(x => x.Id.Equals(movimientoactual.Id));
                    mov2.Valor = float.Parse(textBox1.Text); //Recupero el saldo del textBox
                    mov2.Debe_haber = Convert.ToBoolean(radioButtonDebe.Checked); //Guardo en true si es debe, false si es haber
                    mov2.Cuenta = new Cuenta();
                    mov2.Cuenta.IdCuenta = ((ComboBoxItem)comboBoxNombre.SelectedItem).HiddenValue;
                    mov2.Cuenta.Tipocuenta = new TipodeCuenta();
                    mov2.Cuenta.Tipocuenta.Id = ((ComboBoxItem)comboBoxTipo.SelectedItem).HiddenValue;
                    Movimiento.UpdateMovimiento(mov2);
                    this.Dispose();
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("¿Esta seguro de eliminar el movimiento?", "Eliminar Movimiento", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.OK)
                {
                    Movimiento.EliminarMovimiento(movimientoactual.Id);
                    asientoactual.Asiento_movimiento.Remove(movimientoactual);
                }
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
