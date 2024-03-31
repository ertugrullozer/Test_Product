using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Contcrete
{
    public class Context:IdentityDbContext//ıdentity db contexten de miras alıyor bunu yazmamız yeterli
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-62HEUCO\\SQLEXPRESS;database=DbNewOopCore1;integrated security=true;TrustServerCertificate=True;");
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Jop>Jops { get; set; }//ilişkili tabloyu ekliyoruz
    }
}
