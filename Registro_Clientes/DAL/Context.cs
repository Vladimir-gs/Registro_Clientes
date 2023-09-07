using Microsoft.EntityFrameworkCore;
using Registro_Clientes.Models;

namespace Registro_Clientes.DAL
{
    public class Context : DbContext
    {
        public DbSet<Clientes> Clientes { get; set; }

        public Context(DbContextOptions<Context> options) : base(options) { }

    }
}
