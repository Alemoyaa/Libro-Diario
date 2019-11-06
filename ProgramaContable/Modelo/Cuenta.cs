using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProgramaContable.Modelo
{
    class Cuenta
    {
        private int idCuenta;
        private String nombreCuenta;
        private TipodeCuenta tipocuenta;

        public int IdCuenta { get => idCuenta; set => idCuenta = value; }
        public string NombreCuenta { get => nombreCuenta; set => nombreCuenta = value; }
        internal TipodeCuenta Tipocuenta { get => tipocuenta; set => tipocuenta = value; }

        public Cuenta(int id, string nombre, TipodeCuenta tipo)
        {
            IdCuenta = id;
            NombreCuenta = nombre;
            Tipocuenta = tipo;
        }

        public Cuenta()
        {

        }

        private List<Cuenta> ListarCuentas()
        {
            List<Cuenta> listadecuentas = new List<Cuenta>();
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=librodiario;";
            string query = "SELECT c.id_cuenta, c.nombre_cuenta, c.tipocuenta_id, t.id_tipocuenta, t.descr_tipocuenta FROM cuentas c, tipocuenta t WHERE c.tipocuenta_id = t.id_tipocuenta";


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
                        Cuenta cuenta = new Cuenta();
                        cuenta.IdCuenta = int.Parse(reader.GetString(0));
                        cuenta.NombreCuenta = reader.GetString(1);
                        TipodeCuenta tipo = new TipodeCuenta(int.Parse(reader.GetString(3)), reader.GetString(4));
                        cuenta.Tipocuenta = tipo;
                        listadecuentas.Add(cuenta);
                    }
                }

                databaseConnection.Close();
                return listadecuentas;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return listadecuentas;
            }
        }
        private List<Cuenta> ListarCuentas(TipodeCuenta tipo)
        {
            List<Cuenta> listadecuentas = new List<Cuenta>();
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=librodiario;";
            string query = "SELECT c.id_cuenta, c.nombre_cuenta, c.tipocuenta_id FROM cuentas c, tipocuenta t WHERE(c.tipocuenta_id = t.id_tipocuenta AND t.id_tipocuenta = " + tipo.Id + ")";


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
                        Cuenta cuenta = new Cuenta();
                        cuenta.IdCuenta = int.Parse(reader.GetString(0));
                        cuenta.NombreCuenta = reader.GetString(1);
                        cuenta.Tipocuenta = tipo;
                        listadecuentas.Add(cuenta);
                    }
                }

                databaseConnection.Close();
                return listadecuentas;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return listadecuentas;
            }
        }
        private void CrearCuenta(string nombrecuenta, TipodeCuenta tipo)
        {

            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=librodiario;";
            string query = "INSERT INTO cuentas(nombre_cuenta, tipocuenta_id) VALUES('" + nombrecuenta + "', " + tipo.Id + ")";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                MessageBox.Show("Cuenta insertada satisfactoriamente");

                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void UpdateCuenta(int idcuenta, string descr, int idtipodecuenta)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=librodiario;";
            string query = "UPDATE cuentas SET nombre_cuenta='" + descr + "', tipocuenta_id=" + idtipodecuenta + " WHERE id_cuenta = " + idcuenta;

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
        private void borrarCuenta(int idcuenta)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=librodiario;";
            string query = "DELETE FROM cuentas WHERE id_cuenta = " + idcuenta;

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
