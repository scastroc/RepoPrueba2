﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.dao.entity
{
    public class TipoEmpleadoEntity
    {
        private int codigo;
        private string nombre;

        public TipoEmpleadoEntity()
        {

        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }


        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

    }
}
