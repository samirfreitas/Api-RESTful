using Api.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Api.Data.Mappings
{
    public class PedidoEnderecoMapping : IEntityTypeConfiguration<PedidoEndereco>
    {
        public void Configure(EntityTypeBuilder<PedidoEndereco> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(a => a.Logradouro)
               .IsRequired()
               .HasColumnType("varchar(200)");

            builder.Property(a => a.Numero)
                .IsRequired()
                .HasColumnType("varchar(50)");

            builder.Property(a => a.Estado)
                .IsRequired()
                .HasColumnType("varchar(50)");

            builder.Property(a => a.CEP)
                .IsRequired()
                .HasColumnType("varchar(10)");

            builder.Property(a => a.Cidade)
                .IsRequired()
                .HasColumnType("varchar(100)");


            builder.Property(a => a.Complemento)

                .HasColumnType("varchar(255)");

            builder.Property(a => a.Bairro)
             .IsRequired()
             .HasColumnType("varchar(100)");

        }
    }
}
