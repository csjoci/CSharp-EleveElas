

namespace Biblioteca.Domain.Entity
{
    public class Funcionario
    {
        private protected int ID { get; set; } //Deve ter um ID de funcionário acessível dentro do assembly e em subclasses.

        protected internal void AddLivroBiblioteca() { } //Deve haver um método para adicionar um livro à biblioteca, acessível apenas dentro da classe e suas subclasses.

        private protected void RemoverLivroBiblioteca() { } //Deve haver um método para remover um livro da biblioteca, acessível apenas dentro da classe e suas subclasses dentro do mesmo assembly.

        public void AddNovoFuncionario() { } //Deve haver um método público para registrar um novo funcionário.

    }
}
