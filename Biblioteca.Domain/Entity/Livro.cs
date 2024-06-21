
namespace Biblioteca.Domain.Entity
{
    public class Livro
    {
        public string TituloLivro { get; set; } //Deve ter um título acessível por qualquer pessoa.

        private protected string Autor { get; set; } //O autor deve ser protegido para ser acessível apenas dentro da classe e suas subclasses.

        internal protected string ISBN { get; set; } //O código ISBN deve ser acessível apenas dentro do assembly.


        public string ResumoDoLivro() //Deve haver um método para obter um resumo do livro que pode ser chamado por qualquer pessoa.
        {
            return "Este é o Resumo Livro.";

        }
    }
}
