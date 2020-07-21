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
using System.Data.Sql;


namespace encuestador
{
    public partial class registrar : Form
    {



        public SqlConnection conexion;


        public registrar()
        {
            InitializeComponent();
        }


        private void registrar_Load(object sender, EventArgs e)
        {

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {

            try
            {
                conexion = new SqlConnection("Data Source=LATITUDE\\SQLEXPRESS; initial Catalog=Registro;integrated security = true");
                conexion.Open();



            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podido conectar a la base de datos");


            }

           
                if (tb_contraseña.Text == tb_confirmarcontraseña.Text)
                {                 

                   

                        string add = "INSERT INTO Registrar1(Nombre,apellido,Nombreusuario,Contraseña )VALUES(@nombre,@apellido,@nombreusuario,@contraseña)";
                        
                        SqlCommand Comand = new SqlCommand(add, conexion);
                        Comand.Parameters.AddWithValue("@Nombre", tb_nombre.Text);
                        Comand.Parameters.AddWithValue("@Apellido", tb_apellido.Text);
                        Comand.Parameters.AddWithValue("@Nombreusuario", tb_usuario.Text);
                        Comand.Parameters.AddWithValue("@Contraseña", tb_contraseña.Text);
                        Comand.ExecuteNonQuery();                

                    MessageBox.Show("Se a registrado");
                    frm_login login = new frm_login();
                    login.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Debe repetir la contraseña ");

                }
            conexion.Close();

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            frm_login login = new frm_login();
            login.Show();
            this.Hide();
        }

        public void tb_nombre_TextChanged(object sender, EventArgs e)
        {
            

        }
       


    }
}
