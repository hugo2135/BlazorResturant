namespace BlazorApp1.Server.Services.ResturantService
{
    public interface IResturantService
    {
        Task<ServiceResponse<List<Resturant>>> GetResturantsAsync();
        Task<ServiceResponse<Resturant>> GetSingleResturant(int id);
        Task<ServiceResponse<List<Resturant>>> CreateResturant(Resturant resturant);
        Task<ServiceResponse<List<Resturant>>> UpdateResturant(Resturant resturant, int id);
        Task<ServiceResponse<List<Resturant>>> DeleteResturant(int id);
    }
}
