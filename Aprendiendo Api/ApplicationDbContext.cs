using Aprendiendo_Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Aprendiendo_Api
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options):base(options)
        {

        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books    { get; set; }
    }
}
