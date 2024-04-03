using pb.tp9.Model;

Disciplina disciplina = new Disciplina(1, "Matematica");
Professor professor = new Professor(1, "Jorge");
Turma turma = new Turma(1, disciplina, professor);

//Caso nenhuma turma
Aluno aluno = new Aluno(1, "Matheus");
Console.WriteLine(aluno.exibirTurmas());


//Caso 1 turma
aluno.addTurma(turma);
Console.WriteLine(aluno.exibirTurmas());
Console.ReadKey();
