namespace Vaux.DbContext
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Migrations;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using Vaux.Models;

    public class VxDbc : DbContext
    {
        public VxDbc(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<ModelBase>();

            foreach (var e in modelBuilder.Model.GetEntityTypes())
            {
                if (e.ClrType.IsSubclassOf(typeof(ModelBase)))
                {
                    e.FindProperty(nameof(ModelBase.Created)).SetDefaultValueSql("GETDATE()");
                    e.FindProperty(nameof(ModelBase.Created)).ValueGenerated = Microsoft.EntityFrameworkCore.Metadata.ValueGenerated.OnAdd;

                    e.FindProperty(nameof(ModelBase.Updated)).SetDefaultValueSql("GETDATE()");
                    e.FindProperty(nameof(ModelBase.Updated)).ValueGenerated = Microsoft.EntityFrameworkCore.Metadata.ValueGenerated.OnAdd;
                }
            }

            modelBuilder.Entity<Item>()
                .HasMany(e => e.Images)
                .WithMany(e => e.Items);

            modelBuilder.Entity<ItemApplication>()
                .HasMany(e => e.Images)
                .WithMany(e => e.ItemApplications);

            modelBuilder.Entity<Role>().HasData(
                new Role()
                {
                    Id = 1,
                    Title = "Admin"
                },
                new Role()
                {
                    Id = 2,
                    Title = "Expert"
                },
                new Role()
                {
                    Id = 3,
                    Title = "Seller"
                },
                new Role()
                {
                    Id = 4,
                    Title = "Buyer"
                }
            );
        }

        public DbSet<User> Users { get; set; }
        public DbSet<SuperUser> SuperUsers { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<SellerApplication> SellerApplications { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<ItemApplication> ItemApplications { get; set; }
        public DbSet<ItemProperty> ItemProperties { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Bid> Bids { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Payment> Payment { get; set; }
    }
}
