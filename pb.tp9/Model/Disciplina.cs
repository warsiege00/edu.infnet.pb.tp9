using System;
namespace pb.tp9.Model
{
	public class Disciplina
	{
		public int Codigo { get; set; }
		public string Nome { get; set; }
		public List<Turma> Turmas { get; set; }

		public Disciplina(int codigo, string nome)
		{
			this.Codigo = codigo;
			this.Nome = nome;
			this.Turmas = new List<Turma>();
		}

        public string addTurma(Turma turma)
        {
            this.Turmas.Add(turma);
            return $"Disciplina {Nome} adicionado na turma {turma.codigo}";
        }

        public string exibirTurmas()
        {
            if (Turmas.Count == 0)
            {
                return "A didsciplina não está inscrita em nenhuma turma.";
            }

            string resultado = $"Turmas relacionadas a Disciplina {Nome}:\n";
            foreach (var turma in Turmas)
            {
                resultado += $"Código da turma: {turma.codigo}, " +
                    $"Professor: {turma.professor.Nome}, ";
            }
            return resultado;
        }

    }
}

