using Core;
using System.Linq;
using Core.Interfaces;
using System.Collections;
using System.Data.Entity;
using System.Collections.Generic;

namespace Data
{
    public class ProductRepository : IProductRepository
    {
        DataContext context = new DataContext();

        public void Add(Product p)
        {
            context.Product.Add(p);
            context.SaveChanges();
        }

        public void Edit(Product p)
        {
            context.Entry(p).State = System.Data.Entity.EntityState.Modified;
        }

        public Product FindById(int Id)
        {
            var result = (from r in context.Product where r.Id == Id select r).FirstOrDefault();
            return result;
        }

        public IEnumerable GetProducts()
        {
            return context.Product;
        }

        public void Delete(int Id)
        {
            Product p = context.Product.Find(Id);
            context.Product.Remove(p);
            context.SaveChanges();
        }
    }
}
