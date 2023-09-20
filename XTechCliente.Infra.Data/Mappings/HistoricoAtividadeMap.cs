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
    public class HistoricoAtividadeMap : IEntityTypeConfiguration<HistoricoAtividade>
    {
        public void Configure(EntityTypeBuilder<HistoricoAtividade> builder)
        {
            builder.ToTable("HISTORICOATIVIDADE");

            builder.HasKey(h => h.Id);

            builder.Property(h => h.Id).HasColumnName("ID");
            builder.Property(h => h.DataHora).HasColumnName("DATAHORA").IsRequired();
            builder.Property(h => h.Tipo).HasColumnName("TIPO").IsRequired();
            builder.Property(h => h.Descricao).HasMaxLength(250).IsRequired();
        }
    }
}
