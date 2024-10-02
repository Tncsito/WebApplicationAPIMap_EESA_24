using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DALL;
using BLL;

namespace CrudUbicaciones_EESA
{
    public partial class frmUbicaciones : System.Web.UI.Page
    {
        ubicacionesDAL oUbicacionesDAL;
        ubicaciones_BLL oUbicacionesBLL;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                ListarUbicaciones();
            }
        }
        public void ListarUbicaciones()
        {
            oUbicacionesDAL= new ubicacionesDAL();
            gvUbicaciones.DataSource = oUbicacionesDAL.Listar();
            gvUbicaciones.DataBind();
        }
        public ubicaciones_BLL datosUbicacion()
        {
            int ID = 0;
            int.TryParse(txtID.Value, out ID);
            oUbicacionesBLL = new ubicaciones_BLL();
            oUbicacionesBLL.ID = ID;
            oUbicacionesBLL.Ubicacion = txtUbicacion.Text;
            oUbicacionesBLL.Latitud = txtLat.Text;
            oUbicacionesBLL.Longitud = txtLong.Text;

            return oUbicacionesBLL;
        }

        protected void AgregarRegistro(object sender, EventArgs e)
        {
            oUbicacionesDAL = new ubicacionesDAL();
            oUbicacionesDAL.Agregar(datosUbicacion());
            ListarUbicaciones();
        }
        protected void EliminarRegistro(object sender, EventArgs e)
        {
            oUbicacionesDAL = new ubicacionesDAL();
            oUbicacionesDAL.Eliminar(datosUbicacion());
            ListarUbicaciones();
        }
        protected void EditarRegistro(object sender, EventArgs e)
        {
            oUbicacionesDAL = new ubicacionesDAL();
            oUbicacionesDAL.Agregar(datosUbicacion());
            ListarUbicaciones();
        }

        protected void gvUbicaciones_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}