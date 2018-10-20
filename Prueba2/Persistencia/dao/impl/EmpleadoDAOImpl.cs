using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia.dao.entity;
using Persistencia.NUMEROUNODataSetTableAdapters;

namespace Persistencia.dao.impl
{
    public class EmpleadoDAOImpl : EmpleadoDAO
    {
        private EMPLEADOTableAdapter adapter;

        public EmpleadoDAOImpl()
        {
            adapter = new EMPLEADOTableAdapter();
        }

        public void create(EmpleadoEntity empleado)
        {
            adapter.Insert(empleado.Run, empleado.Nombres, empleado.ApellidoPaterno, empleado.ApellidoMaterno,
               empleado.TipoEmpleado.Codigo, empleado.Telefono, empleado.Remuneracion, empleado.FechaNacimiento);
        }

        public void delete(EmpleadoEntity empleado)
        {
            adapter.DeleteByRun(empleado.Run);
        //    adapter.Delete(empleado.Run, empleado.Nombres, empleado.ApellidoPaterno, empleado.ApellidoMaterno,
        //       empleado.TipoEmpleado.Codigo, empleado.Telefono, empleado.Remuneracion, empleado.FechaNacimiento);
        }

        public List<EmpleadoEntity> findAll()
        {
            List<EmpleadoEntity> empleados =
                new List<EmpleadoEntity>();

            TipoEmpleadoDAO daoTipo = new TipoEmpleadoDAOImpl();
            List<TipoEmpleadoEntity> tipos = daoTipo.findAll();

            foreach (NUMEROUNODataSet.EMPLEADORow row
                in adapter.GetData().Rows)
            {
                

                EmpleadoEntity empleado = new EmpleadoEntity();
                empleado.Run = row.RUN_DV;
                empleado.Nombres = row.NOMBRES;
                empleado.ApellidoPaterno = row.APELLIDO_PAT;
                empleado.ApellidoMaterno = row.APELLIDO_MAT;                
                empleado.TipoEmpleado = tipos.FirstOrDefault(
                    tipo => tipo.Codigo == row.TIPO_EMPLEADO_ID);                
                empleado.Telefono = Int32.Parse(row.TELEFONO.ToString());
                empleado.Remuneracion = Int32.Parse(row.REMUNERACION_BRUTA.ToString());
                empleado.FechaNacimiento = row.FECHA_NACIMIENTO;

                empleados.Add(empleado);
            }
            {
                return empleados;
            }
        }

        public List<EmpleadoEntity> findByFechaNacimiento(string init, string end)
        {
            List<EmpleadoEntity> empleados =
                new List<EmpleadoEntity>();

            TipoEmpleadoDAO daoTipo = new TipoEmpleadoDAOImpl();
            List<TipoEmpleadoEntity> tipos = daoTipo.findAll();

            foreach (NUMEROUNODataSet.EMPLEADORow row
                in adapter.FindByFechaNacimiento(init, end).Rows)
            {


                EmpleadoEntity empleado = new EmpleadoEntity();
                empleado.Run = row.RUN_DV;
                empleado.Nombres = row.NOMBRES;
                empleado.ApellidoPaterno = row.APELLIDO_PAT;
                empleado.ApellidoMaterno = row.APELLIDO_MAT;
                empleado.TipoEmpleado = tipos.FirstOrDefault(
                    tipo => tipo.Codigo == row.TIPO_EMPLEADO_ID);
                empleado.Telefono = Int32.Parse(row.TELEFONO.ToString());
                empleado.Remuneracion = Int32.Parse(row.REMUNERACION_BRUTA.ToString());
                empleado.FechaNacimiento = row.FECHA_NACIMIENTO;

                empleados.Add(empleado);
            }
            {
                return empleados;
            }
        }

        public List<EmpleadoEntity> findByRemuneracion(int init, int end)
        {
            List<EmpleadoEntity> empleados =
                new List<EmpleadoEntity>();

            TipoEmpleadoDAO daoTipo = new TipoEmpleadoDAOImpl();
            List<TipoEmpleadoEntity> tipos = daoTipo.findAll();

            foreach (NUMEROUNODataSet.EMPLEADORow row
                in adapter.GetByRemuneracion(init, end).Rows)
            {

                EmpleadoEntity empleado = new EmpleadoEntity();
                empleado.Run = row.RUN_DV;
                empleado.Nombres = row.NOMBRES;
                empleado.ApellidoPaterno = row.APELLIDO_PAT;
                empleado.ApellidoMaterno = row.APELLIDO_MAT;
                empleado.TipoEmpleado = tipos.FirstOrDefault(
                    tipo => tipo.Codigo == row.TIPO_EMPLEADO_ID);
                empleado.Telefono = Int32.Parse(row.TELEFONO.ToString());
                empleado.Remuneracion = Int32.Parse(row.REMUNERACION_BRUTA.ToString());
                empleado.FechaNacimiento = row.FECHA_NACIMIENTO;

                empleados.Add(empleado);
            }
            {
                return empleados;
            }
        }

        public List<EmpleadoEntity> listMaxRemu()
        {
            List<EmpleadoEntity> empleados =
                new List<EmpleadoEntity>();

            TipoEmpleadoDAO daoTipo = new TipoEmpleadoDAOImpl();
            List<TipoEmpleadoEntity> tipos = daoTipo.findAll();

            foreach (NUMEROUNODataSet.EMPLEADORow row
                in adapter.GetMaxRemuneracion().Rows)
            {

                EmpleadoEntity empleado = new EmpleadoEntity();
                empleado.Run = row.RUN_DV;
                empleado.Nombres = row.NOMBRES;
                empleado.ApellidoPaterno = row.APELLIDO_PAT;
                empleado.ApellidoMaterno = row.APELLIDO_MAT;
                empleado.TipoEmpleado = tipos.FirstOrDefault(
                    tipo => tipo.Codigo == row.TIPO_EMPLEADO_ID);
                empleado.Telefono = Int32.Parse(row.TELEFONO.ToString());
                empleado.Remuneracion = Int32.Parse(row.REMUNERACION_BRUTA.ToString());
                empleado.FechaNacimiento = row.FECHA_NACIMIENTO;

                empleados.Add(empleado);
            }
            {
                return empleados;
            }

        }

        public void update(EmpleadoEntity empleado)
        {
            adapter.UpdateByRun(empleado.TipoEmpleado.Codigo, empleado.Telefono, empleado.Remuneracion, empleado.Run);
        }
    }
}
