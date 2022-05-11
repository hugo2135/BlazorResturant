using Microsoft.AspNetCore.Mvc;

namespace BlazorApp1.Server.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class ResturantController : Controller
    {
        private readonly IResturantService _resturantService;

        public ResturantController(IResturantService resturantSevice)
        {
            _resturantService = resturantSevice;
        }
        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Resturant>>>> GetResult()
        {
            var result = await _resturantService.GetResturantsAsync();
            return Ok(result);
        }
    }
}
