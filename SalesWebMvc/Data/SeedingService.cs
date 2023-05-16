using SalesWebMvc.Models;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Data
{
    public class SeedingService
    {
        private SalesWebMvcContext _context;

        public SeedingService(SalesWebMvcContext context)
        {
            _context = context;
        }
        public void Seed()
        {
            if(_context.Department.Any() || _context.Seller.Any() || _context.SalesRecords.Any())
            {
                return; // DB has been seeded
            }

            Department d1 = new Department(1, "Computers");
            Department d2 = new Department(2, "Eletronics");
            Department d3 = new Department(3, "Fashion");
            Department d4 = new Department(4, "Books");

            Seller s1 = new Seller(1, "Bob Brown", "bob@gmail.com", new DateTime(2004, 5, 10), 10000.0, d1);
            Seller s2 = new Seller(2, "Maria Green", "maria@gmail.com", new DateTime(2004, 6, 12), 10000.0, d2);
            Seller s3 = new Seller(3, "Alex Grey", "alex@gmail.com", new DateTime(2004, 1, 20), 10000.0, d3);
            Seller s4 = new Seller(4, "Martha Red", "martha@gmail.com", new DateTime(2004, 5, 5), 10000.0, d2);
            Seller s5 = new Seller(5, "Donald Blue", "donald@gmail.com", new DateTime(2004, 3, 3), 10000.0, d1);
            Seller s6 = new Seller(6, "Alex Pink", "bob@gmail.com", new DateTime(2004, 3, 2), 10000.0, d4);


            SalesRecord r1 = new SalesRecord(1, new DateTime(2020, 09, 25), 10000.0, SaleStatus.Billed, s1);

            _context.Department.AddRange(d1, d2, d3, d4);
            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);
            _context.SalesRecords.Add(r1);


            _context.SaveChanges();


        }
    }
}
