using MySql.Data.MySqlClient;
using Sistem_Entradas.Clases;

namespace Sistem_Entradas.Datos
{
    public static class EspectaculoDatos
    {
        public static void GuardarEspectaculo(Espectaculo e)
        {
            using (var conexion = ConexionBD.ObtenerConexion())
            {
                conexion.Open();
                string query = "INSERT INTO espectaculos (Nombre, CapacidadTotal, PrecioBase, Foto) VALUES (@n, @c, @p, @f)";
                using (var cmd = new MySqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@n", e.Nombre);
                    cmd.Parameters.AddWithValue("@c", e.CapacidadTotal);
                    cmd.Parameters.AddWithValue("@p", e.PrecioBase);
                    cmd.Parameters.AddWithValue("@f", e.Foto);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
