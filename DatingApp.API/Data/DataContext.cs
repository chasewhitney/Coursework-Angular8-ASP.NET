using Microsoft.EntityFrameworkCore; // use nuget to import so we can use DbContext
using DatingApp.API.Models;

namespace DatingApp.API.Data
{
    // new class DataContext is derived from DbContext
    public class DataContext : DbContext
    {
        // Constructor, DbContextOptions<(Type/Class we'er using)> options
        // and call into class we're deriving from, and call ITs options
        public DataContext(DbContextOptions<DataContext> options) : base(options){}

        public DbSet<Value> Values { get; set; }
        public DbSet<User> Users { get; set; }
    }
}