namespace BlazorApp1.Server.Services.ResturantService
{
    public interface IResturantService
    {
        Task<ServiceResponse<List<Resturant>>> GetResturantsAsync();
    }
}
