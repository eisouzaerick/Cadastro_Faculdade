using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinCadastroPROFAlun
{
    class Aluno: Pessoa
    {
        private int matricula;

        public int Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }

        override public string MostraPessoa()
        {
            string aux = "";
            aux = base.MostraPessoa() + "\nMatricula: " + matricula.ToString() + "\n____________";

            return aux;
        }
    }
}
