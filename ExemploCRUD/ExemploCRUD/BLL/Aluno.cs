using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploCRUD.BLL
{
    class Aluno
    {
        private string _ra;

        private string _nome;

        private string _cpf;

        private int _idade;

        public string Ra
        {
            get
            {
                return _ra;
            }

            set
            {
                _ra = value;
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

        public string Cpf
        {
            get
            {
                return _cpf;
            }

            set
            {
                _cpf = value;
            }
        }

        public int Idade
        {
            get
            {
                return _idade;
            }

            set
            {
                _idade = value;
            }
        }
    }
}
