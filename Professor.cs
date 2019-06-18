using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinCadastroPROFAlun
{
    class Professor: Pessoa
    {
        private string graduação;
        private List<Aluno> aluno;

        public string Graduação
        {
            get { return graduação; }
            set { graduação = value; }
        }

        public Professor()
        {
            Alunos = new List<Aluno>();
        }

        public List<Aluno> Alunos
        {
            get { return aluno; }
            set { aluno = value; }
        }

        public void AddAlunos(Aluno A)
        {
            Alunos.Add(A);
        }

        override public string MostraPessoa()
        {
            string aux = "";
            aux = base.MostraPessoa() + "\nGraduação: " + graduação;

            return aux;
        }
    }
}
