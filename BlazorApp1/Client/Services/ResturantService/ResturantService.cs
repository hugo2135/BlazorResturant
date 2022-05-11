using Microsoft.AspNetCore.Components;

namespace BlazorApp1.Client.Services.ResturantService
{
    public class ResturantService : IResturantService
    {
        private readonly HttpClient _http;
        private readonly NavigationManager _navigationManager;

        public ResturantService(HttpClient http, NavigationManager navigationManager)
        {
            _http = http;
            _navigationManager = navigationManager;
        }
        public List<Resturant> Resturants { get; set; } = new List<Resturant>();

        public async Task GetResturants()
        {
            var result = await _http.GetFromJsonAsync<ServiceResponse<List<Resturant>>>("api/resturant");
            if (result != null && result.Data != null)
                Resturants = result.Data;
        }
        public async Task<Resturant> GetSingleResturant(int id)
        {
            var result = await _http.GetFromJsonAsync<Resturant>($"api/resturant/{id}");
            if (result != null)
                return result;
            throw new Exception("Resturant not found");
        }
        public async Task CreateResturant(Resturant resturant)
        {
            var result = await _http.PostAsJsonAsync("api/resturant", resturant);
            var response = await result.Content.ReadFromJsonAsync<List<Resturant>>();
            if (result != null)
                Resturants = response;
            _navigationManager.NavigateTo("/");
        }
        public async Task UpdateResturant(Resturant resturant)
        {
            var result = await _http.PutAsJsonAsync($"api/resturant/{resturant.Id}", resturant);
            await SetResturants(result);
        }
        public async Task DeleteResturant(int id)
        {
            var result = await _http.DeleteAsync($"api/resturant/{id}");
            await SetResturants(result);
        }
        private async Task SetResturants(HttpResponseMessage result)
        {
            var response = await result.Content.ReadFromJsonAsync<ServiceResponse<List<Resturant>>>();
            if (result != null)
                Resturants = response.Data;
            _navigationManager.NavigateTo("/");
        }
    }
}
