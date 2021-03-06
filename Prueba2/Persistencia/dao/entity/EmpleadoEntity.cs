﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.dao.entity
{
    public class EmpleadoEntity
    {
        private string nombres;
        private string apellidoPaterno;
        private string apellidoMaterno;
        private string run;
        private TipoEmpleadoEntity tipoEmpleado;
        private int telefono;
        private int remuneracion;
        private DateTime fechaNacimiento;

        public EmpleadoEntity()
        {

        }

        public string Nombres
        {
            get
            {
                return nombres;
            }

            set
            {
                nombres = value;
            }
        }

        public string ApellidoPaterno
        {
            get
            {
                return apellidoPaterno;
            }

            set
            {
                apellidoPaterno = value;
            }
        }

        public string ApellidoMaterno
        {
            get
            {
                return apellidoMaterno;
            }

            set
            {
                apellidoMaterno = value;
            }
        }

        public string Run
        {
            get
            {
                return run;
            }

            set
            {
                run = value;
            }
        }

        public TipoEmpleadoEntity TipoEmpleado
        {
            get
            {
                return tipoEmpleado;
            }

            set
            {
                tipoEmpleado = value;
            }
        }



        public int Telefono
        {
            get
            {
                return telefono;
            }

            set
            {
                telefono = value;
            }
        }

        public int Remuneracion
        {
            get
            {
                return remuneracion;
            }

            set
            {
                remuneracion = value;
            }
        }

        public DateTime FechaNacimiento
        {
            get
            {
                return fechaNacimiento;
            }

            set
            {
                fechaNacimiento = value;
            }
        }


    }
}

