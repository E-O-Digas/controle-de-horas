using Microsoft.EntityFrameworkCore;
using server.Models;

namespace server.Db{
    public class AppDbContext : DbContext{
        public AppDbContext(DbContextOptions options) : base(options){}

        public DbSet<Recurso> Recursos { get; set; }

    }
    
}