using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace ProyectoBDDistribuidas
{
    public partial class CLIENTES : Form
    {
        ConexionBD con = new ConexionBD();
        public SqlConnection cn = new SqlConnection();
        private DataSet ds;
        public CLIENTES()
        {
            InitializeComponent();
        }

        public DataTable MostrarDatos()
        {
            con.Abrir();
            SqlCommand cmd = new SqlCommand("select * from CLIENTES", cn);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            con.Cerrar();
            return ds.Tables["tabla"];
        }

        public bool Insertar(string ID, string LastName, string FirstName, string Age, string City)
        {
            con.Abrir();
            SqlCommand cmd = new SqlCommand(string.Format("insert into CLIENTES values ({0}, '{1}', '{2}', {3} , '{4}')", new string[] { ID, LastName, FirstName, Age, City }), cn);
            int filasafectadas = cmd.ExecuteNonQuery();
            con.Cerrar();
            if (filasafectadas > 0)
            {
                return true;
            }

            else
            {
                return false;
            }
        }


        public DataTable Buscar(string FirstName)
        {
            con.Abrir();
            SqlCommand cmd = new SqlCommand(string.Format("select * from CLIENTES where  FirstName like '%{0}%'", FirstName), cn);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            con.Cerrar();
            return ds.Tables["tabla"];
        }


        public bool Eliminar(string id)
        {
            con.Abrir();
            SqlCommand cmd = new SqlCommand(string.Format("delete from CLIENTES where ID = {0}", id), cn);
            int filasafectadas = cmd.ExecuteNonQuery();
            con.Cerrar();
            if (filasafectadas > 0) return true;
            else return false;
        }


        public bool Actualizar(string ID, string LastName, string FirstName, string Age, string City)
        {
            con.Abrir();
            SqlCommand cmd = new SqlCommand(string.Format("update CLIENTES set LastName = '{0}', FirstName = '{1}' , Age = {2} , City = '{3}' where ID = {4}", new string[] { LastName, FirstName, Age, City, ID }), cn);
            int filasafectadas = cmd.ExecuteNonQuery();
            con.Cerrar();
            if (filasafectadas > 0) return true;
            else return false;
        }

    }
}
