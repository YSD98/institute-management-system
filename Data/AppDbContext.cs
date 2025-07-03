using Microsoft.EntityFrameworkCore;
using INSTITUTE_MANAGEMENT_SYSTEM.Models;

namespace INSTITUTE_MANAGEMENT_SYSTEM.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<User> Users { get; set; } = null!;
    }
}