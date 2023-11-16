using Azure.Core;
using Microsoft.EntityFrameworkCore;
using RequestService.Models;

namespace RequestService.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<UserRequest> Requests { get; set; }
    }
}