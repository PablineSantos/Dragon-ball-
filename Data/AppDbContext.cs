using Dragon_Ball.Models;
using Microsoft.EntityFrameworkCore;

namespace Dragon_Ball.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        
        public DbSet<Personagem> DBZ { get; set; }
    }
}
