using Microsoft.EntityFrameworkCore;
using Api.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mappings
{
    public class PedidoMapping : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.HasKey(p => p.Id);

            builder.HasOne(p => p.Endereco)
                .WithOne(e => e.Pedido);

            builder.HasOne(p => p.EquipeEntrega)
                .WithOne(e => e.Pedido);

            builder.HasMany(p => p.PedidoItems)
                .WithOne(i => i.Pedido)
                .HasForeignKey(p => p.PedidoId);

          
        }
    }
}
