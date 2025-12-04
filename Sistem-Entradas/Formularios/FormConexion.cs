using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistem_Entradas.Datos;

namespace Sistem_Entradas.Formularios
{
    public partial class FormConexion : Form
    {
        private Conexion nConexion; 
        public FormConexion()
        {
            InitializeComponent();
            nConexion = new Conexion();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Datos.Conexion conexion = new Datos.Conexion();
            conexion.establecerConexion();
        }
    }
}
