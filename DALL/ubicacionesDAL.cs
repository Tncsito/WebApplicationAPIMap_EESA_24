using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DALL
{
    public class ubicacionesDAL
    {
        SQLDBhelpe oConexion;
        public ubicacionesDAL()
        {
            oConexion= new SQLDBhelpe();
        }
        public void Agregar() { }
        public void Eliminar() { }
        public void Modificar() { }
        public DataTable Listar() 
        {
            SqlCommand cmdComando = new SqlCommand();
            cmdComando.CommandText = "SELECT * FROM Direcciones";
            cmdComando.CommandType = CommandType.Text;
            DataTable TablaResultante = oConexion.EjecutarSentenciaSQL(cmdComando);
            return TablaResultante;
        }

    }
}
