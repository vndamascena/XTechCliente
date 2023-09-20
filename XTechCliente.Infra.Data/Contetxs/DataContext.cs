using XTechCliente.Domain.Entities;
using XTechCliente.Infra.Data.Mappings;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XTechCliente.Infra.Data.Contetxs
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BDXTechCliente;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new HistoricoAtividadeMap());
            modelBuilder.ApplyConfiguration(new ClienteMap());
        }

        public DbSet<HistoricoAtividade> HistoricoAtividades { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
    }
    
}
