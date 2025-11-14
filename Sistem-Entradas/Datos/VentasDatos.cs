using MySql.Data.MySqlClient;
using Sistem_Entradas.Clases;

namespace Sistem_Entradas.Datos
{
    public static class VentaDatos
    {
        public static void GuardarVenta(Venta v)
        {
            using (var conexion = ConexionBD.ObtenerConexion())
            {
                conexion.Open();
                string query = "INSERT INTO ventas (Fecha, IdEspectaculo, IdUbicacion, IdVendedor, Cantidad, Total) " +
                               "VALUES (@f, @e, @u, @v, @c, @t)";
                using (var cmd = new MySqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@f", v.Fecha);
                    cmd.Parameters.AddWithValue("@e", v.Espectaculo.id);
                    cmd.Parameters.AddWithValue("@u", v.Ubicacion.id);
                    cmd.Parameters.AddWithValue("@v", v.Vendedor.id);
                    cmd.Parameters.AddWithValue("@c", v.Cantidad);
                    cmd.Parameters.AddWithValue("@t", v.Total);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
