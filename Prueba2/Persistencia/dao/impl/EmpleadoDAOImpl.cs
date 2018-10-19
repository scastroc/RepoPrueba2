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
            adapter.Delete(empleado.Run, empleado.Nombres, empleado.ApellidoPaterno, empleado.ApellidoMaterno,
               empleado.TipoEmpleado.Codigo, empleado.Telefono, empleado.Remuneracion, empleado.FechaNacimiento);
        }

        public List<EmpleadoEntity> findAll()
        {
            List<EmpleadoEntity> empleados =
                new List<EmpleadoEntity>();

            TipoEmpleadoDAO daoTipo = new TipoEmpleadoDAOImpl();

            foreach (NUMEROUNODataSet.EMPLEADORow row
                in adapter.GetData().Rows)
            {
                

                EmpleadoEntity empleado = new EmpleadoEntity();
                empleado.Run = row.RUN_DV;
                empleado.Nombres = row.NOMBRES;
                empleado.ApellidoPaterno = row.APELLIDO_PAT;
                empleado.ApellidoMaterno = row.APELLIDO_MAT;
                TipoEmpleadoEntity tipoEmp = new TipoEmpleadoEntity();
                tipoEmp.Codigo = row.TIPO_EMPLEADO_ID;
                empleado.TipoEmpleado = tipoEmp;
                empleado.Telefono = Int32.Parse(row.TELEFONO.ToString());
                empleado.Remuneracion = Int32.Parse(row.REMUNERACION_BRUTA.ToString());
                empleado.FechaNacimiento = row.FECHA_NACIMIENTO;

            }
            {
                return empleados;
            }
        }

            public void update(EmpleadoEntity empleado)
        {
            adapter.UpdateByRun(empleado.Run, empleado.Nombres, empleado.ApellidoPaterno, empleado.ApellidoMaterno,
               empleado.TipoEmpleado.Codigo, empleado.Telefono, empleado.Remuneracion, empleado.FechaNacimiento.ToString(), empleado.Run);
        }
    }
}
