using LimpiezaProyect.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<LimpiezaContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("LimpiezaContext"));
});

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseEndpoints(endpoints =>
{
//rcajas   
 endpoints.MapControllerRoute(
        name: "custom",
        pattern: "{controller=Inicio}/{action=Index}/{empresa}/{usuario}/{rol}"
    );

    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Inicio}/{action=Index}/{id?}"
    );
});

app.MapFallbackToController("Index", "Inicio");

app.Run();
