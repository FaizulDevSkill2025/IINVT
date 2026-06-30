using Microsoft.EntityFrameworkCore;

namespace IINVT.Data
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext(DbContextOptions options) : base(options) { }
    }
}
