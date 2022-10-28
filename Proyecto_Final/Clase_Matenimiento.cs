using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final
{
    class Clase_Matenimiento
    {
        private string cadena = @"Data Source=GWTN156-5\SQLEXPRESS01;Initial Catalog=neptuno;Integrated Security=True";
        public SqlConnection cn;
        private SqlCommandBuilder cmb;
        public DataSet ds = new DataSet();
        public SqlDataAdapter da;
        public SqlCommand comando;

        private void conectar()
        {
            cn = new SqlConnection(cadena);
        }
        public Clase_Matenimiento()
        {
            conectar();
        }
        public void consultar(string sql,string tabla)
        {
            ds.Tables.Clear();
            da = new SqlDataAdapter(sql, cn);
            cmb = new SqlCommandBuilder(da);
            da.Fill(ds,tabla);
        }
        public bool eliminar(string tabla, string condicion)
        {
            cn.Open();
            string sql = "delete from " + tabla + "where" + condicion;
            comando = new SqlCommand(sql, cn);
            int i = comando.ExecuteNonQuery();
            cn.Close();
            if(i> 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool actualizar(string tabla , string campos , string condicion)
        {
            cn.Open();
            string sql = "update " + tabla + "set" + "where" + condicion;
            comando = new SqlCommand(sql, cn);
            int i = comando.ExecuteNonQuery();
            cn.Close();
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public DataTable consultar2(string tabla)
        {
            string sql = "select * from  " + tabla;
            da = new SqlDataAdapter(sql, cn);
            DataSet dts = new DataSet();
            da.Fill(dts, tabla);
            DataTable dt = new DataTable();
            dt = dts.Tables[tabla];
            return dt;
        }
        public bool registrar(string sql)
        { 
            cn.Open();
            comando = new SqlCommand(sql, cn);
            int i = comando.ExecuteNonQuery();
            cn.Close();
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        

    }
}
