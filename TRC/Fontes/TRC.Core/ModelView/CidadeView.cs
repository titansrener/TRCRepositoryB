using TRC.Core.Modelo;

namespace TRC.Core.ModelView
{
    public class CidadeView
    {
        public CidadeView(Cidade cidade)
        {
            Nome = cidade.Nome;
            //EstadoNome = cidade.EstadoNavegation.Nome;
        }
        public string Nome { get; set; }
    }
}
