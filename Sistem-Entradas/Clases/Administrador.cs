using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Entradas.Clases
{
    internal class Administrador : Usuarios
    {
        public Administrador(int id, string Nombre, string Rol, string Contraseña) : base(id, Nombre, Rol, Contraseña)
        {
            Rol = "Administrador";
        }
        public void CrearEspectaculo(Espectaculo es)
        {

        }

        public void CrearUbicacion(Espectaculo es, Ubicacion ub)
        {

        }

        public void VerReporte(DateTime desde, DateTime hasta)
        {


        }
    }
}
