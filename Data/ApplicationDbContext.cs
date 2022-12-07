using BTLNHOM29.Models;
using Microsoft.EntityFrameworkCore;


namespace BTLNHOM29.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) : base(options)
        {
        }
        public DbSet<BTLNHOM29.Models.Student> Students {get; set;}
        public DbSet<BTLNHOM29.Models.Employee> Employee { get; set;}
        public DbSet<BTLNHOM29.Models.Faculty> Faculty { get; set; } = default!;
    }
}