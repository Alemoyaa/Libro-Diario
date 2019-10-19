using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramaContable
{
    public partial class MenuContable : Form
    {
        public MenuContable()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            LibroDiario libroDiario = new LibroDiario();
            libroDiario.Visible = true;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Vista.PlanCuentas plan = new Vista.PlanCuentas();
            plan.Visible = true;
            ListarCuentas();
        }

        private void ListarCuentas()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=librodiario;";
            // Seleccionar todo
            string query = "SELECT * FROM cuentas";

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
                        Console.WriteLine(reader.GetString(0) + " - " + reader.GetString(1) + " - " + reader.GetString(2));
                    }
                }
                else
                {
                    Console.WriteLine("No se encontro nada");
                }

                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BLibroMayor_Click(object sender, EventArgs e)
        {
            Vista.AgregarCuenta agregar = new Vista.AgregarCuenta();
            agregar.Visible = true;
        }
    }
}
