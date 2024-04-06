using System;
namespace pb.tp9.Model
{
	public class Professor
	{
		public int Matricula { get; set; }
		public string Nome { get; set; }
        public List<Turma> Turmas { get; set; }

        
        public Professor(int matricula, string nome)
        {
            this.Matricula = matricula;
            this.Nome = nome;
            this.Turmas = new List<Turma>();
        }

        public string addTurma(Turma turma)
        {
            this.Turmas.Add(turma);
            return $"Professor {Nome} adicionado na turma {turma.codigo}";
        }

        public string exibirTurmas()
        {
            if (Turmas.Count == 0)
            {
                return "O Professor não está inscrito em nenhuma turma.";
            }

            string resultado = $"Turmas do Professor {Nome}:\n";
            foreach (var turma in Turmas)
            {
                resultado += $"Código da turma: {turma.codigo}, " +
                    $"Disciplina: {turma.disciplina.Nome}, ";
            }
            return resultado;
        }
    }
}

