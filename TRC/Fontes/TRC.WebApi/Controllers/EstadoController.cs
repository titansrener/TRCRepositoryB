using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TRC.Core.Modelo;
using TRC.Core.ModelView;
using TRC.Manager.Interfaces;

namespace TRC.WebApi.Controllers
{
    [Route("api/Estado")]
    [ApiController]
    public class EstadoController : ControllerBase
    {
        private readonly IEstadoManager _estadoManager;
        private readonly ICidadeManager _cidadeManager;

        public EstadoController(IEstadoManager estadoManager, ICidadeManager cidadeManager)
        {
            _estadoManager = estadoManager;
            _cidadeManager = cidadeManager;
        }

        /// <summary>
        /// Retorna todos do estados.
        /// </summary>
        /// <returns></returns>
        [ProducesResponseType(typeof(IEnumerable<Estado>), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        [HttpGet("/Estados/", Name = "Estadosff")]
        public async Task<ActionResult<IEnumerable<EstadoView>>> GetEstadosAsync()
        {
            try
            {
                var listaEstado = new List<EstadoView>();
                var estados = await _estadoManager.GetEstadosAsync();
                foreach (var estado in estados)
                {
                    listaEstado.Add(new EstadoView(estado));
                }

                return Ok(listaEstado);
            }
            catch (Exception ex)
            {
                Exception exception = new Exception("Erro inesperado", ex);
                throw exception;
            }
        }

        [ProducesResponseType(typeof(IEnumerable<Cidade>), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        [HttpGet("/Cidades/", Name = "Cidadesff")]
        public async Task<ActionResult<IEnumerable<Cidade>>> GetCidadesAsync()
        {
            try
            {
                return Ok(await _cidadeManager.GetCidadesAsync());
            }
            catch (Exception ex)
            {
                Exception exception = new Exception("Erro inesperado", ex);
                throw exception;
            }
        }
    }
}
