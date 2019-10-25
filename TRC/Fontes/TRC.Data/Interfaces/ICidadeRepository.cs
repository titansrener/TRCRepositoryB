using System.Collections.Generic;
using System.Threading.Tasks;
using TRC.Core.Modelo;

namespace TRC.Data.Interfaces
{
    public interface ICidadeRepository
    {
        Task<IEnumerable<Cidade>> GetCidadesAsync();
    }
}
