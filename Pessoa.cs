using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinCadastroPROFAlun
{
    class Pessoa
    {
        private string nome;
        private int ano;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public int Ano
        {
            get { return ano; }
            set { ano = value; }
        }

        virtual public string MostraPessoa()
        {
            return "Nome: "+Nome+ "\nPeriodo: " + Ano.ToString();
        }
    }
}
