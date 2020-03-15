using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoSelenium.Core;

namespace ProjetoSelenium.Dados.EfConfig
{
    internal class LeilaoEFConfig : IEntityTypeConfiguration<Leilao>
    {
        public void Configure(EntityTypeBuilder<Leilao> builder)
        {
            builder.HasOne<Lance>(l => l.Ganhador);
            builder.Property<EstadoLeilao>(l => l.Estado)
                .HasConversion(e => e.ToString(), e => Enum.Parse<EstadoLeilao>(e));
        }
    }
}