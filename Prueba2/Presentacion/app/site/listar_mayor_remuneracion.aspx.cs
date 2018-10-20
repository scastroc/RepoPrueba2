using Negocio.business.rules;
using Negocio.business.rules.impl;
using Persistencia.dao.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion.app.site
{
    public partial class listar_mayor_remuneracion : System.Web.UI.Page
    {
        private static readonly EmpleadoBusiness empleadoBusiness =
            new EmpleadoBusinessImpl();

        private static readonly TipoEmpleadoBusiness tipoEmpleadoBusiness =
            new TipoEmpleadoBusinessImpl();

        private List<EmpleadoEntity> empleados;

        protected void Page_Load(object sender, EventArgs e)
        {
            refrescarTabla();
        }

        
        private void refrescarTabla()
        {
            
            tbl_empleados.DataSource = empleadoBusiness.listMaxRemu();
            tbl_empleados.DataBind();

        }


    }
}