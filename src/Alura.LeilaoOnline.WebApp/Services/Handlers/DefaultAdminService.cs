using Alura.LeilaoOnline.WebApp.Dados;
using Alura.LeilaoOnline.WebApp.Models;
using System.Collections.Generic;

namespace Alura.LeilaoOnline.WebApp.Services.Handlers
{
    public class DefaultAdminService : IAdminService
    {
        private readonly ILeilaoDAO _leilaoDAO;
        private readonly ICategoriaDAO _categoriaDAO;

        public DefaultAdminService(ILeilaoDAO dao)
        {
            _leilaoDAO = dao;
        }

        public void DeleteLeilao(int id)
        {
            _leilaoDAO.Delete(GetLeilaoById(id));
        }

        public void EndPregao(int leilaoId)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Categoria> GetCategorias()
        {
            return _categoriaDAO.List();
        }

        public Leilao GetLeilaoById(int id)
        {
            return _leilaoDAO.GetById(id);
        }

        public IEnumerable<Leilao> GetLeiloes()
        {
            return _leilaoDAO.List();
        }

        public void InsertLeilao(Leilao leilao)
        {
            _leilaoDAO.Add(leilao);
        }

        public void StartPregao(int leilaoId)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateLeilao(Leilao leilao)
        {
            _leilaoDAO.Edit(leilao);
        }
    }
}
