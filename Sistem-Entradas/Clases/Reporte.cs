using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Entradas.Clases
{
    internal class Reporte
    {
        private class Reportes
        {

            public List<Venta> ObtenerVentasPorFechas(DateTime desde, DateTime hasta)
            {
                return new List<Venta>();
            }

            public decimal CalculaeTotalPorEspectaculo(int idEspectaculo)
            {
                return 0;
            }

        }
    }
}
