using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemAcademico
{
    internal class Turma
    {
        public int Codigo { get; set; }

        public Disciplina Disciplina { get; set; }

        public Professor Professor { get; set; }

        public List<Aluno> Alunos;

        public Turma(int Codigo, Disciplina Disciplina, Professor professor)
        {
            this.Codigo = Codigo;
            this.Disciplina = Disciplina;
            Professor = professor;
            Alunos = new List<Aluno>();
        }

        public string addAluno(Aluno aluno)
        {
            if(Alunos.Count < 10)
            {
                Alunos.Add(aluno);
                aluno.AddTurma(this);

                return "Aluno adicionado";

            } else
            {
                return "Turma cheia";
            }
           
        }
        public Boolean abrirTurma()
        {
            int numeroAlunos = Alunos.Count;
            if (numeroAlunos >= 2 && numeroAlunos <= 10 ) 
            { 
                return true;
            
            } else
            {
                return false;
            }
        }

        public string gerarPauta()
        {
            if (abrirTurma() == true)
            {
                string pauta = $"Código da turma: {Codigo}\n";
                pauta += $"Disciplina: {Disciplina.Nome}\n";

                pauta += ("Lista de alunos:\n");
                foreach (var aluno in Alunos)
                {
                    pauta += $"{aluno.Nome}\n";
                }

                return pauta;

            } else
            {
                return "Nenhuma turma aberta";
            }
            
           
        }
    }
}
