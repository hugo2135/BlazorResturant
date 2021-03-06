global using BlazorApp1.Shared;
global using System.Net.Http.Json;
global using BlazorApp1.Client.Services.ResturantService;
using BlazorApp1.Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IResturantService, ResturantService>();

await builder.Build().RunAsync();
