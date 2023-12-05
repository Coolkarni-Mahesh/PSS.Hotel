
global using PSS.Hotel.Shared;
global using PSS.Hotel.Shared.Models;
global using Microsoft.EntityFrameworkCore;
global using PSS.Hotel.Server.Services.DailyTableDetailService;
global using PSS.Hotel.Server.Services.EmployeeMasterService;
global using PSS.Hotel.Server.Services.ItemwiseTableService;
global using PSS.Hotel.Server.Services.SupervisorScreenService;
global using PSS.Hotel.Server.Services.DailyTableService;
global using PSS.Hotel.Server.Services.TableNameService;
global using PSS.Hotel.Server.Services.DataService;

using Microsoft.AspNetCore.ResponseCompression;
using PSS.Hotel.Server.Hubs;
using PSS.Hotel.Server.Services.SectionMasterService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ModelContext>(options =>
options.UseJet(builder.Configuration.GetConnectionString("AccessConnection")));

builder.Services.AddSignalR();
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddResponseCompression(option =>
{
    option.MimeTypes = ResponseCompressionDefaults.MimeTypes.Concat(
        new[]
        {
            "application/octet-stream"
        });
});

builder.Services.AddScoped<IEmployeeMasterService, EmployeeMasterService>();
builder.Services.AddScoped<IDailyTableDetailService,DailyTableDetailService>();
builder.Services.AddScoped<IItemwiseTableService, ItemwiseTableService>();
builder.Services.AddScoped<ISupervisorScreenService, SupervisorScreenService>();
builder.Services.AddScoped<IDailyTableService, DailyTableService>();
builder.Services.AddScoped<ITableNameService, TableNameService> ();
builder.Services.AddScoped<IDataService, DataService> ();
builder.Services.AddScoped<ISectionMasterService, SectionMasterService> ();



var app = builder.Build();

app.UseResponseCompression();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseSwaggerUI();
app.UseSwagger();

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();


app.MapRazorPages();
app.MapControllers();
app.MapHub<DailyTableDetailHub>("/DailyTableDetailHub");
app.MapFallbackToFile("index.html");

app.Run();
