using Microsoft.EntityFrameworkCore;

namespace EFFluentApiP32;

public class SchoolContext : DbContext
{
    public DbSet<Student> Students { get; set; }
    public DbSet<Subject> Subjects { get; set; }
    public DbSet<Teacher> Teachers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.LogTo(Console.WriteLine);
        optionsBuilder.UseSqlServer(
            "Server=localhost\\SQLEXPRESS;Database=SchoolP32;Trusted_Connection=True;TrustServerCertificate=True;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Student>(e =>
        {
            e.ToTable("Students");
            e.HasIndex(x => x.Id)
                .IsUnique();
        });

        modelBuilder.Entity<Student>()
            .HasMany(t => t.Teachers)
            .WithMany(s => s.Students);

        modelBuilder.Entity<Student>()
            .Property(n => n.Name).HasMaxLength(100).IsRequired();
        
        modelBuilder.Entity<Subject>()
            .HasIndex(i => i.Id)
            .IsUnique();
        
        modelBuilder.Entity<Subject>()
            .HasOne(t => t.Teacher)
            .WithMany(s => s.Subjects);
        
        modelBuilder.Entity<Teacher>()
            .HasMany(s => s.Subjects)
            .WithOne(s => s.Teacher);
    }
}