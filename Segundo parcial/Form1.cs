using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Segundo_parcial
{
    public partial class Form1 : Form
    {
        string cadenaConexion =
        @"Server=localhost;Database=Productos;Integrated Security=True;TrustServerCertificate=True;";
        public Form1()
        {
            InitializeComponent();
            ProbarConexion();
        }

        private void ProbarConexion()
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    MessageBox.Show("Conexión exitosa a la base de datos.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error en conexión.");
            }
        public Form1()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
    //Integrantes de grupo Cristopher godoy y Jonathan Mauricio Hernández Navidad
}

