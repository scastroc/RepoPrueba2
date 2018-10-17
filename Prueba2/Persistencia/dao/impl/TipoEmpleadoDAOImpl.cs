using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia.dao.entity;
using Persistencia.NUMEROUNODataSetTableAdapters;

namespace Persistencia.dao.impl
{
    public class TipoEmpleadoDAOImpl : TipoEmpleadoDAO
    {
        private TIPO_EMPLEADOTableAdapter adapter;

        public TipoEmpleadoDAOImpl()
        {
            adapter = new TIPO_EMPLEADOTableAdapter();
        }

        public void create(TipoEmpleadoEntity tipoEmpleado)
        {
            adapter.Insert(tipoEmpleado.Nombre, tipoEmpleado.Codigo);
        }

        public void delete(TipoEmpleadoEntity tipoEmpleado)
        {
            adapter.DeleteByCodigo(tipoEmpleado.Codigo);
        }

        public List<TipoEmpleadoEntity> findAll()
        {
            
            List<TipoEmpleadoEntity> tipos = new
                List<TipoEmpleadoEntity>();

            foreach (NUMEROUNODataSet.TIPO_EMPLEADORow row in 
                adapter.GetData().Rows)
            {
                TipoEmpleadoEntity tipoEmpleado = new TipoEmpleadoEntity();
                tipoEmpleado.Codigo = row.CODIGO;
                tipoEmpleado.Nombre = row.NOMBRE;
                tipos.Add(tipoEmpleado);
            }
            return tipos;
        }

        public TipoEmpleadoEntity findByCodigo(int codigo)
        {           
            
            TipoEmpleadoEntity tipoEmpleado = null;

            foreach (NUMEROUNODataSet.TIPO_EMPLEADORow row in 
                adapter.FindByCodigo(codigo).Rows)
            {
                tipoEmpleado = new TipoEmpleadoEntity();
                tipoEmpleado.Codigo = row.CODIGO;
                tipoEmpleado.Nombre = row.NOMBRE;

            }
            return tipoEmpleado;
        }

        public void update(TipoEmpleadoEntity tipoEmpleado)
        {
            adapter.UpdateByCodigo(tipoEmpleado.Nombre, tipoEmpleado.Codigo);
        }
    }
}
