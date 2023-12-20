using XTechCliente.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XTechCliente.Infra.Data.Mappings
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("CLIENTE");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).HasColumnName("ID");
            builder.Property(c => c.Nome).HasColumnName("NOME").HasMaxLength(100).IsRequired();
            builder.Property(c => c.Email).HasColumnName("E-MAIL").IsRequired();
            builder.HasIndex(u => u.Email).IsUnique();

            builder.Property(c => c.Cpf).HasColumnName("CPF").IsRequired().HasMaxLength(11);
            builder.HasIndex(a => a.Cpf).IsUnique();
            builder.Property(c => c.DataNascimento).HasColumnName("DATANASCIMENTO").IsRequired();
            builder.Property(c => c.DataCriacao).HasColumnName("DATACRIACAO").IsRequired();
            builder.Property(c => c.DataAtualizacao).HasColumnName("DATAULTIMAATUALIZACAO").IsRequired();
        }
    }
}
