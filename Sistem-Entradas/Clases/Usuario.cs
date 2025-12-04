using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Entradas.Clases
{
        public class Usuario
        {

            public int id { get; set; }
            public string Nombre { get; set; }
            public string Rol { get; set; } //administrador, vendedor
            public string Contraseña { get; set; } //Contraseña Usuario


            public Usuario(int id, string Nombre, string Rol, string Contraseña)
            {
                this.id = id;
                this.Nombre = Nombre;
                this.Rol = Rol;
                this.Contraseña = Contraseña;
            }

            public void CerrarSesion()
            {

            }
        }
}

