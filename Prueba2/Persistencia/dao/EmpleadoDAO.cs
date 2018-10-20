using Persistencia.dao.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.dao
{
    public interface EmpleadoDAO
    {
        void create(EmpleadoEntity empleado);

        void update(EmpleadoEntity empleado);

        void delete(EmpleadoEntity empleado);        

        List<EmpleadoEntity> findAll();

        List<EmpleadoEntity> findByFechaNacimiento(string init, string end);

        List<EmpleadoEntity> findByRemuneracion(int init, int end);

        List<EmpleadoEntity> listMaxRemu();

    }
}
