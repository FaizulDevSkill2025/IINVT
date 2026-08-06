using IINVT.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace IINVT.Data
{
    public class ApplicationDbContext:IdentityDbContext<Users>
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) { }

        public virtual DbSet<Profile> profile { get; set; }
        public virtual DbSet<Customer> customer{ get; set; }
        public virtual DbSet<Supplier> supplier { get; set; }
        public virtual DbSet<Item> item { get; set; }
        public virtual DbSet<Unit> unit { get; set; }
        public virtual DbSet<Category> category { get; set; }
        public virtual DbSet<Subcategory> subcategory { get; set; }
    }
}
