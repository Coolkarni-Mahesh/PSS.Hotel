global using PSS.Hotel.Client.Services.EmployeeMasterService;
global using PSS.Hotel.Client.Services.DailyTableDetailService;
global using PSS.Hotel.Client.Services.ItemwiseTableService;
global using PSS.Hotel.Shared;
global using PSS.Hotel.Shared.Models;
global using PSS.Hotel.Client.Services.DailyTableService;

using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using PSS.Hotel.Client;
using Radzen;


var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddRadzenComponents();

builder.Services.AddScoped<IEmployeeMasterService,EmployeeMasterService>();
builder.Services.AddScoped<IDailyTableDetailService, DailyTableDetailService>();
builder.Services.AddScoped<IItemwiseTableService, ItemwiseTableService>();
builder.Services.AddScoped<IDailyTableService,DailyTableService>();

await builder.Build().RunAsync();
