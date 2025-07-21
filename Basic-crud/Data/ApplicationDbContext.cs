using Basic_crud.Models;
using Microsoft.EntityFrameworkCore;

namespace Basic_crud.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Student> Students{ get; set; }  // Students is the tb name
    }

}
