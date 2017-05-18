using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Models;


    namespace Core.Interfaces
    {
     public interface IProductRepository
        {
            void Add(Product p);

            void Edit(Product p);

            void Delete(int Id);

            IEnumerable GetProducts();

            Product FindById(int Id);
        }
    }
