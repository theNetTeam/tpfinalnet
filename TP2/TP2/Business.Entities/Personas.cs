using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Entities
{
    public class Personas : BusinessEntity
    {
        private String _apellido, _direccion, _email, _nombre, _telefono;
        private int _idPlan, _legajo;
        private DateTime _fechaNacimiento;
        private TiposPersonas _tipoPersona;

        public String Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }

        public String Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }

        public String Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public String Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public String Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }

        public int IdPlan
        {
            get { return _idPlan; }
            set { _idPlan = value; }
        }

        public int Legajo
        {
            get { return _legajo; }
            set { _legajo = value; }
        }

        public DateTime FechaNacimiento
        {
            get { return _fechaNacimiento; }
            set { _fechaNacimiento = value; }
        }

        public TiposPersonas TipoPersona
        {
            get { return _tipoPersona; }
            set { _tipoPersona = value; }
        }

        public enum TiposPersonas
        {
            Administrador,
            Profesor,
            Alumno
        }
    }
}
