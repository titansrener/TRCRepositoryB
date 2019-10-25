using System.Collections.Generic;
using System.Threading.Tasks;
using TRC.Core.Modelo;

namespace TRC.Manager.Interfaces
{
    public interface ICidadeManager
    {
        Task<IEnumerable<Cidade>> GetCidadesAsync();
    }
}
