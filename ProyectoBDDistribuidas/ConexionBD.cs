using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoBDDistribuidas
{
    class ConexionBD
    {
        string cadena = "Data Source=EDISON-LAPTOP;Initial Catalog=agencia; User ID=sa; Password=123456; Application Name=ProyectoBDDistribuidas";
        public SqlConnection cn = new SqlConnection();
        private DataSet ds;

        public ConexionBD()
        {
            cn.ConnectionString = cadena;
        }

        public void Abrir()
        {
            try
            {
                cn.Open();
                Console.WriteLine("Conexion Exitosa");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al abrir la Base de Datos" + ex.Message);
            }

        }

        public void Cerrar()
        {
            cn.Close();
        }

    }
}
