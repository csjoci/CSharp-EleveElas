

namespace Biblioteca.Domain.Entity
{
    public class Membro
    {
        public string Nome { get; set; } //Deve ter um nome acessível por qualquer pessoa.

        private int ID { get; set; } //Deve ter um ID de membro que só pode ser acessado dentro da classe.

        internal void PegarLivroEmprestado(){ } //Deve haver um método para pegar um livro emprestado acessível apenas dentro do assembly.

        protected void DetalhesDoMembro(){ } //Deve haver um método protegido para obter informações detalhadas sobre o membro.

    }
}
