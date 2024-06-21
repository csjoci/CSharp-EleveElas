

namespace BibliotecaConsole.Domain.Entity
{
    public class Administrador
    {
        private int ID { get; set; } //Deve ter um ID de administrador acessível apenas dentro da classe.

        internal void GerenciarLib() { } //Deve haver um método para gerenciar a biblioteca acessível apenas dentro do assembly.

        protected void DetalhesDoADM(){ } //Deve haver um método protegido para obter informações detalhadas sobre o administrador.

        public Administrador()
        {
            ID = 1;
            DetalhesDoADM();

        }
    }
}
