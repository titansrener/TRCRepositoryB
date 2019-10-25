using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using TRC.Core.Modelo;
using TRC.Data.Interfaces;

namespace TRC.Data.Implementation
{
    public class CidadeRepository : ICidadeRepository
    {
        private readonly TrcContext _contexto;
        public CidadeRepository(TrcContext contexto)
        {
            _contexto = contexto;
        }
        public async Task<IEnumerable<Cidade>> GetCidadesAsync()
        {
            return await _contexto.Cidades.ToListAsync();
        }
    }
}
