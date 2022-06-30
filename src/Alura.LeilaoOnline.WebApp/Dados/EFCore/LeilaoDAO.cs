using Alura.LeilaoOnline.WebApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Alura.LeilaoOnline.WebApp.Dados.EFCore
{
    public class LeilaoDAOEFCore : ILeilaoDAO
    {
        private readonly AppDbContext _context;
        public LeilaoDAOEFCore()
        {
            _context = new AppDbContext();
        }

        public IEnumerable<Leilao> List()
        {
            return _context.Leiloes.Include(l => l.Categoria).ToList();
        }

        public Leilao GetById(int id)
        {
            return _context.Leiloes.Find(id);
        }

        public void Add(Leilao leilao)
        {
            _context.Leiloes.Add(leilao);
            _context.SaveChanges();
        }

        public void Edit(Leilao leilao)
        {
            _context.Leiloes.Update(leilao);
            _context.SaveChanges();
        }

        public void Delete(Leilao leilao)
        {
            _context.Leiloes.Remove(leilao);
            _context.SaveChanges();
        }

        public IEnumerable<Categoria> ListCategorias()
        {
            return _context.Categorias.ToList();
        }
    }
}
