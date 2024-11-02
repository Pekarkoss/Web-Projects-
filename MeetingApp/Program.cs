using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();
app.UseStaticFiles();
app.UseRouting(); 
// {contoller=Home}/{action=Index}/{id?}
//app.MapDefaultControllerRoute();
app.MapControllerRoute(
    name: "Default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);
app.Run();
