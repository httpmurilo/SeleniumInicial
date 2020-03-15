using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using ProjetoSelenium.Core;
using ProjetoSelenium.WebApp.ExTensions;

namespace Alura.LeilaoOnline.WebApp.Filtros
{
    public class AutorizacaoFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var usuarioLogado = context.HttpContext.Session.Get<Usuario>("usuarioLogado");
            if (usuarioLogado == null)
            {
                context.Result = new RedirectToActionResult("Login", "Autenticacao", null);
            }
        }
    }
}
