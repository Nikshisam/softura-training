using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Product_Table_Task.Models;



namespace Product_Table_Task.Models
{
    public class ProductDBContext : DbContext
    {

        public ProductDBContext()

        {
        }

        public ProductDBContext(DbContextOptions<ProductDBContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        {
            optionsBuilder.UseSqlServer(@"Data Source = LAPTOP - FUS4MA7U; Initial Catalog = Trial; Integrated Security = True; Persist Security Info = False; Pooling = False; MultipleActiveResultSets = False; Encrypt = False; TrustServerCertificate = False");
        }
        public DbSet<Product_Table_Task.Models.Product> Product { get; set; }
    }
}
