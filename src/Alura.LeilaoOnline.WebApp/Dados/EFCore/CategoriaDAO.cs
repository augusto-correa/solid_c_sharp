using Alura.LeilaoOnline.WebApp.Dados;
using Alura.LeilaoOnline.WebApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Alura.CategoriaOnline.WebApp.Dados.EFCore
{
    public class CategoriaDAO : ICategoriaDAO
    {
        private AppDbContext _context;

        public CategoriaDAO(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> List()
        {
            return _context.Categorias.Include(c => c.Leiloes).ToList();
        }

        public Categoria GetById(int id)
        {
            return _context.Categorias.Include(c => c.Leiloes).First(c => c.Id == id);
        }

        public void Add(Categoria Categoria)
        {
            _context.Categorias.Add(Categoria);
            _context.SaveChanges();
        }

        public void Edit(Categoria Categoria)
        {
            _context.Categorias.Update(Categoria);
            _context.SaveChanges();
        }

        public void Delete(Categoria Categoria)
        {
            _context.Categorias.Remove(Categoria);
            _context.SaveChanges();
        }
    }
}
