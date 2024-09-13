using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ejemploprocedimientolenguaje
{
    public class ManipulaBD
    {
        public SqlConnection cn;
        SqlCommand cm;
        string cadena, proc, param,sql;
        public DataSet dt;
        SqlDataAdapter da;
        /*Método para conectarse con la Base de Datos SQL SERVER*/
        public void ConectarBD2()
        {
                cadena = "Data Source=DESKTOP-6GL2VM1;Initial Catalog=sweet_fragrance;Integrated Security=True";
                cn = new SqlConnection(cadena);
                cn.Open();
        }
        /*Mëtodo para manipular la Base de Datos, es decir poder Insertar, Modificar, y Eliminar*/
        public void ManipularBD(string proc,string param)
        {
            ConectarBD2();
            sql="" + proc + " " + param + "";
            cm = new SqlCommand(sql, cn);
            cm.ExecuteNonQuery();
        }
        /*Metodo para consultar información a la base de datos*/
        public void ConsultarBD(string proc,string param) 
        {
            ConectarBD2();
            sql = "" + proc + " " + param + "";
            dt=new DataSet();
            da = new SqlDataAdapter(sql, cn);
            da.Fill(dt, "objeto1");
        }
    }
}
