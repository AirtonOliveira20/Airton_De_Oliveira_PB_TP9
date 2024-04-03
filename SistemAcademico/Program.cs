using System.Security.Cryptography.X509Certificates;

namespace SistemAcademico
{
    internal class Program
    {
        static List<Turma> Turmas = new List<Turma>();
        static List<Aluno> Alunos = new List<Aluno>();
        static void Main(string[] args)
        {
           
            int op;

            do
            {
                Console.WriteLine("\nSelecionar uma opção:");

                Console.WriteLine("1. Adicionar Aluno");
                Console.WriteLine("2. Abrir turma");
                Console.WriteLine("3. Gerar pauta");
                Console.WriteLine("4. Criar turma");
                Console.WriteLine("5. Criar aluno");
                Console.WriteLine("6. Exibir turmas");
                Console.WriteLine("0. Sair");
                 op =  int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        AdicionarAluno();
                        break;

                    case 2:
                        AbrirTurma();                        

                        break;

                    case 3:
                        GerarPauta();

                       break;

                    case 4:
                        CriarTurma();

                        break;

                    case 5:
                        CriarAluno();

                        break;

                    case 6:
                        ExibirTurmas();

                        break;


                    default: 
                        Console.WriteLine("Sistema encerrado");
                        break;
                } 
            } while(op != 0);
        }

        public static void AdicionarAluno()
        {
            Console.WriteLine("Deseja adicionar qual aluno? ");
            int matricula = int.Parse(Console.ReadLine());

            foreach (Aluno alunos in Alunos)
            {
                if (alunos.Matricula == matricula)
                {
                    Console.WriteLine("Digite o codigo da turma: ");
                    int codigoTurma = int.Parse(Console.ReadLine());

                    foreach (Turma t in Turmas)
                    {
                        if (t.Codigo == codigoTurma)
                        {
                            Console.Write(t.addAluno(alunos));
                        }

                    }

                }

            }
            
        }

        public static void CriarTurma()
        {
            Console.WriteLine("Digite a matricula do professor ");
            int matricula = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome do professor: ");
            string nomeProfessor = Console.ReadLine();

            Professor professor = new Professor(matricula, nomeProfessor);

            Console.WriteLine("Digite o nome da disciplina:");
            string nomeDisciplina = Console.ReadLine();

            Console.WriteLine("Digite o código da disciplina: ");
            int codDisciplina = int.Parse(Console.ReadLine());

            Disciplina disciplina = new Disciplina(codDisciplina, nomeDisciplina);

            Console.WriteLine("Digite o código da turma: ");
            int codTurma = int.Parse(Console.ReadLine());

            Turma turma = new Turma(codTurma, disciplina, professor);

            Turmas.Add(turma);

            Console.WriteLine("Turma criada");

        }

        public static void CriarAluno()
        {
            Console.WriteLine("Digite o nome do aluno: ");
            string nomeAluno = Console.ReadLine();

            Console.WriteLine("Digite a matricula do aluno: ");
            int matriculaAluno = int.Parse(Console.ReadLine());

            Aluno aluno1 = new Aluno(matriculaAluno, nomeAluno);

            Alunos.Add(aluno1);


        }

        public static void AbrirTurma()
        {
            Console.WriteLine("Digite o código da turma ");
            int codTurma = int.Parse(Console.ReadLine());

            foreach (Turma t in Turmas)
            {
                if (t.Codigo == codTurma)
                {
                    if (t.abrirTurma())
                    {
                        Console.WriteLine("Turma aberta");
                    } else
                    {
                        Console.WriteLine("Turma não pode ser aberta");
                    }
                }
            }


        }

        public static void GerarPauta()
        {
            Console.WriteLine(Turmas[0].gerarPauta());
        }

        public static void ExibirTurmas()
        {
            Console.WriteLine("Digite a matricula do aluno: ");
            int matriculaAluno = int.Parse(Console.ReadLine());

            foreach (Aluno alunos in Alunos)
            {
                if (alunos.Matricula == matriculaAluno)
                {
                    alunos.ExibirTurmas();
                }
            }
        }

    }
}
