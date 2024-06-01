using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using foodies_api.Models;
using foodies_api.Models.Dtos;
using foodies_api.Models.Dtos.Auth;

namespace foodies_api.Data;

public class ApplicationDbContext : IdentityDbContext<IdentityUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }
    // public virtual DbSet<IdentityUser> Users { get; set; } = null!;
    public DbSet<User> Users { get; set; }

    // protected override void OnConfiguring(DbContextOptionsBuilder options)
    // {
    //     options.UseNpgsql("User ID=kayc;Password=Jumpman23!;Host=localhost;Port=5433;Database=FoodiesApiDb;Pooling=true;");   
    // }
}
