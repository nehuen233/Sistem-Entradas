using MySql.Data.MySqlClient;

namespace Sistem_Entradas.Datos
{
    public static class ConexionBD
    {
        private static string cadena = "Server=localhost;Database=sistem_entradas;Uid=root;Pwd=;";

        public static MySqlConnection ObtenerConexion()
        {
            return new MySqlConnection(cadena);
        }
    }
}

