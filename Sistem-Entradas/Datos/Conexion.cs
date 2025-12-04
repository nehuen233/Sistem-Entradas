using System.Data.SqlClient;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Sistem_Entradas.Datos
{
    class ConexionBD
    {
        MySqlConnection conexion = new MySqlConnection();
        static string servidor = "localhost";
        static string bd = "sistema_entradas";
        static string usuario = "root";
        static string password = "";
        static string puerto = "3306";
        string cadenaConexion =
                        "server=" + servidor +
                        ";database=" + bd +
                        ";user=" + usuario +
                        ";password=" + password +
                        ";port=" + puerto + ";";


        public MySqlConnection ObtenerConexion()
        {
            try
            {
                conexion.ConnectionString = cadenaConexion;
                conexion.Open();
                MessageBox.Show("Se Conecto a la BD Correctamente");
            }

            catch (MySqlException e)
            {
                MessageBox.Show("No se Conecto Correctamente a la BD" + e.ToString());
            }

            return conexion;
        }



    }
}

