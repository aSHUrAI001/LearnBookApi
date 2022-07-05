using LearnBookApi.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace LearnBookApi.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }

        public DbSet<Book> Books { get; set; }
    }
}
