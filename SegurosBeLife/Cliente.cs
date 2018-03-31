using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegurosBeLife
{
   public class Cliente
    {
        private String _rut;
        private String _nombre;
        private String _apellidos;
        private DateTime _fechaNaci;
        private Char _sexo;
        private Char _estado;

        public string Rut
        {
            get
            {
                return _rut;
            }

            set
            {
                _rut = value;
            }
        }

        public string Nombre
        {
            get
            {
                return _nombre;
            }

            set
            {
                _nombre = value;
            }
        }

        public string Apellidos
        {
            get
            {
                return _apellidos;
            }

            set
            {
                _apellidos = value;
            }
        }

        public DateTime FechaNaci
        {
            get
            {
                return _fechaNaci;
            }

            set
            {
                _fechaNaci = value;
            }
        }

        public char Sexo
        {
            get
            {
                return _sexo;
            }

            set
            {
                _sexo = value;
            }
        }

        public char Estado
        {
            get
            {
                return _estado;
            }

            set
            {
                _estado = value;
            }
        }

        public Cliente()
        {

        }


    }
}
