using Alura.LeilaoOnline.WebApp.Models;
using System.Collections.Generic;

namespace Alura.LeilaoOnline.WebApp.Dados
{
    public interface ICategoriaDAO
    {
        IEnumerable<Categoria> List();

        Categoria GetById(int id);

        void Add(Categoria categoria);

        void Edit(Categoria categoria);

        void Delete(Categoria categoria);
    }
}
