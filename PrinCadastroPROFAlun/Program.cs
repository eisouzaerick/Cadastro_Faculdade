using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinCadastroPROFAlun
{
    class Program
    {
        static void Main(string[] args)
        {
            cadastro();
            Console.ReadKey();
        }

        static void cadastro()
        {
            try
            {
                List<Professor> P = new List<Professor>();
                List<Aluno> A = new List<Aluno>();

                Professor Prof = null;
                Aluno Alu = null;
                bool aux = false;
                int op = 0;
                do
                {
                    Console.Clear();

                    Console.WriteLine("1.Cadastrar Professor");
                    Console.WriteLine("2.Cadastrar Aluno ");
                    Console.WriteLine("3.Associar Alunos ao Professor");
                    Console.WriteLine("4.Listar Alunos por Professor");
                    Console.WriteLine("5.Sair");
                    Console.WriteLine();
                    Console.Write("Sua opção: ");
                    op = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    switch (op)
                    {

                        case 1:
                            Prof = new Professor();
                            Console.WriteLine("Cadastrando Professor...");
                            Console.Write("Nome: ");
                            Prof.Nome = Console.ReadLine().ToUpper();
                            Console.Write("Graduação: ");
                            Prof.Graduação = Console.ReadLine().ToUpper();
                            Console.Write("Professor Cadastrado!");
                            P.Add(Prof);
                            Console.ReadKey();
                            break;
                        case 2:
                            Alu = new Aluno();
                            Console.WriteLine("Cadastrar Aluno...");
                            Console.Write("Nome: ");
                            Alu.Nome = Console.ReadLine().ToUpper();

                            Console.Write("Periodo: ");
                            Alu.Ano = int.Parse(Console.ReadLine());

                            Console.Write("Matricula: ");
                            Alu.Matricula = int.Parse(Console.ReadLine());

                            Console.Write("Aluno Cadastrado!");

                            A.Add(Alu);
                            Console.ReadKey();
                            break;
                        case 3:
                            Console.Write("Informe o Aluno: ");
                            string nome_auxP = Console.ReadLine().ToUpper();

                            foreach (Aluno itemA in A)
                            {
                                if (itemA.Nome == nome_auxP)
                                {

                                    Console.Write("Informe o Professor: ");
                                    string nome_auxM = Console.ReadLine().ToUpper();

                                    foreach (Professor itemM in P)
                                    {
                                        if (itemM.Nome == nome_auxM)
                                        {
                                            itemM.AddAlunos(itemA);
                                            Console.WriteLine("Aluno " + itemA.Nome + " associado ao Professor " + itemM.Nome);
                                            aux = true;
                                        }
                                    }
                                }
                            }
                            if (aux == false)
                            {
                                Console.WriteLine("Cadastro nao realizado!!!");
                                Console.ReadLine();
                            }

                            Console.ReadKey();
                            break;
                        case 4:

                            foreach (Professor prof in P)
                            {
                                Console.WriteLine("\nProfessor: " + prof.Nome + "\nGraduação: " + prof.Graduação + "\n\nAlunos:");
                                foreach (Aluno a in prof.Alunos)
                                {
                                    Console.WriteLine(a.MostraPessoa());
                                }
                            }
                            Console.ReadKey();
                            break;
                    }

                } while (op != 5);
            }
            catch (FormatException)
            {
                Console.WriteLine("Entrada de dados invalidos");
                Console.ReadKey();
                Console.Clear();
                cadastro();
            }
        }
    }
}
