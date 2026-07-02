using Microsoft.EntityFrameworkCore;

namespace IINVT.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) { }
    }
}
