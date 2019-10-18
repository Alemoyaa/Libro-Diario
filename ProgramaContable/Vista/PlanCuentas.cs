using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProgramaContable.Vista
{
    public partial class PlanCuentas : Form
    {
        public PlanCuentas()
        {
            InitializeComponent();
            
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=librodiario;";
            // Seleccionar todo
            string query = "SELECT * FROM cuentas";
            string tipoCuenta="";

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
                        switch (reader.GetString(2))
                        {
                            case "1":tipoCuenta = "Activo"; break;
                            case "2": tipoCuenta = "Pasivo"; break;
                            case "3": tipoCuenta = "Patrimonio Neto"; break;
                            case "4": tipoCuenta = "Resultado Positivo"; break;
                            case "5": tipoCuenta = "Resultado Negativo"; break;
                            default: tipoCuenta = "No especificado"; break;
                        }
                        dgvData.Rows.Add(reader.GetString(0), reader.GetString(1), tipoCuenta);
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
    }
}
