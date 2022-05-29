using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SistemaFilmes.Areas.Identity.Data;
using SistemaFilmes.Data;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("SistemaFilmesContextConnection") ?? throw new InvalidOperationException("Connection string 'SistemaFilmesContextConnection' not found.");

builder.Services.AddDbContext<SistemaFilmesContext>(options =>
    options.UseSqlServer(connectionString));;

builder.Services.AddDefaultIdentity<SistemaFilmesUser>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddEntityFrameworkStores<SistemaFilmesContext>();;

// Add services to the container.
builder.Services.AddDatabaseDeveloperPageExceptionFilter();


builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();
