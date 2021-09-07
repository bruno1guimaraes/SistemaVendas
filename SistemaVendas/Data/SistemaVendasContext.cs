using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SistemaVendas.Models
{
    public class SistemaVendasContext : DbContext
    {
        public SistemaVendasContext (DbContextOptions<SistemaVendasContext> options)
            : base(options)
        {
        }

        public DbSet<SistemaVendas.Models.Department> Department { get; set; }
    }
}
