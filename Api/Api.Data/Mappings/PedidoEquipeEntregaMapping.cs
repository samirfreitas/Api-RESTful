using Api.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Api.Data.Mappings
{
    public class PedidoEquipeEntregaMapping : IEntityTypeConfiguration<PedidoEquipeEntrega>
    {
        public void Configure(EntityTypeBuilder<PedidoEquipeEntrega> builder)
        {
            builder.HasKey(p => p.Id);
            
            builder.Property(a => a.Nome)
                .IsRequired()
                .HasColumnType("varchar(200)");
            
            builder.Property(a => a.Descricao)
               .IsRequired()
               .HasColumnType("varchar(500)");

            builder.Property(a => a.PlacaVeiculo)
              .IsRequired()
              .HasColumnType("varchar(8)");
        }
    }
}
