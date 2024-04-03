using System;
namespace pb.tp9.Model
{
	public class Professor
	{
		public int Matricula { get; set; }
		public string Nome { get; set; }


        public Professor(int matricula, string nome)
        {
            this.Matricula = matricula;
            this.Nome = nome;
        }
    }
}

