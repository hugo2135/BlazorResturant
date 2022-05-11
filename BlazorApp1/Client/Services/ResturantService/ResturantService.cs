namespace BlazorApp1.Client.Services.ResturantService
{
    public class ResturantService : IResturantService
    {
        private readonly HttpClient _http;

        public ResturantService(HttpClient http)
        {
            _http = http;
        }
        public List<Resturant> Resturants { get; set; } = new List<Resturant>();

        public async Task GetResturants()
        {
            var result = await _http.GetFromJsonAsync<ServiceResponse<List<Resturant>>>("api/resturant");
            if (result != null && result.Data != null)
                Resturants = result.Data;
        }
    }
}
