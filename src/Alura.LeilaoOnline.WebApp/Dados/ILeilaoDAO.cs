using Alura.LeilaoOnline.WebApp.Models;
using System.Collections.Generic;

namespace Alura.LeilaoOnline.WebApp.Dados
{
    public interface ILeilaoDAO
    {
        IEnumerable<Leilao> List();

        Leilao GetById(int id);

        void Add(Leilao leilao);

        void Edit(Leilao leilao);

        void Delete(Leilao leilao);
    }
}
