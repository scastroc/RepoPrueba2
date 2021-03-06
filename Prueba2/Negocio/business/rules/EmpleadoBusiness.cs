﻿using Persistencia.dao.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.business.rules
{
    public interface EmpleadoBusiness
    {
        void create(EmpleadoEntity empleado);

        void update(EmpleadoEntity empleado);

        void delete(EmpleadoEntity empleado);

        List<EmpleadoEntity> listEmpleado();

        List<EmpleadoEntity> findByFechaNacimiento(string init, string end);

        List<EmpleadoEntity> findByRemuneracion(int init, int end);

        List<EmpleadoEntity> listMaxRemu();
    }
}
