
namespace Exercicio_19_06
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public string Description { get; set; }

    }

    public interface Voar
    {
        public void LevantarVoo();
        public void Pousar();

    }

    public interface Nadar
    {
        public int LimiteProfundidade { get; set; }
        public void Subir(int metros);
        public void Descer(int metros);

    }
    public class Anfibio : Animal, Nadar
    {
        public int LimiteProfundidade { get => 500; set => throw new NotImplementedException(); }

        public void Descer(int metros)
        {
            Console.WriteLine("Para descer " + metros + " O Anfibio usa suas 4 patas. Com um limite de Profundidade: " + LimiteProfundidade);
        }

        public void Subir(int metros)
        {
            Console.WriteLine("Para subir " + metros + " O Anfibio usa suas 4 patas. Com um limite de Profundidade: " + LimiteProfundidade);
        }


    }
    public class Mamifero : Animal, Nadar
    {
        public int LimiteProfundidade { get => 100; set => throw new NotImplementedException(); }

        public void Descer(int metros)
        {
            Console.WriteLine("Para descer " + metros + " O Mamifero usa suas 4 patas. Com um limite de Profundidade: " + LimiteProfundidade);
        }

        public void Subir(int metros)
        {
            Console.WriteLine("Para subir " + metros + " O Mamifero usa suas 4 patas. Com um limite de Profundidade: " + LimiteProfundidade);
        }
    }
    public class Aves : Animal, Voar
    {
        public void LevantarVoo()
        {
            Console.WriteLine("Para Levantar Voo a ave precisa das duas asas");
        }

        public void Pousar()
        {
            Console.WriteLine("Para Pousar a ave precisa das duas asas e suas 2 patinhas");
        }
    }
    public class Peixes : Animal, Nadar
    {
        public int LimiteProfundidade { get => 700; set => throw new NotImplementedException(); }

        public void Descer(int metros)
        {
            Console.WriteLine("Para descer " + metros + " O Peixe usa suas 2 nadadeiras. Com um limite de Profundidade: " + LimiteProfundidade);
        }

        public void Subir(int metros)
        {
            Console.WriteLine("Para subir " + metros + "O Peixe usa suas 2 nadadeiras. Com um limite de Profundidade: " + LimiteProfundidade);
        }
    }
    public class Repteis : Animal, Nadar
    {
        public int LimiteProfundidade { get => 700; set => throw new NotImplementedException(); }

        public void Descer(int metros)
        {
            Console.WriteLine("Para descer " + metros + " O Reptil usa suas 4 patas e rabo. Com um limite de Profundidade: " + LimiteProfundidade);
        }

        public void Subir(int metros)
        {
            Console.WriteLine("Para subir " + metros + " O Reptil usa suas 4 patas e rabo. Com um limite de Profundidade: " + LimiteProfundidade);
        }
    }
}
