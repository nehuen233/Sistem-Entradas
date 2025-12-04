using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistem_Entradas.Formularios;

namespace Sistem_Entradas
{
    internal class Program
    {
            /// <summary>
            /// Punto de entrada principal para la aplicación.
            /// </summary>
            [STAThread]
            static void Main()
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FormConexion());
            }
        }

    
}
