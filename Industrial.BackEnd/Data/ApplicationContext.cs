using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Industrial.BackEnd.Models;

    public class ApplicationContext : DbContext
    {
        public ApplicationContext (DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }

    public DbSet<Cart> Cart { get; set; } = default!;
    public DbSet<Category> Category { get; set; } = default!;
    public DbSet<Customer> Customer { get; set; } = default!;
    public DbSet<Order> Order { get; set; } = default!;
    public DbSet<OrderItem> OrderItem { get; set; } = default!;
    public DbSet<Payment> Payment { get; set; } = default!;
    public DbSet<Product> Product { get; set; } = default!;
    public DbSet<Shipment> Shipment { get; set; } = default!;

}
