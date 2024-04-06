using pb.tp9.Model;

Disciplina disciplina = new Disciplina(1, "Matematica");
Professor professor = new Professor(1, "Jorge");
Turma turma = new Turma(1, disciplina, professor);

//Caso nenhuma turma
Console.WriteLine("---Caso nenhuma Turma---");
Aluno aluno = new Aluno(1, "Matheus");
Console.WriteLine(aluno.exibirTurmas());


//Caso 1 turma
Console.WriteLine("---Caso 1 Turma---");
aluno.addTurma(turma);
Console.WriteLine(aluno.exibirTurmas());


//Caso varias turmas
Console.WriteLine("---Caso Varias Turmas---");
Disciplina d2 = new Disciplina(2, "Física");
Professor p2 = new Professor(2, "Luiz");
Turma t2 = new Turma(2, d2, p2);
Disciplina d3 = new Disciplina(3, "Química");
Professor p3 = new Professor(3, "Maria");
Turma t3 = new Turma(3, d3, p3);

aluno.addTurma(t2);
aluno.addTurma(t3);

Console.WriteLine(aluno.exibirTurmas());


Console.ReadKey();