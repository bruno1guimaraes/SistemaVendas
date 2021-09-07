using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaVendas.Models;
using SistemaVendas.Models.Enums;

namespace SistemaVendas.Data
{
    public class SeedingService
    {
        private SistemaVendasContext _context;

        public SeedingService(SistemaVendasContext context)
        {
            _context = context;
        }
        public void Seed()
        {
            if (_context.Department.Any() || _context.SalesRecord.Any() || _context.Seller.Any())
            {
                return; //banco de dados já tem informações
            }
            Department D1 = new Department(1, "Computers");
            Department D2 = new Department(2, "Electronics");
            Department D3 = new Department(3, "Fashion");
            Department D4 = new Department(4, "Books");

            Seller S1 = new Seller(1, "Ana", "ana@email.com", new DateTime(1998, 04, 21), 1000, D1);
            Seller S2 = new Seller(2, "Maria", "maria@email.com", new DateTime(1980, 08, 17), 3500, D2);
            Seller S3 = new Seller(3, "Alex", "alex@email.com", new DateTime(1988, 01, 15), 2200, D1);
            Seller S4 = new Seller(4, "Martha", "martha@email.com", new DateTime(1990, 11, 30), 3000, D4);
            Seller S5 = new Seller(5, "Julia", "julia@email.com", new DateTime(1975, 01, 09), 4000, D3);
            Seller S6 = new Seller(6, "Alice", "alice@email.com", new DateTime(1997, 03, 04), 3000, D2);

            SalesRecord r1 = new SalesRecord(1, new DateTime(2021, 01, 18), 15000, SaleStatus.Billed, S1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2021, 01, 23), 13000, SaleStatus.Billed, S6);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2021, 02, 7), 12000, SaleStatus.Billed, S3);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2021, 02, 15), 18000, SaleStatus.Billed, S5);
            SalesRecord r5 = new SalesRecord(5, new DateTime(2021, 02, 28), 9000, SaleStatus.Billed, S2);
            SalesRecord r6 = new SalesRecord(6, new DateTime(2021, 03, 08), 17000, SaleStatus.Billed, S4);
            SalesRecord r7 = new SalesRecord(7, new DateTime(2021, 03, 18), 25000, SaleStatus.Billed, S1);
            SalesRecord r8 = new SalesRecord(8, new DateTime(2021, 04, 5), 2000, SaleStatus.Billed, S2);
            SalesRecord r9 = new SalesRecord(9, new DateTime(2021, 04, 8), 15000, SaleStatus.Billed, S3);
            SalesRecord r10 = new SalesRecord(10, new DateTime(2021, 04, 18), 8000, SaleStatus.Billed, S5);

            _context.Department.AddRange(D1, D2, D3, D4);
            _context.Seller.AddRange(S1, S2, S3, S4, S5, S6);
            _context.SalesRecord.AddRange(r1, r2, r3, r4, r5, r6, r7, r8, r9, r10);

            _context.SaveChanges();
        }
    }
}
