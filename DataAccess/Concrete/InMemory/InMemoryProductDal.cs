using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product>
            {
                new Product{CategoryId=1,ProductId=1,ProductName="Bardak",UnitInStock=15,UnitPrice=15},
                 new Product{CategoryId=1,ProductId=2,ProductName="Kamera",UnitInStock=15,UnitPrice=15},
                  new Product{CategoryId=2,ProductId=3,ProductName="Telefom",UnitInStock=15,UnitPrice=15},
                   new Product{CategoryId=2,ProductId=4,ProductName="Mouse",UnitInStock=15,UnitPrice=15},
                    new Product{CategoryId=2,ProductId=5,ProductName="Tablet",UnitInStock=15,UnitPrice=15}
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
           
            Product productToDelete = _products.SingleOrDefault(p=>p.ProductId==product.ProductId);

            _products.Remove(productToDelete);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
          return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.UnitInStock = product.UnitInStock;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.CategoryId = product.CategoryId;
        }
    }
}
