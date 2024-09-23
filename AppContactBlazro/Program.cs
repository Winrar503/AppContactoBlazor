using AppContactBlazro;
using AppContactBlazro.Data.Service;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddHttpClient("AgendaAPI", client =>
{
    client.BaseAddress = new Uri("https://localhost:7190/"); // Reemplaza con la URL de tu API
});


builder.Services.AddScoped<ContactosService>();


await builder.Build().RunAsync();

