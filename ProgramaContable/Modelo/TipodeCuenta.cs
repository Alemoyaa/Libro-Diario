using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProgramaContable.Modelo
{
    public class TipodeCuenta
    {
        private int id;
        private string descripcionTipo;

        public string DescripcionTipo { get => descripcionTipo; set => descripcionTipo = value; }
        public int Id { get => id; set => id = value; }

        public TipodeCuenta(int id, string descripcion)
        {
            Id = id;
            DescripcionTipo = descripcion;
        }
        public TipodeCuenta()
        {

        }
        public static TipodeCuenta TraerTipoPorID(int idtipo)
        {
            TipodeCuenta resultado = new TipodeCuenta();
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=librodiario;";
            string query = "SELECT t.id_tipocuenta, t.descr_tipocuenta FROM tipocuenta t WHERE t.id_tipocuenta = " + idtipo;

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
                        resultado.Id = int.Parse(reader.GetString(0));
                        resultado.DescripcionTipo = reader.GetString(1);
                    }
                }

                databaseConnection.Close();
                return resultado;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return resultado;
            }
        }
        public static List<TipodeCuenta> TraerTipos()
        {
            List<TipodeCuenta> listadetipos = new List<TipodeCuenta>();
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=librodiario;";
            string query = "SELECT * FROM tipocuenta";

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
                        TipodeCuenta tipo = new TipodeCuenta(int.Parse(reader.GetString(0)), reader.GetString(1));
                        listadetipos.Add(tipo);
                    }
                }

                databaseConnection.Close();
                return listadetipos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return listadetipos;
            }
        }
        public static void CrearTipo(string descrtipo)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=librodiario;";
            string query = "INSERT INTO tipocuenta(descr_tipocuenta) VALUES('" + descrtipo + "')";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

                MessageBox.Show("Tipo de cuenta insertada satisfactoriamente");

                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void UpdateTipoCuenta(int idtipodecuenta, string descr_tipo)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=librodiario;";
            string query = "UPDATE tipocuenta SET descr_tipocuenta='" + descr_tipo + "' WHERE id_tipocuenta = " + idtipodecuenta;

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
        public static void borrarTipoCuenta(int idtipocuenta)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=librodiario;";
            string query = "DELETE FROM tipocuenta WHERE id_tipocuenta = " + idtipocuenta;

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
