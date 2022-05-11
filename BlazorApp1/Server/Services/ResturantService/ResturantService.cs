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
        public async Task<ServiceResponse<Resturant>> GetSingleResturant(int id)
        {
            var result = await GetResturantsAsync();
            var resturant = new ServiceResponse<Resturant>()
            {
                Data = result.Data.Find(x => x.Id == id)
            };
            return resturant;
        }
        public async Task<ServiceResponse<List<Resturant>>> CreateResturant(Resturant resturant)
        {
            _context.Resturants.Add(resturant);
            await _context.SaveChangesAsync();

            return await GetResturantsAsync();
        }
        public async Task<ServiceResponse<List<Resturant>>> UpdateResturant(Resturant resturant, int id)
        {
            var dbResturant = await _context.Resturants.FirstOrDefaultAsync(x => x.Id == id);
            if(dbResturant == null)
                return null;

            dbResturant.Name = resturant.Name;
            dbResturant.Style = resturant.Style;
            dbResturant.Price = resturant.Price;
            dbResturant.Distance = resturant.Distance;
            dbResturant.Address = resturant.Address;
            dbResturant.Rating = resturant.Rating;
            dbResturant.ImageURL = resturant.ImageURL;
            await _context.SaveChangesAsync();

            return await GetResturantsAsync();
        }
        public async Task<ServiceResponse<List<Resturant>>> DeleteResturant(int id)
        {
            var dbResturant = await _context.Resturants.FirstOrDefaultAsync(x => x.Id == id);
            if (dbResturant == null)
                return null;

            _context.Resturants.Remove(dbResturant);
            await _context.SaveChangesAsync();

            return await GetResturantsAsync();
        }
    }
}
