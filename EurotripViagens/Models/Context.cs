using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EurotripViagens.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        { }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Viagem> Viagens { get; set; }

        public DbSet<Contato> Contatos { get; set; }
    }
}
