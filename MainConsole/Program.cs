
using Biblioteca.Domain.Entity;

Console.WriteLine("Sistema de Biblioteca");
Livro livro = new Livro();
livro.TituloLivro = "Clean Code";
livro.ResumoDoLivro();
//livro.autor?

Membro membro = new Membro();
membro.Nome = "João";
//membro.detalhes?

Funcionario funcionario = new Funcionario();
funcionario.AddNovoFuncionario();

Administrador administrador = new Administrador();  

