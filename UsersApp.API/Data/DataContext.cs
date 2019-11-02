using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using UsersApp.API.Models;

namespace UsersApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Value> Values { get; set; }
        
    }
}