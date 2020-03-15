using System.Linq;
using Microsoft.EntityFrameworkCore;
using ProjetoSelenium.Core;

namespace ProjetoSelenium.Dados.Repositorio
{
    public class RepositorioInteressada : RepositorioBase<Interessada>
    {
        public RepositorioInteressada(LeiloesContext ctx) : base(ctx)
        {

        }

        public override Interessada BuscarPorId(int id)
        {
            return _ctx.Interessada
                .Where(i => i.Id == id)
                .Include(i => i.Favoritos)
                .ThenInclude(f => f.LeilaoFavorito)
                .Include(i => i.Lances)
                .ThenInclude(l => l.Leilao)
                .FirstOrDefault();
        }
    }
}
