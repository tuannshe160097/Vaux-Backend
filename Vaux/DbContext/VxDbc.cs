namespace Vaux.DbContext
{
    using Microsoft.EntityFrameworkCore;
    using Vaux.Models;

    public class VxDbc : DbContext
    {
        public VxDbc(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>()
                .HasMany(e => e.Images)
                .WithMany(e => e.Items);

            modelBuilder.Entity<ItemApplication>()
                .HasMany(e => e.Images)
                .WithMany(e => e.ItemApplications);
        }

        DbSet<User> Users { get; set; }
        DbSet<SuperUser> SuperUsers { get; set; }
        DbSet<Role> Roles { get; set; }
        DbSet<Notification> Notifications { get; set; }
        DbSet<SellerApplication> SellerApplications { get; set; }
        DbSet<Image> Images { get; set; }
        DbSet<Item> Items { get; set; }
        DbSet<ItemApplication> ItemsApplication { get; set; }
        DbSet<ItemProperty> ItemsProperty { get; set; }
        DbSet<Category> Categories { get; set; }
        DbSet<Bid> Bids { get; set; }
        DbSet<Comment> Comments { get; set; }   
        DbSet<Payment> Payment { get; set; }
    }
}
