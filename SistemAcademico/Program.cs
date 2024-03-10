namespace SistemAcademico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Criando um professor
            Professor professor = new Professor(1, "João Silva");

            // Criando disciplinas
            Disciplina matematica = new Disciplina(101, "Matemática");
          
            // Criando uma turma 
            Turma turma = new Turma(10, matematica);
            int op;

            do
            {
                Console.WriteLine("\nSelecionar uma opção:");

                Console.WriteLine("1. Adicionar Aluno");
                Console.WriteLine("2. Abrir turma");
                Console.WriteLine("3. Gerar pauta");
                Console.WriteLine("0. Sair");
                 op =  int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.WriteLine("Digite o nome do aluno: ");
                        string nomeAluno = Console.ReadLine();

                        Console.WriteLine("Digite a matricula do aluno: ");
                        int matriculaAluno = int.Parse(Console.ReadLine());

                        Aluno aluno1 = new Aluno(matriculaAluno, nomeAluno);

                        Console.Write(turma.addAluno(aluno1));

                         
                        break;

                    case 2:
                        Console.WriteLine(turma.abrirTurma());

                        break;

                    case 3:
                        Console.WriteLine(turma.gerarPauta());

                       break;

                    default: 
                        Console.WriteLine("Sistema encerrado");
                        break;
                } 
            } while(op != 0);
        }
    }
}
