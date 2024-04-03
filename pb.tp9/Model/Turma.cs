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
		}

		public string addAluno(Aluno aluno) {

			return "";
		}
        public bool abriTurma()
        {
			
			return false;
        }
		public string gerarPauta() {
			return "";
		}
    }
}

