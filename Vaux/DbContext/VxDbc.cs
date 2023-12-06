namespace Vaux.DbContext
{
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata;
    using Microsoft.EntityFrameworkCore.Metadata.Internal;
    using Microsoft.EntityFrameworkCore.Migrations;
    using Microsoft.EntityFrameworkCore.Query;
    using Microsoft.Extensions.Hosting;
    using System.Linq.Expressions;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using Vaux.Models;
    using Vaux.Models.Enums;

    public class VxDbc : DbContext
    {
        public VxDbc(DbContextOptions options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<ModelBase>();

            Expression<Func<ModelBase, bool>> notDeletedExpr = mb => mb.Deleted == null;
            foreach (var e in modelBuilder.Model.GetEntityTypes())
            {
                if (e.ClrType.IsSubclassOf(typeof(ModelBase)))
                {
                    e.FindProperty(nameof(ModelBase.Created))!.SetDefaultValueSql("GETDATE()");
                    e.FindProperty(nameof(ModelBase.Created))!.ValueGenerated = ValueGenerated.OnAdd;

                    e.FindProperty(nameof(ModelBase.Updated))!.SetDefaultValueSql("GETDATE()");
                    e.FindProperty(nameof(ModelBase.Updated))!.ValueGenerated = ValueGenerated.OnAdd;

                    var parameter = Expression.Parameter(e.ClrType);
                    var body = ReplacingExpressionVisitor.Replace(notDeletedExpr.Parameters.First(), parameter, notDeletedExpr.Body);
                    var lambdaExpression = Expression.Lambda(body, parameter);

                    e.SetQueryFilter(lambdaExpression);
                }
            }

            modelBuilder.Entity<Item>()
                .HasMany(e => e.Images)
                .WithMany(e => e.Items);

            modelBuilder.Entity<Item>()
                .HasMany(e => e.AuctionSessions)
                .WithMany(e => e.Items);

            modelBuilder.Entity<Item>()
                .HasOne(e => e.OngoingSession);

            modelBuilder.Entity<Item>()
                .Property(e => e.ReservePrice)
                .HasDefaultValue(0);

            modelBuilder.Entity<Item>()
                .Property(e => e.Status)
                .HasDefaultValue(ItemStatus.EXAMINATION_PENDING);

            modelBuilder.Entity<User>()
                .Property(e => e.IsVerified)
                .HasDefaultValue(0);

            modelBuilder.Entity<Order>()
                .Property(e => e.TotalCost)
                .HasDefaultValue(0);

            modelBuilder.Entity<Item>()
                .HasMany(e => e.AuctionSessions)
                .WithMany(e => e.Items);

            modelBuilder.Entity<ChatMessage>()
                .Property(e => e.Content)
                .HasDefaultValue(string.Empty);

            modelBuilder.Entity<AuctionSession>()
                .Property(e => e.Status)
                .HasDefaultValue(AuctionSessionStatus.PENDING);

            //modelBuilder.Entity<Bid>().ToTable(tb => tb.HasTrigger("BIDS_PREVENT_LOWER"));

            modelBuilder.Entity<Order>()
                .Property(e => e.Status)
                .HasDefaultValue(OrderStatus.UNPAID);

            modelBuilder.Entity<ItemPayment>()
                .Property(e => e.ExpertPaymentStatus)
                .HasDefaultValue(PaymentStatus.UNPAID);

            modelBuilder.Entity<ItemPayment>()
                .Property(e => e.SellerPaymentStatus)
                .HasDefaultValue(PaymentStatus.UNPAID);

            DbInitializer.Seed(modelBuilder);
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
        public DbSet<ItemPayment> ItemPayments { get; set;}
        public DbSet<StatusChange> StatusChanges { get; set; }
        public DbSet<ChatMessage> ChatMessages { get; set; }
    }
}
