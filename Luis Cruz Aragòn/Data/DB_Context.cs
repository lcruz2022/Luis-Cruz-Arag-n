using Luis_Cruz_Aragon.Models;
using Microsoft.EntityFrameworkCore;

namespace Luis_Cruz_Aragòn.Data
{
    public class DB_Context: DbContext
    {
        public DB_Context(DbContextOptions<DB_Context> options) : base(options)
        {

        }
        public DbSet<ClassCliente> clientes { get; set; }
    }
}
