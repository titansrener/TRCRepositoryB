using System.Collections.Generic;

namespace TRC.Core.Modelo
{
    public class Estado
    {
        public int Id { get; set; }

        public string Sigla { get; set; }

        public string Nome { get; set; }

        public virtual ICollection<Cidade> CidadesNavegation { get; set; }
    }
}
