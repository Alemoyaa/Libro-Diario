using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramaContable.Modelo
{
    public class Movimiento
    {
        private int id;
        private Asiento asiento;
        private Cuenta cuenta;
        private float valor;
        private bool debe_haber;

        public int Id { get => id; set => id = value; }
        public float Valor { get => valor; set => valor = value; }
        public bool Debe_haber { get => debe_haber; set => debe_haber = value; }
        internal Asiento Asiento { get => asiento; set => asiento = value; }
        internal Cuenta Cuenta { get => cuenta; set => cuenta = value; }

        public Movimiento(int id, Asiento asiento, Cuenta cuenta, float valor, bool debehaber)
        {
            Id = id;
            Asiento = asiento;
            Cuenta = cuenta;
            Valor = valor;
            Debe_haber = debehaber;
        }
        public Movimiento()
        {

        }
        public static Movimiento TraerMovimientosporId(int idmovimiento)
        {
            List<Movimiento> listademovimientos = new List<Movimiento>();
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=librodiario;";
            string query = "SELECT * FROM movimiento m, cuentas c, tipocuenta t WHERE (m.cuenta_id = c.id_cuenta AND c.tipocuenta_id = t.id_tipocuenta AND m.id_movimiento ="+idmovimiento+")";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Movimiento movimiento = new Movimiento();
                        Asiento asiento = new Asiento();
                        Cuenta cuenta = new Cuenta();

                        movimiento.Id = reader.GetInt32(0);
                        asiento.Id = reader.GetInt32(1);
                        cuenta.IdCuenta = reader.GetInt32(2);
                        movimiento.Valor = reader.GetFloat(3);
                        movimiento.Debe_haber = reader.GetBoolean(4);
                        cuenta.NombreCuenta = reader.GetString(6);
                        cuenta.Tipocuenta = new TipodeCuenta();
                        cuenta.Tipocuenta.Id = reader.GetInt32(7);
                        cuenta.Tipocuenta.DescripcionTipo = reader.GetString(9);
                        movimiento.Asiento = asiento;
                        movimiento.Cuenta = cuenta;
                       
                        listademovimientos.Add(movimiento);
                    }
                }

                databaseConnection.Close();
                return listademovimientos.First() ;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return listademovimientos.First();
            }
        }
        public static void CrearMovimiento(Movimiento mov)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=librodiario;";
            string query = "INSERT INTO movimiento(asiento_id,cuenta_id,valor,debeohaber) VALUES(" + mov.Asiento.Id + ", " + mov.Cuenta.IdCuenta + ", " + mov.Valor + ", " + mov.Debe_haber + ")";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();
                MessageBox.Show("Movimiento Realizado satisfactoriamente");
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void UpdateMovimiento(Movimiento mov)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=librodiario;";
            string query =
            "UPDATE movimiento SET asiento_id=" + mov.Asiento.Id + ", cuenta_id=" + mov.Cuenta.IdCuenta + ", valor=" + mov.Valor + ", debeohaber =" + mov.Debe_haber + " WHERE id_movimiento = " + mov.Id;
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

                // Actualizado satisfactoriamente

                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                // Ops, quizás el ID no existe
                MessageBox.Show(ex.Message);
            }
        }
        public static List<Movimiento> ListarMovimientos(int idasiento)
        {
            List<Movimiento> listademovimientos = new List<Movimiento>();
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=librodiario;";
            string query = "SELECT * FROM movimiento m, asiento a, cuentas c WHERE (m.asiento_id = a.id_asiento AND m.asiento_id = "+idasiento+")"; 

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Movimiento movimiento = new Movimiento();
                        Asiento asiento = new Asiento();
                        Cuenta cuenta = new Cuenta();
                        asiento.Id = reader.GetInt32(0);
                        asiento.Numero_asiento = reader.GetInt32(1);
                        asiento.Fecha_asiento = reader.GetString(2);
                        asiento.Descripcion_asiento = reader.GetString(3);
                        cuenta.IdCuenta = reader.GetInt32(4);
                        cuenta.NombreCuenta = reader.GetString(5);
                        cuenta.Tipocuenta = new TipodeCuenta();
                        cuenta.Tipocuenta.Id = reader.GetInt32(6);
                        movimiento.Asiento = asiento;
                        movimiento.Cuenta = cuenta;
                        movimiento.Id = reader.GetInt32(7);
                        movimiento.Valor = reader.GetFloat(10);
                        movimiento.Debe_haber = reader.GetBoolean(11);
                        listademovimientos.Add(movimiento);
                    }
                }

                databaseConnection.Close();
                return listademovimientos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return listademovimientos;
            }
        }
        public static List<Movimiento> ListarMovimientos(int mes, int anio, int idcuenta)
        {
            List<Movimiento> listademovimientos = new List<Movimiento>();
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=librodiario;";
            string[] fechas = Convertirmesanio(mes, anio);
            string query = "SELECT m.id_movimiento, m.valor, m.debeohaber, c.nombre_cuenta FROM movimiento m, asiento a, cuentas c WHERE (m.asiento_id = a.id_asiento AND m.cuenta_id = c.id_cuenta AND c.id_cuenta = " + idcuenta+" AND a.fecha_asiento >= '"+fechas[0]+"' AND a.fecha_asiento < '"+fechas[1]+"')";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Movimiento movimiento = new Movimiento();
                        movimiento.Id = reader.GetInt32(0);
                        movimiento.Valor = reader.GetFloat(1);
                        movimiento.Debe_haber = reader.GetBoolean(2);
                        movimiento.Cuenta = new Cuenta();
                        movimiento.Cuenta.NombreCuenta = reader.GetString(3);
                        listademovimientos.Add(movimiento);
                    }
                }

                databaseConnection.Close();
                return listademovimientos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return listademovimientos;
            }
        }
        public static List<Movimiento> ListarMovimientosTipo(int mes, int anio, int idtipo)
        {
            List<Movimiento> listademovimientos = new List<Movimiento>();
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=librodiario;";
            string[] fechas = Convertirmesanio(mes, anio);
            string query = "SELECT m.id_movimiento, m.valor, m.debeohaber, c.nombre_cuenta " +
                "FROM movimiento m, asiento a, cuentas c, tipocuenta t WHERE (m.asiento_id = a.id_asiento AND m.cuenta_id = c.id_cuenta AND c.tipocuenta_id = t.id_tipocuenta AND t.id_tipocuenta = "+idtipo+" AND a.fecha_asiento >= '"+fechas[0]+"' AND a.fecha_asiento < '"+fechas[1]+"')";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Movimiento movimiento = new Movimiento();
                        movimiento.Id = reader.GetInt32(0);
                        movimiento.Valor = reader.GetFloat(1);
                        movimiento.Debe_haber = reader.GetBoolean(2);
                        movimiento.Cuenta = new Cuenta();
                        movimiento.Cuenta.NombreCuenta = reader.GetString(3);
                        listademovimientos.Add(movimiento);
                    }
                }

                databaseConnection.Close();
                return listademovimientos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return listademovimientos;
            }
        }
        public static List<Movimiento> ListarMovimientosFecha(int mes, int anio)
        {
            List<Movimiento> listademovimientos = new List<Movimiento>();
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=librodiario;";
            string[] fechas = Convertirmesanio(mes, anio);
            string query = "SELECT m.id_movimiento, m.valor, m.debeohaber, c.nombre_cuenta " +
                "FROM movimiento m, asiento a, cuentas c WHERE (m.asiento_id = a.id_asiento AND m.cuenta_id = c.id_cuenta AND a.fecha_asiento >= '" + fechas[0] + "' AND a.fecha_asiento < '" + fechas[1] + "')";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Movimiento movimiento = new Movimiento();
                        movimiento.Id = reader.GetInt32(0);
                        movimiento.Valor = reader.GetFloat(1);
                        movimiento.Debe_haber = reader.GetBoolean(2);
                        movimiento.Cuenta = new Cuenta();
                        movimiento.Cuenta.NombreCuenta = reader.GetString(3);
                        listademovimientos.Add(movimiento);
                    }
                }

                databaseConnection.Close();
                return listademovimientos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return listademovimientos;
            }
        }
        public static string[] Convertirmesanio(int mes, int anio)
        {
            string[] resultado = new string[2];
            if (mes == 12)
            {
                resultado[0] = anio + "-" + mes + "-" + "01";
                resultado[1] = anio+1 + "-01-01";
            }
            else if(mes >=1 && mes < 9)
            {
                resultado[0] = anio + "-" + 0+mes + "-" + "01";
                mes = mes+1;
                resultado[1] = anio + "-" + 0+mes + "-" + "01";
            }
            else if (mes == 9)
            {
                resultado[0] = anio + "-" + 0 + mes + "-" + "01";
                resultado[1] = anio + "-10-01";
            }
            else
            {
                resultado[0] = anio + "-" + mes + "-" + "01";
                mes = mes + 1;
                resultado[1] = anio + "-" + mes+  "-" + "01";
            }
            
            return resultado;
        }

        public static void EliminarMovimiento(int idmovimiento)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=librodiario;";
            string query = "DELETE FROM movimiento WHERE id_movimiento = " + idmovimiento;

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
