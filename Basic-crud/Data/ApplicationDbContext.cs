using Microsoft.EntityFrameworkCore;

namespace Basic_crud.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) { }
    }
}
