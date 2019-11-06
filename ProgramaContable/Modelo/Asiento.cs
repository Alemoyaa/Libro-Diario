using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProgramaContable.Modelo
{
    class Asiento
    {
        private int id;
        private int numero_asiento;
        private string fecha_asiento;
        private String descripcion_asiento;

        public int Id { get => id; set => id = value; }
        public int Numero_asiento { get => numero_asiento; set => numero_asiento = value; }
        public string Fecha_asiento { get => fecha_asiento; set => fecha_asiento = value; }
        public string Descripcion_asiento { get => descripcion_asiento; set => descripcion_asiento = value; }

        public Asiento(int id, int numero, string fecha, string descrp)
        {
            Id = id;
            Numero_asiento = numero;
            Fecha_asiento = fecha;
            Descripcion_asiento = descrp;
        }

        public Asiento()
        {
        }

        private List<Asiento> ListarAsientos()
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
        private List<Asiento> ListarAsientosporFecha(string fecha)
        {
            List<Asiento> listadeasientos = new List<Asiento>();
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=librodiario;";
            string query = "SELECT * FROM asiento a WHERE a.fecha_asiento = '"+fecha+"')";


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
                        asiento.Id = reader.GetInt32(0)
                        asiento.Numero_asiento = reader.GetInt32(1);
                        asiento.Fecha_asiento = reader.GetDateTime(2);
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
        private List<Asiento> ListarAsientosporMes(int mes, int anio)
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
                        asiento.Id = reader.GetInt32(0)
                        asiento.Numero_asiento = reader.GetInt32(1);
                        asiento.Fecha_asiento = reader.GetDateTime(2);
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
        private string[] Convertirmesanio(int mes, int anio)
        {
            string[] resultado;
            resultado[0] = "'" + anio + "-" + mes + "-" + "01'";
            resultado[1] = "'" + anio + "-" + mes+1 + "-" + "01'";
            return resultado;
        }
        private void CrearAsiento(int numero, string fecha, string descr)
        {

            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=librodiario;";
            string query = "INSERT INTO asiento(numero_asiento, fecha_asiento, descr_asiento) VALUES(" + numero + ", '" + fecha + "', '" + descr + "')";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                MessageBox.Show("Asiento creado satisfactoriamente");

                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void UpdateAsiento(int idasiento, int numero, string fecha, string descr)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=librodiario;";
            string query = "UPDATE asiento SET descr_asiento='" + descr + "', numero_asiento=" + numero + ", fecha_asiento='"+ fecha +"' WHERE id_asiento = " + idasiento;

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
        private void borrarAsiento(int idasiento)
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
