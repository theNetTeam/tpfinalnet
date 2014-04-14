using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Entities
{
    public class DocenteCurso : BusinessEntity
    {
        private int _idCurso, _idDocente;
        private TiposCargos _cargo;

        public int IdCurso
        {
            get { return _idCurso; }
            set { _idCurso = value; }
        }

        public int IdDocente
        {
            get { return _idDocente; }
            set { _idDocente = value; }
        }

        public TiposCargos Cargo
        {
            get { return _cargo; }
            set { _cargo = value; }
        }

        public enum TiposCargos
        {
            Titular,
            Auxiliar
        }
    }
}
