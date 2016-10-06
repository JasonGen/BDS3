using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BDS3LIBRARY;

namespace UnitTestProject1
{
    class DbInitializer : DropCreateDatabaseAlways<CompanyContext>
    {
        protected override void Seed(CompanyContext context)
        {
            Customer customer = new Customer()
            {
                Name = "Alderbert Mathias",
                AddressLine1 = "Rue des prisonniers, 22",
                City = "Wepion",
                Country = "Belgique",
                EMail = "Ahem@gmail.com",
                Id = 3,
                Remark = "PAs de remarques",
                PostCode = "5640"
            };
            context.Customers.Add(customer);
            context.SaveChanges();
          
        }

    }
}
