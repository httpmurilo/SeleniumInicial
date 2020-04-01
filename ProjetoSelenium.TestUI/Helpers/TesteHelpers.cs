using System.IO;
using System.Reflection;

namespace ProjetoSelenium.TestUI.Helpers
{
    public static  class TesteHelpers
    {
        public static string PastaDoExecutavel => Path.GetDirectoryName
            (Assembly.GetExecutingAssembly().Location);
    }
}