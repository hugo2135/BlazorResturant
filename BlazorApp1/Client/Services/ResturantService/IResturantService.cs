namespace BlazorApp1.Client.Services.ResturantService
{
    public interface IResturantService
    {
        List<Resturant> Resturants { get; set; }
        Task GetResturants();
    }
}
