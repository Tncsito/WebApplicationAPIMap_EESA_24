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
        ubicaciones_BLL oUbicaciones_BLL;
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
    }
}