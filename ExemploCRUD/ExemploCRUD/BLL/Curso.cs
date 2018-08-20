using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploCRUD.BLL
{
    class Curso
    {
        private int _cod;

        private string _nome;

        private int _cod_coordenador;

        public int Cod
        {
            get
            {
                return _cod;
            }

            set
            {
                _cod = value;
            }
        }

        public string Nome
        {
            get
            {
                return _nome;
            }

            set
            {
                _nome = value;
            }
        }

        public int Cod_coordenador
        {
            get
            {
                return _cod_coordenador;
            }

            set
            {
                _cod_coordenador = value;
            }
        }
    }
}
