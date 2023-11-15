using DormitoryService.Models;
using Microsoft.EntityFrameworkCore;

namespace DormitoryService.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base (options)
        {
            
        }

        public DbSet<Dormitory> Dormitories { get; set; }
    }
}