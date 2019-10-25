using System.Collections.Generic;
using System.Threading.Tasks;
using TRC.Core.Modelo;
using TRC.Data.Interfaces;
using TRC.Manager.Interfaces;

namespace TRC.Manager.Implementation
{
    public class CidadeManager : ICidadeManager
    {
        private readonly ICidadeRepository _cidadeRepository;
        public CidadeManager(ICidadeRepository cidadeRepository)
        {
            _cidadeRepository = cidadeRepository;
        }
        public async Task<IEnumerable<Cidade>> GetCidadesAsync()
        {
            return await _cidadeRepository.GetCidadesAsync();
        }
    }
}
