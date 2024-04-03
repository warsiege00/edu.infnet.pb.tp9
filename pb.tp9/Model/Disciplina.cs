using System;
namespace pb.tp9.Model
{
	public class Disciplina
	{
		public int Codigo { get; set; }
		public string Nome { get; set; }

		public Disciplina(int codigo, string nome)
		{
			this.Codigo = codigo;
			this.Nome = nome;
		}


	}
}

