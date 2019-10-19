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

namespace ProgramaContable.Vista
{
    public partial class AgregarCuenta : Form
    {
        public AgregarCuenta()
        {
            InitializeComponent();
            cargarmierda();
        }

        public void cargarmierda()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=librodiario;";
            string query = "INSERT INTO cuentas(id_cuentas, nombre_cuentas, tipocuenta_id) VALUES("+ 36 + ", " + "Prueba" + ", " + 5 + ")";
            string tipoCuenta = "";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            {
                try
                {
                    databaseConnection.Open();

                    //Si vamos a ejecutar una consulta, especificamos como CommandType Text
                    commandDatabase.CommandType = CommandType.Text;
                    //Si vamos a ejecutar un procedimiento almacenado, especificamos StoredProcedure
                    //query.CommandType= CommandType.StoredProcedure;
                    //query.CommandText="nombreDelProcedimientoAlmacenado";

                    //Especifiamos la query a ejecutar
                    //commandDatabase.CommandText = string.Format("INSERT INTO cuentas(id_cuentas,nombre_cuentas,tipocuenta_id) VALUES ("+ 36 + "," + "Prueba" + "," + 5 + ")");

                    //Como es un INSERT, la query no devuelve resultados, asi que ejecutamos un ExecuteNonQuery que nos
                    //devuelve el número de filas afectadas
                    int fil = commandDatabase.ExecuteNonQuery();

                    if (fil > 0)
                    {
                        //Todo ha ido bien
                        MessageBox.Show("Todo salio bien");
                    }
                    else
                    {
                        MessageBox.Show("Todo salio mal");
                        //No se ha ejecutado correctamente
                    }
                }
                catch
                {

                    MessageBox.Show("excepcion");
                    //Aqui recibimos las posibles excepciones
                }
                finally
                {
                    //Nos aseguramos de cerrar la conexión
                    if (databaseConnection.State != ConnectionState.Closed)
                        databaseConnection.Close();
                }
            }
        }
    }
}
