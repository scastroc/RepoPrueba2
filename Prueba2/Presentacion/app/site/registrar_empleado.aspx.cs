﻿using Negocio.business.rules;
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
    public partial class registrar_empleado : System.Web.UI.Page
    {
        private static readonly EmpleadoBusiness empleadoBusiness =
            new EmpleadoBusinessImpl();

        private static readonly TipoEmpleadoBusiness tipoEmpleadoBusiness =
            new TipoEmpleadoBusinessImpl();

        private List<TipoEmpleadoEntity> tipos;        

        
        protected void Page_Load(object sender, EventArgs e)
        {
            tipos = tipoEmpleadoBusiness.listTipoEmp();

            if (!IsPostBack)
            {
                cmb_tipo_empleado.DataSource = tipos;
                cmb_tipo_empleado.DataBind();

            }

            
        }


        //private void crearEmpleados()
        //{
        //    List<EmpleadoEntity> listaEmpleados = (List<EmpleadoEntity>)Session["empleados"];

        //    if (listaEmpleados != null)
        //    {
        //        empleados = listaEmpleados;

        //    }
        //    else
        //    {
        //        empleados = new List<EmpleadoEntity>();
        //    }
        //}

        //private void cargarTipoEmpleados()
        //{
        //    TipoEmpleadoEntity jefeTi = new TipoEmpleadoEntity();
        //    jefeTi.Codigo = 1;
        //    jefeTi.Nombre = "Jefe TI";

        //    TipoEmpleadoEntity programador = new TipoEmpleadoEntity();
        //    programador.Codigo = 2;
        //    programador.Nombre = "Programador";

        //    TipoEmpleadoEntity cajera = new TipoEmpleadoEntity();
        //    cajera.Codigo = 3;
        //    cajera.Nombre = "Cajera";

        //    TipoEmpleadoEntity supervisor = new TipoEmpleadoEntity();
        //    supervisor.Codigo = 4;
        //    supervisor.Nombre = "Supervisor";

        //    tipos = new List<TipoEmpleadoEntity>();
        //    tipos.Add(jefeTi);
        //    tipos.Add(programador);
        //    tipos.Add(cajera);
        //    tipos.Add(supervisor);

        //    cmb_tipo_empleado.DataSource = tipos;
        //    cmb_tipo_empleado.DataBind();

        //    Session["tipoEmpleados"] = tipos;
        //}



        protected void btn_registrar_Click(object sender, EventArgs e)
        {
            try
            {
                validar();

                EmpleadoEntity nuevoEmpleado = new EmpleadoEntity();

                nuevoEmpleado.Nombres = txt_nombres.Text;
                nuevoEmpleado.ApellidoPaterno = txt_apellidoPaterno.Text;
                nuevoEmpleado.ApellidoMaterno = txt_apellidoMaterno.Text;
                nuevoEmpleado.Run = txt_run.Text;
                TipoEmpleadoEntity tipoEmpSeleccion = tipos.FirstOrDefault(
                    tipos => tipos.Codigo == Int32.Parse(cmb_tipo_empleado.SelectedValue));
                TipoEmpleadoEntity newTipoEmp = new TipoEmpleadoEntity();
                newTipoEmp.Nombre = tipoEmpSeleccion.Nombre;
                newTipoEmp.Codigo = tipoEmpSeleccion.Codigo;
                nuevoEmpleado.TipoEmpleado = newTipoEmp;                
                nuevoEmpleado.Telefono = Int32.Parse(txt_telefono.Text);
                nuevoEmpleado.Remuneracion = Int32.Parse(txt_remuneracion.Text);
                nuevoEmpleado.FechaNacimiento = DateTime.Parse(txt_fecha_nacimiento.Text);

                empleadoBusiness.create(nuevoEmpleado);

                lbl_mensaje.Text = "Empleado registrado exitosamente.";
                lbl_mensaje.CssClass = "green-mesage";                

            }
            catch (Exception ex)
            {
                lbl_mensaje.Text = ex.Message;
                lbl_mensaje.CssClass = "red-message";
            }


        }

        public void validar()
        {
            string error = "";

            if ("".Equals(txt_nombres.Text))
            {
                error = error + "<p>- Debe ingresar información en campo Nombres </p>";
            }
            else if (txt_nombres.Text.Length > 60)
            {
                error = error + "<p>- Nombres debe tener máximo 60 caracteres</p>";
            }

            if ("".Equals(txt_apellidoPaterno.Text))
            {
                error = error + "<p>- Debe ingresar un Apellido Paterno </p>";
            }
            else if (txt_apellidoPaterno.Text.Length > 60)
            {
                error = error + "<p>- Apellido Paterno debe tener máximo 60 caracteres</p>";
            }

            if ("".Equals(txt_apellidoMaterno.Text))
            {
                error = error + "<p>- Debe ingresar un Apellido Materno </p>";
            }
            else if (txt_apellidoMaterno.Text.Length > 60)
            {
                error = error + "<p>- Apellido Materno debe tener máximo 60 caracteres</p>";
            }

            if (txt_telefono.Text.Length < 9)
            {

                error = error + "<p>- Debe ingresar al menos 9 caracteres </p>";
            }

            if ("".Equals(txt_fecha_nacimiento.Text))
            {

                error = error + "<p>- Debe ingresar información en campo Fecha </p>";
            }
            else if (DateTime.Parse("01-01-2000").CompareTo(DateTime.Parse(txt_fecha_nacimiento.Text)) < 0)
            //else if (DateTime.Today.CompareTo(DateTime.Parse(txt_fecha_nacimiento.Text)) < 0)
            {
                error = error + "<p>- El nuevo empleado debe ser mayor de edad</p>";
            }

            if (!"".Equals(error))
            {
                throw new Exception(error);
            }
        }
    }

}

