using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using TRC.Core.Modelo;
using TRC.Data.Interfaces;

namespace TRC.Data.Implementation
{
    public class EstadoRepository : IEstadoRepository
    {
        private readonly TrcContext contexto;

        public EstadoRepository(TrcContext pContexto)
        {
            contexto = pContexto;
        }
        public async Task<IEnumerable<Estado>> GetEstadosAsync()
        {
            return await contexto.Estados.Include(e => e.CidadesNavegation).ToListAsync();
        }
    }
}
