using Microsoft.EntityFrameworkCore;
using cOREsIX.Models;

namespace cOREsIX
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

        }

        public DbSet<Person> People { get; set; }
    }
}
