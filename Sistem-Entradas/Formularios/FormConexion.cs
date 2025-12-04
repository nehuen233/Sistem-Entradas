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
        private ConexionBD nConexion; 
        public FormConexion()
        {
            InitializeComponent();
            nConexion = new ConexionBD();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Datos.ConexionBD conexion = new Datos.ConexionBD();
            conexion.ObtenerConexion();
        }

        private void FormConexion_Load(object sender, EventArgs e)
        {

        }
    }
}
