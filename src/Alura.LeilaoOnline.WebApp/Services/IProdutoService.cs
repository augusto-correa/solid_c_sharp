using Alura.LeilaoOnline.WebApp.Models;
using System.Collections.Generic;

namespace Alura.LeilaoOnline.WebApp.Services
{
    public interface IProdutoService
    {
        IEnumerable<Leilao> QueryLeiloes(string query);
        IEnumerable<CategoriaComInfoLeilao> GetCategoriasComInfoLeilao();
        Categoria GetCategoria(int id);
    }
}
