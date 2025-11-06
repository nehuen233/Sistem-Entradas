using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Entradas.Clases
{
    internal class Ubicacion
    {
        private class Ubication
        {
            public int id { get; set; }
            public string Nombre { get; set; }
            public int Capacidad { get; set; }
            public double Precio { get; set; }
            public int EntradasVendidas { get; set; }

            public Ubication(int id, string nombre, int capacidad, double precio, int entradasVendidas)
            {
                this.id = id;
                Nombre = nombre;
                Capacidad = capacidad;
                Precio = precio;
                EntradasVendidas = entradasVendidas;
            }

            public bool HayDisponibilidad(int cantidad)
            {
                return false;
            }

            public void RegistrarVenta(int cantidad)
            {

            }

        }
    }
}
