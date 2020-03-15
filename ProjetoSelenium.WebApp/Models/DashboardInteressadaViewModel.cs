using System.Collections.Generic;
using ProjetoSelenium.Core;

namespace ProjetoSelenium.WebApp.Models
{
    public class DashboardInteressadaViewModel
    {
        public IEnumerable<Lance> MinhasOfertas { get; set; }
        public IEnumerable<Leilao> LeiloesFavoritos { get; set; }
    }
}
