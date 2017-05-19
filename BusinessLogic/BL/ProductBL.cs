using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Models;
using BusinessLogic.Interfaces;
using Core.Interfaces;
using Core.ViewModels;

namespace BusinessLogic.BL
{
   public class ProductBL : GenericBL<Product>,IProductBL
    {
        public ProductBL(IUOW UnitOfWork) : base(UnitOfWork)
        {
        }

        public void AddProduct(ProductCreate collection)
        {
            throw new NotImplementedException();
        }

        public void DeleteProduct(int Id)
        {
            throw new NotImplementedException();
        }

        public ProductList DisplayProductDetails(int CategoryId = 0)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public ProductDetails GetProductDetails(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetProductsByCategoryId(int CategoryId)
        {
            throw new NotImplementedException();
        }

        public ProductCreate ProductCreate(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct(ProductCreate collection)
        {
            throw new NotImplementedException();
        }
    }
}
