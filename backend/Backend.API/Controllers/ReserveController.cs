using Backend.Infrastructure;
using Backend.Infrastructure.ReserveRepositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Backend.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReserveController : ControllerBase
    {
        private ReserveRepository reserveRepository;
        private readonly ApplicationDbContext _context;

        public ReserveController(ApplicationDbContext context)
        {
            _context = context;
             reserveRepository = new ReserveRepository(context);
        }

        [HttpGet("teste-connection-db")]
        public IActionResult TestarConexao()
        {
            try
            {
                var ok = _context.Database.CanConnect();
                return ok ? Ok("Already connect!") : StatusCode(500, "Error!!");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error: {ex.Message}");
            }
        }

        [HttpGet("getAll")]
        public async Task<IActionResult> GetAllAsync()
        {
            return Ok(await reserveRepository.GetAll());
        }

    }
}
