using Negocio.business.rules;
using Negocio.business.rules.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion.app.site
{
    public partial class listar_por_fecha : System.Web.UI.Page
    {
        private static readonly EmpleadoBusiness empleadoBusiness =
           new EmpleadoBusinessImpl();

        private static readonly TipoEmpleadoBusiness tipoEmpleadoBusiness =
            new TipoEmpleadoBusinessImpl();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void refrescarTabla(string init, string end)
        {
            tbl_empleados.DataSource = empleadoBusiness.
                findByFechaNacimiento(init, end);
            tbl_empleados.DataBind();            
        }

        protected void btn_buscar_Click(object sender, EventArgs e)
        {
            string init = txt_fecha_nacimiento_init.Text;
            string end = txt_fecha_nacimiento_end.Text;

            refrescarTabla(init, end);
        }

        
    }
}