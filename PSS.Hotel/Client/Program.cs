global using PSS.Hotel.Client.Services.DailyTableDetailService;
global using PSS.Hotel.Client.Services.DailyTableService;
global using PSS.Hotel.Client.Services.EmployeeMasterService;
global using PSS.Hotel.Client.Services.ItemwiseTableService;
global using PSS.Hotel.Client.Services.TableNameService;
global using PSS.Hotel.Client.Services.DeviceRegistrationService;
global using PSS.Hotel.Client.Services.SectionMasterService;

global using PSS.Hotel.Shared;
global using PSS.Hotel.Shared.Models;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using PSS.Hotel.Client;

using Radzen;
using PSS.Hotel.Client.Services.DataService;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddBlazoredLocalStorage();
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddRadzenComponents();

builder.Services.AddScoped<IEmployeeMasterService, EmployeeMasterService>();
builder.Services.AddScoped<IDailyTableDetailService, DailyTableDetailService>();
builder.Services.AddScoped<IItemwiseTableService, ItemwiseTableService>();
builder.Services.AddScoped<IDailyTableService, DailyTableService>();
builder.Services.AddScoped<ITableNameService, TableNameService>();
builder.Services.AddScoped<IDeviceRegistrationService, DeviceRegistrationService>();
builder.Services.AddScoped<IDataService,DataService>();
builder.Services.AddScoped<ISectionMasterService,SectionMasterService>();

await builder.Build().RunAsync();
