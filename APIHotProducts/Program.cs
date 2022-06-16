using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using APIHotProducts.Models;

using APIHotProducts.Data;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<APIHotProductsContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("APIHotProductsContext") ?? throw new InvalidOperationException("Connection string 'APIHotProductsContext' not found.")));

var app = builder.Build();

// This will seed the data in the DB, only 2 entries.
//If the DB is empty this will add two records automatically
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    SeedData.Initialize(services);
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
