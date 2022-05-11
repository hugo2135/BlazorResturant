using Microsoft.AspNetCore.Mvc;

namespace BlazorApp1.Server.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class ResturantController : Controller
    {
        private readonly DataContext _context;

        public ResturantController(DataContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<Resturant>>> GetResult()
        {
            var Resturants = await _context.Resturants.ToListAsync();
            return Ok(Resturants);
        }
    }
}
