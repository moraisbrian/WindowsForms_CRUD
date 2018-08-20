using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploCRUD.BLL
{
    class Coordenador
    {
        private int _cod;

        private string _nome;

        private int _idade;

        private double _salario;

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

        public double Salario
        {
            get
            {
                return _salario;
            }

            set
            {
                _salario = value;
            }
        }
    }
}
