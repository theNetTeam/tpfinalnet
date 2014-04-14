using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Entities
{
    public class AlumnoInscripcion : BusinessEntity
    {
        private String _condicion;
        public int _idAlumno, _idCurso, _idNota;

        public String Condicion
        {
            get { return _condicion; }
            set { _condicion = value; }
        }

        public int IdAlumno
        {
            get { return _idAlumno; }
            set { _idAlumno = value; }
        }

        public int IdCurso
        {
            get { return _idCurso; }
            set { _idCurso = value; }
        }

        public int IdNota
        {
            get { return _idNota; }
            set { _idNota = value; }
        }
    }
}
