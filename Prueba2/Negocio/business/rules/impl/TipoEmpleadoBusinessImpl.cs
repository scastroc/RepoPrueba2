using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia.dao;
using Persistencia.dao.entity;
using Persistencia.dao.impl;

namespace Negocio.business.rules.impl
{
    public class TipoEmpleadoBusinessImpl : TipoEmpleadoBusiness
    {
        public static readonly TipoEmpleadoDAO dao =
            new TipoEmpleadoDAOImpl();

        public void create(TipoEmpleadoEntity tipoEmpleado)
        {
            dao.create(tipoEmpleado);
        }

        public void delete(TipoEmpleadoEntity tipoEmpleado)
        {
            dao.delete(tipoEmpleado);
        }

        public List<TipoEmpleadoEntity> listTipoEmp()
        {
            return dao.findAll();
        }

        public void update(TipoEmpleadoEntity tipoEmpleado)
        {
            dao.update(tipoEmpleado);
        }
    }
}
