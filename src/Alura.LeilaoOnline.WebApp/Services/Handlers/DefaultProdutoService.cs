using Alura.LeilaoOnline.WebApp.Dados;
using Alura.LeilaoOnline.WebApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace Alura.LeilaoOnline.WebApp.Services.Handlers
{
    public class DefaultProdutoService : IProdutoService
    {
        ICategoriaDAO _categoryDAO;
        ILeilaoDAO _leilaoDAO;
        public DefaultProdutoService(ICategoriaDAO categoriaDAO, ILeilaoDAO leilaoDAO)
        {
            _categoryDAO = categoriaDAO;
            _leilaoDAO = leilaoDAO;
        }

        public Categoria GetCategoria(int id)
        {
            return _categoryDAO.GetById(id);
        }

        public IEnumerable<CategoriaComInfoLeilao> GetCategoriasComInfoLeilao()
        {
            return _categoryDAO.List()
                .Select(c => new CategoriaComInfoLeilao
                {
                    Id = c.Id,
                    Descricao = c.Descricao,
                    Imagem = c.Imagem,
                    EmRascunho = c.Leiloes.Where(l => l.Situacao == SituacaoLeilao.Rascunho).Count(),
                    EmPregao = c.Leiloes.Where(l => l.Situacao == SituacaoLeilao.Pregao).Count(),
                    Finalizados = c.Leiloes.Where(l => l.Situacao == SituacaoLeilao.Finalizado).Count(),
                });
        }

        public IEnumerable<Leilao> QueryLeiloes(string query)
        {
            var queryNormalized = query.ToUpper();
            return _leilaoDAO.List().Where(c =>
                    c.Titulo.ToUpper().Contains(query) ||
                    c.Descricao.ToUpper().Contains(query) ||
                    c.Categoria.Descricao.ToUpper().Contains(query));
        }
    }
}
