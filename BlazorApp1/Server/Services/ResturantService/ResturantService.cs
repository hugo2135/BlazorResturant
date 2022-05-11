namespace BlazorApp1.Server.Services.ResturantService
{
    public class ResturantService : IResturantService
    {
        private readonly DataContext _context;

        public ResturantService(DataContext context)
        {
            _context = context;
        }
        public async Task<ServiceResponse<List<Resturant>>> GetResturantsAsync()
        {
            var response = new ServiceResponse<List<Resturant>>()
            {
                Data = await _context.Resturants.ToListAsync()
            };
            return response;
        }
    }
}
