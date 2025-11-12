using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Entradas.Clases
{
        public class Espectaculo
        {
            public int id { get; set; }
            public string Nombre { get; set; }
            public int CapacidadTotal { get; set; }
            public double PrecioBase { get; set; }
            public string Foto { get; set; }
            List<Ubicacion> Ubicaciones;

            public Espectaculo(int id, string Nombre, int CapacidadTotal, double PrecioBase, string Foto)
            {
                this.id = id;
                this.Nombre = Nombre;
                this.CapacidadTotal = CapacidadTotal;
                this.PrecioBase = PrecioBase;
                this.Foto = Foto;
                Ubicaciones = new List<Ubicacion>();
            }
            public void AgregarUbicacion(Ubicacion u)
            {

            }

            public bool VerificarCapacidad(int cantidad)
            {
                return false;
            }

            public int ObtenerCapacidadDisponible()
            {
                return 0;
            }
        }
}

