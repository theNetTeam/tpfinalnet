using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Entities
{
    public class Usuario : BusinessEntity
    {
        private String _nombreUsuario, _clave, _nombre, _apellido, _email;
        private bool _habilitado;

        public String NombreUsuario
        {
            get { return _nombreUsuario; }
            set { _nombreUsuario = value; }
        }

        public String Clave
        {
            get { return _clave; }
            set { _clave = value; }
        }

        public String Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public String Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }

        public String Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public bool Habilitado
        {
            get { return _habilitado; }
            set { _habilitado = value; }
        }
    }
}
