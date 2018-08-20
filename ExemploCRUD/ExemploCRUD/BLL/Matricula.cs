using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploCRUD.BLL
{
    class Matricula
    {
        private int _cod_curso;

        private int _ra_aluno;

        private DateTime _data_matricula;

        public int Cod_curso
        {
            get
            {
                return _cod_curso;
            }

            set
            {
                _cod_curso = value;
            }
        }

        public int Ra_aluno
        {
            get
            {
                return _ra_aluno;
            }

            set
            {
                _ra_aluno = value;
            }
        }

        public DateTime Data_matricula
        {
            get
            {
                return _data_matricula;
            }

            set
            {
                _data_matricula = value;
            }
        }
    }
}
