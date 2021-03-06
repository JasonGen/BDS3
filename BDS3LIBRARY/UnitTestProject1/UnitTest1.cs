﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.Entity;
using BDS3LIBRARY;
using System.Linq;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestInitialize]
        public void InsertionFonctionnelle()
        {
            Database.SetInitializer(new DbInitializer());
            using (CompanyContext context = GetContext())
            {
                context.Database.Initialize(true);
            }
        }
        [TestMethod]
        public void CanGetCustomers()
        {
            using (var context = GetContext())
            {
                Assert.AreEqual(1, context.Customers.ToList().Count);
            }
        }

        private CompanyContext GetContext()
        {
            return new CompanyContext();
        }
    }
}
