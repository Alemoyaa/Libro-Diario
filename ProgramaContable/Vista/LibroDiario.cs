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
            string fecha = dateTimePickerFecha.Value.ToString("yyyy-MM-dd");
            List<Asiento> asientoAMostrar = Asiento.ListarAsientosporFecha(fecha);
            LlenarDataGrip(asientoAMostrar);
        }

        private void LibroDiario_FormClosing(object sender, FormClosingEventArgs e)
        {
            VistaAnterior.Visible = true;
            this.Dispose();
        }

        private void LibroDiario_Load(object sender, EventArgs e)
        {
            string fecha = DateTime.Now.ToString("yyyy-MM-dd");
            List<Asiento> asientoAMostrar = Asiento.ListarAsientosporFecha(fecha);
            LlenarDataGrip(asientoAMostrar);
        }

        private void BotonTodosMes_Click(object sender, EventArgs e)
        {
            DateTime fecha = dateTimePickerFecha.Value;
            int mes = fecha.Month;
            int anio = fecha.Year;
            List<Asiento> asientoAMostrar = Asiento.ListarAsientosporMes(mes,anio);
            LlenarDataGrip(asientoAMostrar);
        }

        private void LlenarDataGrip(List<Asiento> asientos)
        {
            this.dataGridAsientos.Rows.Clear();
            foreach (Asiento item in asientos)
            {
                this.dataGridAsientos.Rows.Add(item.Id,item.Numero_asiento, item.Fecha_asiento, item.Descripcion_asiento);
            }
        }

        
    }
}
