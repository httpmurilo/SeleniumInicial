using System.Linq;
using Microsoft.EntityFrameworkCore;
using ProjetoSelenium.Core;

namespace ProjetoSelenium.Dados.Repositorio
{
   public class RepositorioLeilao : RepositorioBase<Leilao>
    {
        public RepositorioLeilao(LeiloesContext context): base(context) { }

        public override Leilao BuscarPorId(int id)
        {
            return _ctx.Leiloes
                .Include(l => l.Lances)
                .Include(l => l.Seguidores)
                .FirstOrDefault(l => l.Id == id);
        }
    }
}
