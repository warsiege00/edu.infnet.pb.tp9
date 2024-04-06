using System;
namespace pb.tp9.Model
{
	public class Turma
	{
		public int codigo { get; set; }
		public List<Aluno> alunos {get; set;}
        public Disciplina  disciplina { get; set; }
        public Professor professor { get; set; }

		public Turma(int codigo, Disciplina disciplina, Professor professor)
		{
			
			this.codigo = codigo;
			this.disciplina = disciplina;
			this.professor = professor;
			this.alunos = new List<Aluno>();
		}

		public string addAluno(Aluno aluno)
		{
			alunos.Add(aluno);
			return "";
		}
        public bool abriTurma()
        {
			return true;
        }

		public string gerarPauta() {
			return "";
		}

		public string addProfessor(Professor professor)
		{
			this.professor = professor;
			return $"Professor {professor.Nome} adicionado a turma.";
		}
        public string addDisciplina(Disciplina disciplina)
        {
            this.disciplina = disciplina;
            return $"Professor {professor.Nome} adicionado a turma.";
        }
    }
}

