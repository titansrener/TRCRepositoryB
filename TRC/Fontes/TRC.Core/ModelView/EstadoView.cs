using TRC.Core.Modelo;

namespace TRC.Core.ModelView
{
    public class EstadoView
    {
        public EstadoView(Estado estado)
        {
            Sigla = estado.Sigla;
            Nome = estado.Nome;
        }
        public string Sigla { get; set; }

        public string Nome { get; set; }
    }
}
