using SistemaVendas.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SistemaVendas.Services.Exceptions;

namespace SistemaVendas.Services
{
    public class SellerService
    {
        private readonly SistemaVendasContext _context;
        public SellerService(SistemaVendasContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
        public void Insert(Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
        public Seller FindById(int id)
        {
            return _context.Seller.Include(obj => obj.Department).FirstOrDefault(obj => obj.Id == id);
        }
        public void Remove(int id)
        {
            var obj = _context.Seller.Find(id);
            _context.Seller.Remove(obj);
            _context.SaveChanges();
        }
        public void Update(Seller obj)
        {
            if(!_context.Seller.Any(x => x.Id == obj.Id))
            {
                throw new NotFoundExceptions("Vendedor não existe!");
            }
            try { 
            _context.Update(obj);
            _context.SaveChanges();
            }
            catch (DbConcurrencyExceptions e)
            {
                throw new DbConcurrencyExceptions(e.Message);
            }
        }
    }

}
