using Microsoft.EntityFrameworkCore;
using OrdersWebAPI.Models;

namespace OrdersWebAPI.Contexts
{
    public class CollectionContext:DbContext{
    public DbSet<Order> Orders {get;set;}
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string conString="server=127.0.0.1;Uid=root;database=tap;Pwd=Know@9999#";
        optionsBuilder.UseMySQL(conString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Order>(entity => 
        {
          entity.HasKey(e => e.Id);
          entity.Property(e => e.CustomerId).IsRequired();
          entity.Property(e => e.TotalAmount).IsRequired();
          entity.Property(e => e.Status).IsRequired();
          entity.Property(e => e.OrderDate).IsRequired();
        });
    }
    }
}