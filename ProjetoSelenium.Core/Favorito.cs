namespace ProjetoSelenium.Core
{
    public class Favorito
    {
    public int IdLeilao { get; set; }
    public int IdInteressada { get; set; }
    public Leilao LeilaoFavorito {get;set;}
    public Interessada Seguidor {get;set;}
    }
}