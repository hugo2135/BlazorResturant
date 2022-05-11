namespace BlazorApp1.Client.Services.ResturantService
{
    public interface IResturantService
    {
        List<Resturant> Resturants { get; set; }
        Task GetResturants();
        Task<Resturant> GetSingleResturant(int id);
        Task CreateResturant(Resturant resturant);
        Task UpdateResturant(Resturant resturant);
        Task DeleteResturant(int id);
    }
}
