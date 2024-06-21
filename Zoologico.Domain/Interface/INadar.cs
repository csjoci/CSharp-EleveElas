
namespace Zoologico.Domain
{
    public interface INadar
    {
        public int LimiteProfundidade {  get; set; }
        public string Subir();
        public string Descer();
        
    }
}
