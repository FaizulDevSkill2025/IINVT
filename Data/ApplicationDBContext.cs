using IINVT.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace IINVT.Data
{
    public class ApplicationDbContext:IdentityDbContext<Users>
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) { }
        public virtual DbSet<Customer> customer{ get; set; }
        public virtual DbSet<Supplier> supplier { get; set; }
        public virtual DbSet<Item> item { get; set; }
    }
}
