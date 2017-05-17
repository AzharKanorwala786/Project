using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Core;
using Data;
using System.Data.Entity;
using System.Data;
using System.Linq;

namespace Test
{
    [TestClass]
    public class ProductRepositoryTest
    {
        ProductRepository Repo;
        [TestInitialize]
        public void TestSetup()
        {
            DBInitalize db = new DBInitalize();
            System.Data.Entity.Database.SetInitializer(db);
            Repo = new ProductRepository();
        }

        //[TestMethod]
        //public void IsRepositoryInitalizeWithValidNumberOfData()
        //{
        //    var result = Repo.GetProducts();
        //    Assert.IsNotNull(result);
        //    var numberOfRecords = result.ToList().Count;
        //    Assert.AreEqual(2, numberOfRecords);
        //}

        //[TestMethod]
        //public void IsRepositoryAddsProduct()
        //{
        //    Product productToInsert = new Product
        //    {
        //        Id = 3,
        //        Name = "Salt",
        //        Price = 17

        //    };
        //    Repo.Add(productToInsert);
        //    // If Product inserts successfully, 
        //    //number of records will increase to 3 
        //    var result = Repo.GetProducts();
        //    var numberOfRecords = result.ToList().Count;
        //    Assert.AreEqual(3, numberOfRecords);
        //}
    }
}
