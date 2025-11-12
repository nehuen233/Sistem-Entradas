using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Entradas.Clases
{
    public class Vendedor : Usuario
    {
        public Vendedor(int id, string Nombre, string Rol, string Contraseña) : base(id, Nombre, Rol, Contraseña)
        {
            Rol = "Vendedor";
        }

        public void RegistrarVenta(Venta v)
        {

        }

        public bool VerificarDisponibilidad(Ubicacion u, int cantidad)
        {

            return false;
        }
    }
}
