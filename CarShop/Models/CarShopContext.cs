using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CarShop.Models
{
    public partial class CarShopContext : DbContext
{
    public CarShopContext()
    {
    }

    public CarShopContext(DbContextOptions<CarShopContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Brand> Brands { get; set; }
    public virtual DbSet<Car> Cars { get; set; }
    public virtual DbSet<Client> Clients { get; set; }
    public virtual DbSet<Complication> Complications { get; set; }
    public virtual DbSet<Model> Models { get; set; }
    public virtual DbSet<Order> Orders { get; set; }
    public virtual DbSet<Stuff> Stuffs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
            optionsBuilder.UseSqlServer("Server=(localdb)\mssqllocaldb;Database=CarShop;Trusted_Connection=True;");
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasAnnotation("Relational:Collation", "Cyrillic_General_CI_AS");

        modelBuilder.Entity<Brand>(entity =>
        {
            entity.ToTable("Brand");

            entity.Property(e => e.BrandId)
                .ValueGeneratedNever()
                .HasColumnName("BrandID");
        });

        modelBuilder.Entity<Car>(entity =>
        {
            entity.Property(e => e.CarId)
                .ValueGeneratedNever()
                .HasColumnName("CarID");

            entity.Property(e => e.BrandId).HasColumnName("BrandID");

            entity.Property(e => e.ComplicationId).HasColumnName("ComplicationID");

            entity.Property(e => e.ModelId).HasColumnName("ModelID");

            entity.HasOne(d => d.Brand)
                .WithMany(p => p.Cars)
                .HasForeignKey(d => d.BrandId)
                .HasConstraintName("FK_Cars_Brand");

            entity.HasOne(d => d.Complication)
                .WithMany(p => p.Cars)
                .HasForeignKey(d => d.ComplicationId)
                .HasConstraintName("FK_Cars_Complication");

            entity.HasOne(d => d.Model)
                .WithMany(p => p.Cars)
                .HasForeignKey(d => d.ModelId)
                .HasConstraintName("FK_Cars_Model");
        });

        modelBuilder.Entity<Client>(entity =>
        {
            entity.HasKey(e => e.ClentId);

            entity.ToTable("Client");

            entity.Property(e => e.ClentId)
                .ValueGeneratedNever()
                .HasColumnName("ClentID");
        });

        modelBuilder.Entity<Complication>(entity =>
        {
            entity.ToTable("Complication");

            entity.Property(e => e.ComplicationId)
                .ValueGeneratedNever()
                .HasColumnName("ComplicationID");
        });

        modelBuilder.Entity<Model>(entity =>
        {
            entity.ToTable("Model");

            entity.Property(e => e.ModelId)
                .ValueGeneratedNever()
                .HasColumnName("ModelID");

            entity.Property(e => e.BrandId).HasColumnName("BrandID");

            entity.HasOne(d => d.Brand)
                .WithMany(p => p.Models)
                .HasForeignKey(d => d.BrandId)
                .HasConstraintName("FK_Model_Brand");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.ToTable("Order");

            entity.Property(e => e.OrderId)
                .ValueGeneratedNever()
                .HasColumnName("OrderID");

            entity.Property(e => e.CarId).HasColumnName("CarID");

            entity.Property(e => e.ClientId).HasColumnName("ClientID");

            entity.Property(e => e.Date).HasColumnType("datetime");

            entity.Property(e => e.StuffId).HasColumnName("StuffID");

            entity.HasOne(d => d.Car)
                .WithMany(p => p.Orders)
                .HasForeignKey(d => d.CarId)
                .HasConstraintName("FK_Order_Cars");

            entity.HasOne(d => d.Client)
                .WithMany(p => p.Orders)
                .HasForeignKey(d => d.ClientId)
                .HasConstraintName("FK_Order_Client");

            entity.HasOne(d => d.Stuff)
                .WithMany(p => p.Orders)
                .HasForeignKey(d => d.StuffId)
                .HasConstraintName("FK_Order_Stuff");
        });

        modelBuilder.Entity<Stuff>(entity =>
        {
            entity.ToTable("Stuff");

            entity.Property(e => e.StuffId)
                .ValueGeneratedNever()
                .HasColumnName("StuffID");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
}