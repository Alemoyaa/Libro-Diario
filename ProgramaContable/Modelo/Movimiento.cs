using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramaContable.Modelo
{
    class Movimiento
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
        //Crear movimiento 
        private void CrearMovimiento(int idasiento, int idcuenta, int valor, bool debe)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=librodiario;";
            string query = "INSERT INTO movimiento(asiento_id,cuenta_id,valor,debeohaber) VALUES(" + idasiento + ", " + idcuenta + ", " + valor + ", " + debe + ")";

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
        //Actualizar movimiento utilizando Idmovimiento
        private void UpdateMovimiento(int idmovimiento, int idasiento, int idcuenta, int valor, bool debe)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=librodiario;";
            string query =
            "UPDATE movimiento SET asiento_id=" + idasiento + ", cuenta_id=" + idcuenta + ", valor=" + valor + ", debeohaber =" + debe + " WHERE id_movimiento = " + idmovimiento;
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
        private List<Movimiento> ListarMovimientos(int idasiento)
        {
            List<Movimiento> listademovimientos = new List<Movimiento>();
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=librodiario;";
            string query = "SELECT * FROM movimiento m, asiento a, cuenta c WHERE (m.asiento_id = a.id_asiento AND m.asiento_id = "+idasiento+")"; 

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
        private void borrarMovimiento(int idmovimiento)
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
