using System.Linq;
using Microsoft.EntityFrameworkCore;
using ProjetoSelenium.Core;

namespace ProjetoSelenium.Dados.Repositorio
{
  public class RepositorioUsuario : RepositorioBase<Usuario>
    {
        public RepositorioUsuario(LeiloesContext ctx) : base(ctx)
        {

        }

        public override Usuario BuscarPorId(int id)
        {
            return _ctx.Usuarios
                .Include(u => u.Interessada)
                .FirstOrDefault(u => u.Id == id);
        }

    }
}
