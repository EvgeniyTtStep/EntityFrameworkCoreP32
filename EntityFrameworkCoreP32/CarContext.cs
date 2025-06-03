using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCoreP32;

public class CarContext : DbContext
{
    
    public DbSet<Toyota> Toyotas { get; set; }
    public DbSet<Engine> Engines { get; set; }
    public DbSet<Driver> Drivers { get; set; }
    
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.LogTo(Console.WriteLine);
        optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=CarP32;Trusted_Connection=True;TrustServerCertificate=True;");
    }

    //Fluent API
    // protected override void OnModelCreating(ModelBuilder modelBuilder)
    // {
    //     modelBuilder.Entity<Toyota>(entity =>
    //         {
    //             entity.ToTable("Toyotas");
    //             //entity.HasKey(e => e.Id);
    //             
    //              entity.Property(e => e.Id)
    //                  .ValueGeneratedOnAdd()
    //                  .HasColumnName("IdToyota");
    //             
    //             
    //             entity.Property(e => e.Name)
    //                 .IsRequired()
    //                 .HasMaxLength(100)
    //                 .HasColumnName("ToyotaName");
    //             
    //         }
    //     );
    //}
}