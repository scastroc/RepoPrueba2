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

        public List<EmpleadoEntity> findByFechaNacimiento(string init, string end)
        {
            return dao.findByFechaNacimiento(init, end);
        }

        public List<EmpleadoEntity> findByRemuneracion(int init, int end)
        {
            return dao.findByRemuneracion(init, end);
        }

        public List<EmpleadoEntity> listEmpleado()
        {
            return dao.findAll();
        }

        public List<EmpleadoEntity> listMaxRemu()
        {
            return dao.listMaxRemu();
        }

        public void update(EmpleadoEntity empleado)
        {
            dao.update(empleado);
        }
    }
}
