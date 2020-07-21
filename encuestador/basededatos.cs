using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Windows.Forms;

namespace encuestador
{

    public SqlConnection conexion { get; } = null;

    public static basededatos instance { get; } = new basededatos();

   


    public class basededatos
    {
       

        public basededatos()
        {
            conexion = new SqlConnection("Data Source=LATITUDE\\SQLEXPRESS; initial Catalog=Registro;integrated security = true");
            conexion.Open();



        }
        public string agregar(string nombre, string apellido, string nombreusuario, string contraseña)
        {
            string salida = "Se a Registrado";
            try
            {

                conection = new SqlCommand("insert into Registrar1(nombre,apellido,nombreusuario,contraseña )" +
                    "values('"+nombre+ "','" + apellido + "','" + nombreusuario + "','" + contraseña + "',')",conexion);
                conection.ExecuteNonQuery();
                

            }
            catch(Exception e)
            {

                salida = "No se Registro" + e.ToString();

            }

            return salida;


        }

    }
}
