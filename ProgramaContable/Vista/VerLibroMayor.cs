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
    public partial class VerLibroMayor : Form
    {
        private List<MoviCuenta> listaAMostrar = new List<MoviCuenta>();
        public VerLibroMayor(int mes, int anio)
        {
            try { 
                InitializeComponent();
                List<Movimiento> lista = Movimiento.ListarMovimientosFecha(mes, anio);
                if (lista.Any())
                {
                    foreach (Movimiento mov in lista)
                    {
                        if (!listaAMostrar.Any() || !listaAMostrar.Exists(x => x.NombreCuenta.Equals(mov.Cuenta.NombreCuenta)))
                        {
                            MoviCuenta movinuevo = new MoviCuenta();
                            movinuevo.NombreCuenta = mov.Cuenta.NombreCuenta;
                            if (mov.Debe_haber)
                            {
                                movinuevo.Movimientosdebe.Add(mov);
                            }
                            else
                            {
                                movinuevo.Movimientoshaber.Add(mov);
                            }
                            listaAMostrar.Add(movinuevo);
                        }
                        else
                        {
                            MoviCuenta movi2 = listaAMostrar.Find(x => x.NombreCuenta.Equals(mov.Cuenta.NombreCuenta));
                            if (mov.Debe_haber)
                            {
                                movi2.Movimientosdebe.Add(mov);
                            }
                            else
                            {
                                movi2.Movimientoshaber.Add(mov);
                            }
                        }
                    }
                    MostrarTodo();
                    this.Visible = true;
                }
                else
                {
                    MessageBox.Show("No se encontraron movimientos en esa fecha", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public VerLibroMayor(bool opcion, int mes, int anio, int value)
        {
            //Este esta funcionando, arreglar los otros
            try { 
            InitializeComponent();
            if (opcion) {
                List<Movimiento> lista = Movimiento.ListarMovimientos(mes, anio, value);
                if (lista.Any())
                {
                    MoviCuenta movinuevo = new MoviCuenta();
                    movinuevo.NombreCuenta = lista.First().Cuenta.NombreCuenta;
                    foreach (Movimiento mov in lista)
                    {
                        if (mov.Debe_haber)
                        {
                            movinuevo.Movimientosdebe.Add(mov);
                        }
                        else
                        {
                            movinuevo.Movimientoshaber.Add(mov);
                        }
                    }
                    listaAMostrar.Add(movinuevo);
                    MostrarTodo();
                    this.Visible = true;
                }
                else
                {
                    MessageBox.Show("No se encontraron movimientos en esa fecha", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Visible = false;
                }
            }
            else
            {
                List<Movimiento> lista = Movimiento.ListarMovimientosTipo(mes, anio, value);
                if (lista.Any())
                {
                    foreach (Movimiento mov in lista)
                    {
                        if (!listaAMostrar.Any() || !listaAMostrar.Exists(x => x.NombreCuenta.Equals(mov.Cuenta.NombreCuenta)))
                        {
                            MoviCuenta movinuevo = new MoviCuenta();
                            movinuevo.NombreCuenta = mov.Cuenta.NombreCuenta;
                            if (mov.Debe_haber)
                            {
                                movinuevo.Movimientosdebe.Add(mov);
                            }
                            else
                            {
                                movinuevo.Movimientoshaber.Add(mov);
                            }
                            listaAMostrar.Add(movinuevo);
                        }
                        else
                        {
                            MoviCuenta movi2 = listaAMostrar.Find(x => x.NombreCuenta.Equals(mov.Cuenta.NombreCuenta));
                            if (mov.Debe_haber)
                            {
                                movi2.Movimientosdebe.Add(mov);
                            }
                            else
                            {
                                movi2.Movimientoshaber.Add(mov);
                            }
                        }
                    }
                        MostrarTodo();
                        this.Visible = true;
                }
                else
                {
                    MessageBox.Show("No se encontraron movimientos en esa fecha", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Visible = false;
                }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void MostrarTodo()
        {
            try { 
            String texto = "";
            foreach (MoviCuenta mov in listaAMostrar)
            {
                texto = texto + mov.NombreCuenta + "\r\n---------------\r\n";
                int elementosdebe = mov.Movimientosdebe.Count;
                int elementoshaber = mov.Movimientoshaber.Count;
                float total = CalcularTotal(mov);
                if (elementosdebe == elementoshaber)
                {
                    for (int i = 0; i < mov.Movimientosdebe.Count; i++)
                    {

                        texto = texto + mov.Movimientosdebe.ElementAt(i).Valor.ToString() + "  |  " + mov.Movimientoshaber.ElementAt(i).Valor.ToString() + "\r\n";
                    }
                    texto = texto + "---------------\r\nTotal: " + total + "\r\n\r\n";
                }
                else
                {
                    MoviCuenta movequilibrado = EquilibrarValores(mov);
                    for (int i = 0; i < mov.Movimientosdebe.Count; i++)
                    {
                        texto = texto + movequilibrado.Movimientosdebe.ElementAt(i).Valor.ToString() + "  |  " + movequilibrado.Movimientoshaber.ElementAt(i).Valor.ToString() + "\r\n";
                    }
                    texto = texto + "---------------\r\nTotal: " + total+ "\r\n\r\n";
                } 
            }
            this.textBoxMayores.Text = texto;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private MoviCuenta EquilibrarValores(MoviCuenta mov)
        {
            try { 
            if(mov.Movimientosdebe.Count > mov.Movimientoshaber.Count)
            {
                int dif = mov.Movimientosdebe.Count - mov.Movimientoshaber.Count;
                for (int i = 0; i < dif; i++)
                {
                    Movimiento m = new Movimiento();
                    m.Valor = 0f;
                    mov.Movimientoshaber.Add(m);
                }
                return mov;
            }
            else
            {
                int dif = mov.Movimientoshaber.Count - mov.Movimientosdebe.Count;
                for (int i = 0; i < dif; i++)
                {
                    Movimiento m = new Movimiento();
                    m.Valor = 0f;
                    mov.Movimientosdebe.Add(m);
                }
                return mov;
            }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        private float CalcularTotal(MoviCuenta mov)
        {
            try
            {
                float totaldebe = 0f;
                float totalhaber = 0f;
                foreach (Movimiento movd in mov.Movimientosdebe)
                {
                    totaldebe = totaldebe + movd.Valor;
                }
                foreach (Movimiento movd in mov.Movimientoshaber)
                {
                    totalhaber = totalhaber + movd.Valor;
                }

                return totaldebe - totalhaber;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
}

        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void VerLibroMayor_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

       
    }
}
