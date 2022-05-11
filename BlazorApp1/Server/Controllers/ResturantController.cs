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
        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<Resturant>>> GetSingleResturant(int id)
        {
            var resturant = await _resturantService.GetSingleResturant(id);
            if (resturant == null)
            {
                return NotFound("Sorry, We don`t have this resturant.");
            }
            return Ok(resturant.Data);
        }
        [HttpPost]
        public async Task<ActionResult<Resturant>> CreateResturant(Resturant resturant)
        {
            var result = await _resturantService.CreateResturant(resturant);
            return Ok(result.Data);
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<Resturant>> UpdateResturant(Resturant resturant, int id)
        {
            var result = await _resturantService.UpdateResturant(resturant, id);
            return Ok(result);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<Resturant>> DeleteResturant(int id)
        {
            var result = await _resturantService.DeleteResturant(id);
            if (result == null)
            {
                return NotFound("We don`t have this resturant.");
            }
            return Ok(result);
        }
    }
}
