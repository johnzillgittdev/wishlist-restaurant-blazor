using BlazorDexie.Extensions;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using RestaurantWishlist;
using RestaurantWishlist.DB;
using RestaurantWishlist.Repository;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddMudServices();
builder.Services.AddBlazorDexie();
builder.Services.AddScoped<MyDB>();
builder.Services.AddScoped<IRestaurantRepository, LocalRestaurantRepository>();

await builder.Build().RunAsync();
