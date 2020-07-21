using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace encuestador
{
    public partial class frm_login : Form
    {

        private SqlConnection conexion;
        public frm_login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            registrar Registrar = new registrar();
            Registrar.Show();
            this.Hide();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_iniciar_Click(object sender, EventArgs e)
        {
           
            try
            {
                conexion = new SqlConnection("Data Source=LATITUDE\\SQLEXPRESS; initial Catalog=Registro;integrated security = true");
                conexion.Open();
               


            }
            catch(Exception ex)
            {
                MessageBox.Show("Usuario o Contraseña incorrecta");
                
            }


            }
        
           

        }
    }

