using Microsoft.EntityFrameworkCore;

namespace DesignPatterns.Models.Data; 
public partial class DesignPatternsContext : DbContext {
    public DesignPatternsContext() {
    }

    public DesignPatternsContext(DbContextOptions<DesignPatternsContext> options)
        : base(options) {
    }

    public virtual DbSet<Beer> Beers { get; set; } = null!;
    public virtual DbSet<Brand> Brands { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        if (!optionsBuilder.IsConfigured) {
            //optionsBuilder.UseSqlServer("Server=(local);Database=DesignPatterns;Trusted_Connection=True;");
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        modelBuilder.Entity<Beer>(entity => {
            entity.ToTable("Beer");

            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Style)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Brand>(entity => {
            entity.ToTable("Brand");

            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}