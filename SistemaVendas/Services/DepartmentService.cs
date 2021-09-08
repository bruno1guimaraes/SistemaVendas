using SistemaVendas.Models;
using System.Collections.Generic;
using System.Linq;

namespace SistemaVendas.Services
{
    public class DepartmentService
    {
        private readonly SistemaVendasContext _context;
        public DepartmentService(SistemaVendasContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
