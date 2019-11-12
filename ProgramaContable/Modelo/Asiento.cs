using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ProgramaContable.Modelo
{
    public class Asiento
    {
        private int id;
        private int numero_asiento;
        private string fecha_asiento;
        private String descripcion_asiento;
        private List<Movimiento> asiento_movimiento;

        public int Id { get => id; set => id = value; }
        public int Numero_asiento { get => numero_asiento; set => numero_asiento = value; }
        public string Fecha_asiento { get => fecha_asiento; set => fecha_asiento = value; }
        public string Descripcion_asiento { get => descripcion_asiento; set => descripcion_asiento = value; }
        internal List<Movimiento> Asiento_movimiento { get => asiento_movimiento; set => asiento_movimiento = value; }

        public Asiento(int id, int numero, string fecha, string descrp)
        {
            Id = id;
            Numero_asiento = numero;
            Fecha_asiento = fecha;
            Descripcion_asiento = descrp;
        }

        public Asiento()
        {
            asiento_movimiento = new List<Movimiento>();
        }

        public static Asiento TraerAsientosporId(int idabuscar)
        {
            List<Asiento> listadeasiento = new List<Asiento>();
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=librodiario;";
            string query = "SELECT * FROM asiento a, movimiento m, cuentas c, tipocuenta t WHERE (a.id_asiento = m.asiento_id AND m.cuenta_id = c.id_cuenta AND c.tipocuenta_id = t.id_tipocuenta  AND a.id_asiento = "+idabuscar+")";

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
                    Asiento asiento = new Asiento();
                    while (reader.Read())
                    {
                    asiento.Id = reader.GetInt32(0);
                    asiento.Numero_asiento = reader.GetInt32(1);
                    asiento.Fecha_asiento = reader.GetString(2);
                    asiento.Descripcion_asiento = reader.GetString(3);
                    Movimiento mov = new Movimiento();
                    mov.Id = reader.GetInt32(4);
                    Cuenta cu = new Cuenta();
                    cu.IdCuenta = reader.GetInt32(6);
                    cu.NombreCuenta = reader.GetString(10);
                    TipodeCuenta tu = new TipodeCuenta();
                    tu.Id = reader.GetInt32(12);
                    tu.DescripcionTipo = reader.GetString(13);
                    cu.Tipocuenta = tu;
                    mov.Cuenta = cu;
                    mov.Asiento = asiento;
                    mov.Valor = reader.GetFloat(7);
                    mov.Debe_haber = reader.GetBoolean(8);
                    asiento.Asiento_movimiento.Add(mov);

                    }
                    listadeasiento.Add(asiento);
                }

                databaseConnection.Close();
                
                return listadeasiento.First();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return listadeasiento.First();
            }
        }
        public static List<Asiento> ListarAsientos()
        {
            List<Asiento> listadeasiento = new List<Asiento>();
                string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=librodiario;";
                string query = "SELECT * FROM asiento";


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
                            Asiento asiento = new Asiento();
                            asiento.Id = reader.GetInt32(0);
                            asiento.Numero_asiento = reader.GetInt32(1);
                            asiento.Fecha_asiento = reader.GetString(2);
                            asiento.Descripcion_asiento = reader.GetString(3);
                            listadeasiento.Add(asiento);
                        }
                    }

                    databaseConnection.Close();
                    return listadeasiento;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return listadeasiento;
                }
        }
        public static List<Asiento> ListarAsientosporFecha(string fecha)
        {
            List<Asiento> listadeasientos = new List<Asiento>();
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=librodiario;";
            string query = "SELECT * FROM asiento a WHERE (a.fecha_asiento = '"+fecha+"')";


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
                        Asiento asiento = new Asiento();
                        asiento.Id = reader.GetInt32(0);
                        asiento.Numero_asiento = reader.GetInt32(1);
                        asiento.Fecha_asiento = reader.GetDateTime(2).ToShortDateString();
                        asiento.Descripcion_asiento = reader.GetString(3);
                        listadeasientos.Add(asiento);
                    }
                }

                databaseConnection.Close();
                return listadeasientos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return listadeasientos;
            }
        }
        public static List<Asiento> ListarAsientosporMes(int mes, int anio)
        {
            List<Asiento> listadeasientos = new List<Asiento>();
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=librodiario;";
            string[] fechas = Convertirmesanio(mes, anio);
            string query = "SELECT * FROM asiento a WHERE (a.fecha_asiento >= '" + fechas[0] + "' AND a.fecha_asiento < '" + fechas[1] + "')";

            
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
                        Asiento asiento = new Asiento();
                        asiento.Id = reader.GetInt32(0);
                        asiento.Numero_asiento = reader.GetInt32(1);
                        asiento.Fecha_asiento = reader.GetDateTime(2).ToShortDateString();
                        asiento.Descripcion_asiento = reader.GetString(3);
                        listadeasientos.Add(asiento);
                    }
                }

                databaseConnection.Close();
                return listadeasientos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return listadeasientos;
            }
        }
        public static string[] Convertirmesanio(int mes, int anio)
        {
            string[] resultado = new string[2];
            if (mes == 12)
            {
                resultado[0] = anio + "-" + mes + "-" + "01";
                resultado[1] = anio + 1 + "-01-01";
            }
            else if (mes >= 1 && mes < 9)
            {
                resultado[0] = anio + "-" + 0 + mes + "-" + "01";
                mes = mes + 1;
                resultado[1] = anio + "-" + 0 + mes + "-" + "01";
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
                resultado[1] = anio + "-" + mes + "-" + "01";
            }

            return resultado;
        }
        public static int CrearAsiento(Asiento asi)
        {

            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=librodiario;";
            string query = "INSERT INTO asiento(numero_asiento, fecha_asiento, descr_asiento) VALUES(" + asi.Numero_asiento + ", '" + asi.Fecha_asiento + "', '" + asi.Descripcion_asiento + "')";
  

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                MessageBox.Show("Asiento creado satisfactoriamente");

                databaseConnection.Close();
                
                return Convert.ToInt32(commandDatabase.LastInsertedId);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return 0;
            }
        }
        public static void UpdateAsiento(Asiento asi)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=librodiario;";
            string query = "UPDATE asiento SET descr_asiento='" + asi.Descripcion_asiento + "', numero_asiento=" + asi.Numero_asiento + ", fecha_asiento='"+ asi.Fecha_asiento +"' WHERE id_asiento = " + asi.Id;

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
        public static void borrarAsiento(int idasiento)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=librodiario;";
            string query = "DELETE FROM asiento WHERE id_asiento = " + idasiento;

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
