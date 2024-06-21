
using Zoologico.Domain.Entity;

namespace Zoologico.Domain
{
    public class AnfibioNadador : Anfibio, INadar
    {
        public int LimiteProfundidade { get; set; } = 100;

        public string Descer()
        {
            return $"Eu sou um anfibio que nada até {LimiteProfundidade} m.";
        }

        public string Subir()
        {
            return $"Eu sou um anfibio volta a superficie.";
        }
    }
}
