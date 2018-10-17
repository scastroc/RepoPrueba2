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
    public class EmpleadoBusinessImpl : EmpleadoBusiness
    {
        public static readonly EmpleadoDAO dao =
            new EmpleadoDAOImpl();

        public void create(EmpleadoEntity empleado)
        {
            dao.create(empleado);
        }

        public void delete(EmpleadoEntity empleado)
        {
            dao.delete(empleado);
        }

        public List<EmpleadoEntity> listEmpleado()
        {
            return dao.findAll();
        }

        public void update(EmpleadoEntity empleado)
        {
            dao.update(empleado);
        }
    }
}
