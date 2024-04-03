using System;
namespace pb.tp9.Model
{
	public class Aluno
	{
		public int Matricula { get; set; }
		public string Nome { get; set; }
		public List<Turma> Turmas { get; set; }
		
	
        public Aluno(int matricula, string nome)
        {
            Matricula = matricula;
            Nome = nome;
            Turmas = new List<Turma>();
        }

        public string addTurma(Turma turma)
		{
			Turmas.Add(turma);
			return $"Aluno {Nome} adicionado na turma {turma.codigo}";
		}

		public string exibirTurmas()
		{
            if (Turmas.Count == 0)
            {
                return "O aluno não está inscrito em nenhuma turma.";
            }

            string resultado = $"Turmas do aluno {Nome}:\n";
            foreach (var turma in Turmas)
            {
                resultado += $"Código da turma: {turma.codigo}, Disciplina: {turma.disciplina.Nome}\n";
            }
            return resultado;
        }
	}
}

