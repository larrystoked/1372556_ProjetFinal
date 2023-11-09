//using _1372556_ProjetFinal.Data;
using _1372556_ProjetFinal.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Ajouter la configuration du routage
builder.Services.AddRazorPages();
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<TP1_PokemonContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("BDPokemon"));
});

var app = builder.Build();

// Configurer le pipeline de requêtes HTTP
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
        pattern: "{controller=Home}/{action=Index}/{id?}");

    endpoints.MapControllerRoute(
        name: "customRoute",
        pattern: "{controller=Home}/{action=RedirectVueJeux}/{id?}");

    endpoints.MapFallbackToController("Index", "Home");
});

app.MapRazorPages();

app.Run();
