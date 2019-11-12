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
    public partial class VerAsiento : Form
    {
        private static Form menuAnterior;
        private int opcionesGuardar;
        public Asiento asiento;
        public VerAsiento(Form vista)
        {
            try { 
                menuAnterior = vista;
                opcionesGuardar = 1;
                asiento = new Asiento();
                asiento.Asiento_movimiento = new List<Movimiento>();
                InitializeComponent();
                groupBoxAsiento.Text = "Crear Asiento";
                this.Text = "Crear Asiento";
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public VerAsiento(Boolean opcion, int idasiento, Form vista){
            try
            {
                menuAnterior = vista;
                
                InitializeComponent();
                if (opcion)
                {
                    opcionesGuardar = 2;
                    asiento = Asiento.TraerAsientosporId(idasiento);
                    this.textBoxNumero.Text = asiento.Numero_asiento.ToString();
                    this.textBoxDescr.Text = asiento.Descripcion_asiento.ToString();
                    string fecha = asiento.Fecha_asiento;
                    DateTime oDate = DateTime.Parse(fecha);
                    this.dateTimePickerFecha.Value = oDate;
                    groupBoxAsiento.Text = "Editar Asiento";
                    this.Text = "Editar Asiento";
                    LlenarDataGrip(asiento.Asiento_movimiento);

                }
                else
                {
                    opcionesGuardar = 3;
                    asiento = Asiento.TraerAsientosporId(idasiento);
                    this.textBoxNumero.Text = asiento.Numero_asiento.ToString();
                    this.textBoxNumero.Enabled = false;
                    this.textBoxDescr.Text = asiento.Descripcion_asiento.ToString();
                    this.textBoxDescr.Enabled = false;
                    string fecha = asiento.Fecha_asiento;
                    DateTime oDate = DateTime.Parse(fecha);
                    this.dateTimePickerFecha.Value = oDate;
                    this.dateTimePickerFecha.Enabled = false;
                    this.ColEditar.Visible = false;
                    this.ColEliminar.Visible = false;
                    dataGridMovimientos.Enabled = false;
                    botonNuevo.Visible = false;
                    groupBoxAsiento.Text = "Eliminar Asiento";
                    this.Text = "Eliminar Asiento";
                    LlenarDataGrip(asiento.Asiento_movimiento);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void botonNuevo_Click(object sender, EventArgs e)
        {
            try {
                Movimiento mov = new Movimiento();
                AgregarMovimiento nuevoMovi = new AgregarMovimiento(1, asiento, mov);
                nuevoMovi.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void eventos_botones(object sender, EventArgs e)
        {
            try
            {
                Movimiento mov = new Movimiento();
                AgregarMovimiento nuevoMovi = new AgregarMovimiento(1, asiento, mov);
                nuevoMovi.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            menuAnterior.Visible = true;
            this.Dispose();
        }

        private void VerAsiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            menuAnterior.Visible = true;
            this.Dispose();
        }

        private void LlenarDataGrip(List<Movimiento> movi2)
        {
            this.dataGridMovimientos.Rows.Clear();
            foreach (Movimiento item in movi2)
            {
                string debehaber = "";
                if (item.Debe_haber) debehaber = "Debe";
                else debehaber = "Haber";
                this.dataGridMovimientos.Rows.Add(item.Id, item.Cuenta.NombreCuenta, item.Cuenta.Tipocuenta.DescripcionTipo, item.Valor, debehaber);
            }
        }
        private void RefrescarDataGrip(List<Movimiento> movi2)
        {
            this.dataGridMovimientos.Rows.Clear();
            foreach (Movimiento item in movi2)
            {
                string debehaber = "";
                if (item.Debe_haber) debehaber = "Debe";
                else debehaber = "Haber";
                this.dataGridMovimientos.Rows.Add(item.Id, item.Cuenta.NombreCuenta, item.Cuenta.Tipocuenta.DescripcionTipo, item.Valor, debehaber);
            }
        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            if (opcionesGuardar == 1)
            {
                DialogResult result = MessageBox.Show("¿Desea crear el asiento?", "Guardar Asiento", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.OK)
                {
                    asiento.Numero_asiento = int.Parse(textBoxNumero.Text.ToString());
                    asiento.Descripcion_asiento = textBoxDescr.Text.ToString();
                    string fecha = dateTimePickerFecha.Value.ToString("yyyy-MM-dd");
                    asiento.Fecha_asiento = fecha;
                    int idasiento = Asiento.CrearAsiento(asiento);

                    foreach (Movimiento item in asiento.Asiento_movimiento)
                    {
                       item.Asiento = asiento;
                       item.Asiento.Id = idasiento;
                       Movimiento.CrearMovimiento(item);
                    }
                }
            }
            else if (opcionesGuardar == 2)
            {
                DialogResult result = MessageBox.Show("¿Desea guardar los cambios realizados?", "Guardar Cambios", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.OK)
                {
                    asiento.Numero_asiento = int.Parse(textBoxNumero.Text.ToString());
                    asiento.Descripcion_asiento = textBoxDescr.Text.ToString();
                    string fecha = dateTimePickerFecha.Value.ToString("yyyy-MM-dd");
                    asiento.Fecha_asiento = fecha;
                    Asiento.UpdateAsiento(asiento);
                    foreach (Movimiento item in asiento.Asiento_movimiento)
                    {
                        if (item.Id != 0)
                        {
                            Movimiento.UpdateMovimiento(item);
                        }
                        else
                        {
                            item.Asiento = asiento;
                            Movimiento.CrearMovimiento(item);
                        }
                    }
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("¿Esta seguro de eliminar el asiento?","Eliminar Asiento",MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.OK) {
                    Asiento.borrarAsiento(asiento.Id);
                }
            }
        }

        private void botonRefrescar_Click(object sender, EventArgs e)
        {
            RefrescarDataGrip(asiento.Asiento_movimiento);
        }
    }
}
