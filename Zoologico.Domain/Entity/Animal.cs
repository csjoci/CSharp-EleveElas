
namespace Zoologico.Domain.Entity
{
    public abstract class Animal
    {
        public string NomeDoAnimal {get;set;}
        public int Peso { get;set;}
        public string RegiaoOrigem { get; set; }
        public abstract void DescreverAnimal();

    }
}
