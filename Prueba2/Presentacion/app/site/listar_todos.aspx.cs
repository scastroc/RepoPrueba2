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

        

        protected void Page_Load(object sender, EventArgs e)
        {
            
            
              }

        private void cargarEmpleados()
        {
            empleados = empleadoBusiness.listEmpleado();
        }
        private void refrescarTabla()
        {
            cargarEmpleados();
            tbl_empleados.DataSource = empleados;
            tbl_empleados.DataBind();
            
        }
       

        protected void tbl_empleados_RowEditing(object sender, GridViewEditEventArgs e)
        {
            tbl_empleados.EditIndex = e.NewEditIndex;
            refrescarTabla();
        }

        protected void tbl_empleados_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = (GridViewRow)tbl_empleados.Rows[e.RowIndex];
            string run = row.Cells[0].Text;
            EmpleadoEntity deleteEmpleado = new EmpleadoEntity();
            deleteEmpleado.Run = run;
            empleadoBusiness.delete(deleteEmpleado);
            
            refrescarTabla();
            
        }

        protected void btn_listar_todos_Click(object sender, EventArgs e)
        {
            refrescarTabla();
        }

        protected void tbl_empleados_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow row = (GridViewRow)tbl_empleados.Rows[e.RowIndex];
            string run = row.Cells[0].Text;

            //string tipoEmpleS = e.NewValues[0].ToString();
            string telefono = e.NewValues[0].ToString();
            string remuneracion = e.NewValues[0].ToString();

            EmpleadoEntity updateEmpleado = new EmpleadoEntity();
            //TipoEmpleadoEntity tipoEmpleado = new TipoEmpleadoEntity();
            //tipoEmpleado.Codigo = Int32.Parse(tipoEmpleS);
            //updateEmpleado.TipoEmpleado = tipoEmpleado;
            updateEmpleado.Telefono = Int32.Parse(telefono);
            updateEmpleado.Remuneracion = Int32.Parse(remuneracion);

            empleadoBusiness.update(updateEmpleado);
            tbl_empleados.EditIndex = -1;
            refrescarTabla();
        }

        protected void tbl_empleados_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            tbl_empleados.EditIndex = -1;
            refrescarTabla();
        }
    }
}