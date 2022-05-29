using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SistemaFilmes.Areas.Identity.Data;
using SistemaFilmes.Models;

namespace SistemaFilmes.Data;

public class SistemaFilmesContext : IdentityDbContext<SistemaFilmesUser>
{
    public SistemaFilmesContext(DbContextOptions<SistemaFilmesContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }

    public DbSet<SistemaFilmes.Models.Movie>? Movie { get; set; }
}
