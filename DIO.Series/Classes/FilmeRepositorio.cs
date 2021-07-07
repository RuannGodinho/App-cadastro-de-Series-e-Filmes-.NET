using System;
using System.Collections.Generic;
using DIO.Series.Interfaces;

namespace DIO.Series
{
    public class FilmeRepositorio : BRepositorio<Filme>
    {
        private List<Filme> ListaFilme = new List<Filme>();
        public void Atualiza(int id, Filme objeto)
        {
            ListaFilme[id] = objeto;
        }

        public void Exclui(int id)
        {
            ListaFilme[id].Excluir();
        }

        public void Insere(Filme objeto)
        {
            ListaFilme.Add(objeto);
        }

        public List<Filme> Lista()
        {
            return ListaFilme;
        }

        public int ProximoId()
        {
            return ListaFilme.Count;
        }

        public Filme RetornaPorId(int id)
        {
            return ListaFilme[id];
        }
    }
}
        
    
