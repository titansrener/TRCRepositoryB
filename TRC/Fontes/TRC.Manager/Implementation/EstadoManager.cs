using System.Collections.Generic;
using System.Threading.Tasks;
using TRC.Core.Modelo;
using TRC.Data.Interfaces;
using TRC.Manager.Interfaces;

namespace TRC.Manager.Implementation
{
    public class EstadoManager : IEstadoManager
    {
        private readonly IEstadoRepository _estadoRepository;
        public EstadoManager(IEstadoRepository estadoRepository)
        {
            _estadoRepository = estadoRepository;
        }
        public async Task<IEnumerable<Estado>> GetEstadosAsync()
        {
            return await _estadoRepository.GetEstadosAsync();
        }
    }
}
