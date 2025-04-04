using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using repro.Client.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.Services.AddScoped<CultureService>();

await builder.Build().RunAsync();
