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

        public List<Aluno>  Alunos {  get; set; } = new List<Aluno>();

        public Turma(int Codigo, Disciplina Disciplina)
        {
            this.Codigo = Codigo;
            this.Disciplina = Disciplina;

        }

        public string addAluno(Aluno aluno)
        {
            if(Alunos.Count < 10)
            {
                Alunos.Add(aluno);
                return "Aluno adicionado";

            } else
            {
                return "Turma cheia";
            }
           
        }
        public Boolean abrirTurma()
        {
            if (Alunos.Count <= 10 && Alunos.Count >= 2 ) 
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
