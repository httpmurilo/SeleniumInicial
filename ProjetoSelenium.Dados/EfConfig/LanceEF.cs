using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoSelenium.Core;

namespace ProjetoSelenium.Dados.EfConfig
{
    internal class LanceEFConfig : IEntityTypeConfiguration<Lance>
    {
        public void Configure(EntityTypeBuilder<Lance> builder)
        {
            builder.HasOne<Leilao>(lance => lance.Leilao)
                .WithMany(leilao => leilao.Lances);
            builder.HasOne<Interessada>(lance => lance.Cliente)
                .WithMany(i => i.Lances);
        }
    }
}