using AnaLoja.Data.Context;
using AnaLoja.Data.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace AnaLoja.Data.Repository
{
    public class ProdutoRepository
    {
        private readonly LojaContext _context;

        public ProdutoRepository()
        {
            _context = new LojaContext();
        }
        
        public void Salvar(Produto produto)
        {
            _context.Produto.Add(produto);
            _context.SaveChanges();
        }

        public List<Produto> ObterTodos()
        {
            return _context.Produto.ToList();
        }
        public void Atualizar(Produto produto)
        {
            _context.Entry(produto).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Remover(int Id)
        {
            var produto = ObterPorId(Id);
            _context.Produto.Remove(produto);
            _context.SaveChanges();
        }

        public Produto ObterPorId(int? id)
        {
            return _context.Produto.Find(id);
        }
    }
}
