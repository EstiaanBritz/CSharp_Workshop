using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Data
{
    public class TestDB:DbContext
    {
        public TestDB(DbContextOptions options):base(options)
        {
        }


        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<ProductColor> ProductColors { get; set; }





        /* this is how to put an actual database
         protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product() { Id = 1, Created = DateTime.Now });
        }*/
    }
}
