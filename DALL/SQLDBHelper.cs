using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALL
{
    public class SQLDBHelper
    {
        DataTable Tabla;
        SqlConnection strConexion = new SqlConnection("Data Source=Local;Initial Catalog=BDUbicaciones;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();

        public bool EjecutarComandoSQL(SqlCommand strSQLCommand)
        {
            //INSERTAR, MODIFICAR, BORRAR

            bool Respuesta = true;

            cmd = strSQLCommand;
            cmd.Connection= strConexion;
            strConexion.Open();
            Respuesta = (cmd.ExecuteNonQuery() <= 0) ? false : true;
            strConexion.Close();
            return Respuesta;
        }
        public DataTable EjecutarSentenciaSQL(SqlCommand strSQLCommand)
        {
            cmd = strSQLCommand;
            cmd.Connection = strConexion;
            strConexion.Open();
            Tabla = new DataTable();
            Tabla.Load(cmd.ExecuteReader());
            strConexion.Close();
            return Tabla;
        }
    }
}
