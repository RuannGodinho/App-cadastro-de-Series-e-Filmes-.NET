using System.Collections.Generic;
namespace DIO.Series.Interfaces
{
    public interface BRepositorio<U>
    {
         List<U> Lista();
        U RetornaPorId(int id);
        void Insere(U entidade);
        void Exclui(int id);
        void Atualiza(int id, U entidade);
        int ProximoId();
         
    }
}