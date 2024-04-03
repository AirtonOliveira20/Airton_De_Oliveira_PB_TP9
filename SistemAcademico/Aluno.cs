using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemAcademico
{
    internal class Aluno
    {
        public int Matricula {  get; set; }
        public string Nome { get; set; }

        public List<Turma> Turmas = new List<Turma>();

        public Aluno(int matricula, string nome)
        {
            Matricula = matricula;
            Nome = nome;
        }

        public String AddTurma(Turma turma)
        {
            Turmas.Add(turma);

            return "Turma adicionada no aluno";

        }

        public void ExibirTurmas()
        {
            Console.WriteLine($"Turmas do(a) aluno(a) {Nome}:");
            foreach (Turma turma in Turmas)
            {
                Console.WriteLine($" - {turma.Codigo}");
            }
        }

    }
}
