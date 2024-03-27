using Microsoft.EntityFrameworkCore;

namespace StoreaApp.Models
{
    public class RepositoryContexts:DbContext
    {
        public DbSet<Product>? Products { get; set; }

        public RepositoryContexts(DbContextOptions<RepositoryContexts> options ):base( options )
        {
            
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>()
                .HasData(

                new Product() { ProductId = 1, Price = 3, ProductName = "kuku" },
                new Product() { ProductName="huhuhu",Price=4,ProductId=2},
                new Product() { ProductName="dsfsdf", Price = 3, ProductId = 3 },
                new Product() { ProductName="sdfdsfds",Price=6,ProductId=4},
                new Product() { ProductName="fghfghfg", Price = 7, ProductId = 5 },
                new Product() { ProductName="fghfghgfh", Price = 8, ProductId = 6 },
                new Product() { ProductName="erterteret", Price = 4, ProductId = 7 }
                );                                                     
                                                                       
        }                                                              
    }

}
