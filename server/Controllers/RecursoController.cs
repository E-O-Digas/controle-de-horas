using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using server.Db;
using server.Models;
using server.Services;

namespace server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecursoController : ControllerBase
    {
        private readonly IRecursoService service;
        // private readonly AppDbContext _context;

        public RecursoController(IRecursoService service) 
        {
            this.service = service;
            // this._context = _context;

        }

        [HttpGet]
        public async Task<ActionResult<List<Recurso>>> TodosRecursos()
        {
            try
            {
                var recursos = await service.ObterTodosRecursos();
                
                return Ok(recursos);

            }
            catch
            {

                throw;
            }
        }
    }
}