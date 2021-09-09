using Microsoft.EntityFrameworkCore;
using SistemaVendas.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVendas.Services
{
    public class DepartmentService
    {
        private readonly SistemaVendasContext _context;
        public DepartmentService(SistemaVendasContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
