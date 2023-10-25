using _1372556_ProjetFinal.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileSystemGlobbing.Internal.Patterns;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddDbContext<TP1_PokemonContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("BDPokemon"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller}/{action}/{id}"
        );
    endpoints.MapFallbackToController("Index", "Generations");
}); 

app.MapRazorPages();

app.Run();
