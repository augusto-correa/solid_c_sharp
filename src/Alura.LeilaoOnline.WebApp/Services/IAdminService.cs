using Alura.LeilaoOnline.WebApp.Models;
using System.Collections.Generic;

namespace Alura.LeilaoOnline.WebApp.Services
{
    public interface IAdminService
    {
        IEnumerable<Categoria> GetCategorias();
        IEnumerable<Leilao> GetLeiloes();
        Leilao GetLeilaoById(int id);
        void InsertLeilao(Leilao leilao);
        void UpdateLeilao(Leilao leilao);
        void DeleteLeilao(int id);
        void StartPregao(int leilaoId);
        void EndPregao(int leilaoId);
    }
}
