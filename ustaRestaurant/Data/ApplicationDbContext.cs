using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ustaRestaurant.Models;
namespace ustaRestaurant.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<OrderDetail>().HasKey(od => new
            {
                od.ProductId,
                od.OrderId,
                od.TicketId
            });

            modelBuilder.Entity<OrderDetail>()
                .HasOne(p => p.Product)
                .WithMany(od => od.OrderDetails)
                .HasForeignKey(p => p.ProductId);

            modelBuilder.Entity<OrderDetail>()
                .HasOne(o => o.Order)
                .WithMany(od => od.OrderDetails)
                .HasForeignKey(o=> o.OrderId);

            modelBuilder.Entity<OrderDetail>()
                .HasOne(t => t.Ticket)
                .WithMany(od => od.OrderDetails)
                .HasForeignKey(t => t.TicketId);

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Delivery> Deliveries { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<OrderDetail> OrderDetails  { get; set; }
        
    }
    
}