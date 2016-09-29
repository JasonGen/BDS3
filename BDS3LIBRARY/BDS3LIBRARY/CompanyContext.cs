using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDS3LIBRARY
{
    public class CompanyContext  : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public CompanyContext()
            : base(@"Data source=(localdb)\MSSQLLocalDB;Initial Catalog=ConcurrencyDemo;")
        {

        }
    }
}
