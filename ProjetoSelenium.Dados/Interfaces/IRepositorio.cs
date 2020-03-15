using System.Collections.Generic;

namespace ProjetoSelenium.Dados.Interfaces
{
   public interface IRepositorio<T> where T : class
    {
        IEnumerable<T> Todos { get; }
        void Incluir(T obj);
        void Alterar(T obj);
        void Excluir(T obj);
        T BuscarPorId(int id);
    }
}
