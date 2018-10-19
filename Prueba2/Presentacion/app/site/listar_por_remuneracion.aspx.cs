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
    public partial class listar_por_remuneracion : System.Web.UI.Page
    {
        private static readonly EmpleadoBusiness empleadoBusiness =
           new EmpleadoBusinessImpl();

        private static readonly TipoEmpleadoBusiness tipoEmpleadoBusiness =
            new TipoEmpleadoBusinessImpl();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void refrescarTabla(decimal init, decimal end)
        {
            throw new NotImplementedException();
        }

        protected void btn_buscar_Click(object sender, EventArgs e)
        {
            decimal init = Decimal.Parse(txt_remuneracion_init.Text);
            decimal end = Decimal.Parse(txt_remuneracion_end.Text);

            refrescarTabla(init, end);
        }

        
    }
}