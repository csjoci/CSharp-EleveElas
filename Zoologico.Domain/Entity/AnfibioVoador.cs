

using Zoologico.Domain.Entity;

namespace Zoologico.Domain
{
    public class AnfibioVoador : Anfibio, IVoar
    {
        public string LevantarVoo()
        {
            return $"Eu sou um anfibio que voa.";
        }

        public string Pousar()
        {
            return $"Eu sou um anfibio que pousa.";
        }
    }
}
