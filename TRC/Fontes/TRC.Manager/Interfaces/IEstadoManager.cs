using System.Collections.Generic;
using System.Threading.Tasks;
using TRC.Core.Modelo;

namespace TRC.Manager.Interfaces
{
    public interface IEstadoManager
    {
        Task<IEnumerable<Estado>> GetEstadosAsync();
    }
}
