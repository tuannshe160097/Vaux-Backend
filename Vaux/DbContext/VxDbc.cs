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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
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

            modelBuilder.Entity<Item>()
                .HasMany(e => e.AuctionSessions)
                .WithMany(e => e.Items);

            modelBuilder.Entity<Item>()
                .Property(e => e.ReservePrice)
                .HasDefaultValue(0);

            modelBuilder.Entity<User>()
                .Property(e => e.IsVerified)
                .HasDefaultValue(0);

            modelBuilder.Entity<Order>()
                .Property(e => e.TotalCost)
                .HasDefaultValue(0);

            modelBuilder.Entity<Role>().HasData(
                new Role()
                {
                    Id = (int)Models.Enums.Role.ADMIN,
                    Title = "ADMIN"
                },
                new Role()
                {
                    Id = (int)Models.Enums.Role.EXPERT,
                    Title = "EXPERT"
                },
                new Role()
                {
                    Id = (int)Models.Enums.Role.SELLER,
                    Title = "SELLER"
                },
                new Role()
                {
                    Id = (int)Models.Enums.Role.BUYER,
                    Title = "BUYER"
                }
            );

            modelBuilder.Entity<SuperUser>().HasData(new SuperUser()
            {
                Id = 1,
                RoleId = (int)Models.Enums.Role.ADMIN,
                Name = "Admin",
                Phone = "0855068490",
                Email = "tuannshe160097@fpt.edu.vn",
                CitizenId = "",
            });
        }

        public override int SaveChanges()
        {
            var entries = ChangeTracker
                .Entries()
                .Where(e => e.Entity is ModelBase && (e.State == EntityState.Added || e.State == EntityState.Modified));

            foreach (var entityEntry in entries)
            {
                ((ModelBase)entityEntry.Entity).Updated = DateTime.Now;
            }

            return base.SaveChanges();
        }

        public DbSet<User> Users { get; set; }
        public DbSet<SuperUser> SuperUsers { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<SellerApplication> SellerApplications { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<ItemProperty> ItemProperties { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Bid> Bids { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<AuctionSession> AuctionSessions { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Shipment> Shipments { get; set; }
        public DbSet<SellerPayment> SellerPayments { get; set;}
        public DbSet<StatusChange> StatusChanges { get; set; }
    }
}
