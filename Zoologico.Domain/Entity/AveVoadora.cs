

namespace Zoologico.Domain.Entity
{
    internal class AveVoadora : Aves, IVoar
    {
        public string LevantarVoo()
        {
            return $"Eu sou uma ave que voa.";
        }

        public string Pousar()
        {
            return $"Eu sou uma ave que pousa.";
        }
    }
}
