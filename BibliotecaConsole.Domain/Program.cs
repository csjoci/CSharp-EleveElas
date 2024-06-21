
using BibliotecaConsole.Domain.Entity;

Console.WriteLine("Hello, World! From Lib!");

Console.WriteLine("Sistema de Biblioteca");
Livro livro = new Livro();
livro.TituloLivro = "Clean Code";
livro.ResumoDoLivro();
livro.ISBN = "ISBN";


Membro membro = new Membro();
membro.Nome = "João";
membro.PegarLivroEmprestado();


Funcionario funcionario = new Funcionario();
funcionario.AddNovoFuncionario();
funcionario.AddLivroBiblioteca();
//funcionario.RemoverLivroBiblioteca();?


Administrador administrador = new Administrador();
administrador.GerenciarLib();
Adm adm = new Adm();    


