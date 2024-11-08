using Microsoft.EntityFrameworkCore;
using MyWebApi.Models;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Xml;

namespace MapApi
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)  { }
        public DbSet<PointValue> Points { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<PointValue>()
           .HasKey(e => e.Id);
        }
   

    }

}
