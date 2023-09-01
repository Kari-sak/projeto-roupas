using Microsoft.EntityFrameworkCore;
using ProjetoRoupas.Models;

namespace ProjetoRoupas.Persistence
{
    public class OracleDbContext : DbContext

    {
        public DbSet <Roupas> Roupas { get; set; }
        public OracleDbContext(DbContextOptions<OracleDbContext> options) : base(options) 
        { 
        
        }
    }
}
