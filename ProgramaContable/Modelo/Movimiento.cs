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

        public Movimiento(int id, float valor, bool debehaber, Asiento asiento, Cuenta cuenta)
        {
            Id = id;
            Valor = valor;
            Debe_haber = debehaber;
            Asiento = asiento;
            Cuenta = cuenta;
        }
        
        //Crear movimiento 
        private void CrearMovimiento(int idAsiento, string cuenta, int valor, int doh)
        {

            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=librodiario;";
            string query = "INSERT INTO movimiento(asiento_id,cuenta_id,valor,debeohaber) VALUES('" + idAsiento + "','" + cuenta + "'," + valor + ", " + doh + ")";

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

        //Actualizar movimiento utilizando IdCuenta
        private void UpdateMovimiento(string idAsiento, int idcuenta, int valor, int doh)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=librodiario;";
            string query =
            "UPDATE movimiento SET asiento_id='" + idAsiento + "', valor='" + valor + "',debeohaber ='" + doh + "' WHERE cuenta_id = '" + idcuenta + "' ";
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
    }
}
