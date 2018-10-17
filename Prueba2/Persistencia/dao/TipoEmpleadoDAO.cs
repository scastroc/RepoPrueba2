using Persistencia.dao.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.dao
{
    public interface TipoEmpleadoDAO
    {
        void create(TipoEmpleadoEntity tipoEmpleado);

        void update(TipoEmpleadoEntity tipoEmpleado);

        void delete(TipoEmpleadoEntity tipoEmpleado);

        List<TipoEmpleadoEntity> findAll();

        TipoEmpleadoEntity findByCodigo(int codigo);
    }
}
