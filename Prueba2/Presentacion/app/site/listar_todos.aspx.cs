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
    public partial class listar_todos : System.Web.UI.Page
    {
        private static readonly EmpleadoBusiness empleadoBusiness =
            new EmpleadoBusinessImpl();

        private static readonly TipoEmpleadoBusiness tipoEmpleadoBusiness =
            new TipoEmpleadoBusinessImpl();

        private List<EmpleadoEntity> empleados;

        //private List<TipoEmpleadoEntity> tipos;

        protected void Page_Load(object sender, EventArgs e)
        {
           
            cargaListaEmpleados();
            if (!IsPostBack)
            {
                refrescarTabla();
            }

        }

        private void refrescarTabla()
        {
            tbl_empleados.DataSource = empleados;
            tbl_empleados.DataBind();
        }

        private void cargaListaEmpleados()
        {
            List<EmpleadoEntity> listaEmpleados = empleadoBusiness.listEmpleado();

            if (listaEmpleados == null || listaEmpleados.Count == 0)
            {
                empleados = new List<EmpleadoEntity>();
            }
            else
            {
                empleados = listaEmpleados;

            }
        }

        protected void tbl_empleados_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }

        protected void tbl_empleados_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }
    }
}