using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;


namespace DALL
{
    public class ubicacionesDAL
    {
        SQLDBhelpe oConexion;
        public ubicacionesDAL()
        {
            oConexion= new SQLDBhelpe();
        }
        public bool Agregar(ubicaciones_BLL OubicacionesBLL) 
        {
            SqlCommand cmdCommando = new SqlCommand();

            cmdCommando.CommandText = "INSERT INTO Direcciones (Ubicacion, Latitud, Longitud) VALUES (@Ubicacion, @Latitud, @Longitud)";
            cmdCommando.Parameters.Add("@Ubicacion", SqlDbType.VarChar).Value = OubicacionesBLL.Ubicacion;
            cmdCommando.Parameters.Add("@Latitud", SqlDbType.VarChar).Value = OubicacionesBLL.Latitud;
            cmdCommando.Parameters.Add("@Longitud", SqlDbType.VarChar).Value = OubicacionesBLL.Longitud;

            return oConexion.EjecutarComandoSQL(cmdCommando);
        }
        public bool Eliminar(ubicaciones_BLL OubicacionesBLL) 
        {
            SqlCommand cmdCommando = new SqlCommand();

            cmdCommando.CommandText = "DELETE FROM Direcciones (ID) VALUES (@ID)";
            cmdCommando.Parameters.Add("@ID", SqlDbType.VarChar).Value = OubicacionesBLL.ID;

            return oConexion.EjecutarComandoSQL(cmdCommando);
        }
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
