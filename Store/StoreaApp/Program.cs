using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using StoreaApp.Models;



var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<RepositoryContexts>( options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("sqlconnetion"));
}
    );

var app = builder.Build();

app.UseRouting();
app.UseHttpsRedirection();



app.MapControllerRoute(
   name:"default",
   pattern:"{controller=Home}/{action=Index}/{id?}");

app.Run();
