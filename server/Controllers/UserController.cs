using Microsoft.AspNetCore.Mvc;
using server.Db;

namespace server.Controllers{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase{
        private readonly AppDbContext dbContext;
        
        public UserController(AppDbContext dbContext){
            this.dbContext = dbContext;

        }

        [HttpGet]
        public IActionResult GetAllUsers(){
            return Ok(dbContext.Usuarios.ToList());
            
        }
    }
}