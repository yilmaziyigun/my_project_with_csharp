using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product>
            {
                new Product{CategoryId=1,ProductId=1,ProductName="Bardak",UnitsInStock=15,UnitPrice=15},
                 new Product{CategoryId=1,ProductId=2,ProductName="Kamera",UnitsInStock=15,UnitPrice=15},
                  new Product{CategoryId=2,ProductId=3,ProductName="Telefom",UnitsInStock=15,UnitPrice=15},
                   new Product{CategoryId=2,ProductId=4,ProductName="Mouse",UnitsInStock=15,UnitPrice=15},
                    new Product{CategoryId=2,ProductId=5,ProductName="Tablet",UnitsInStock=15,UnitPrice=15}
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

        public Product Get(Expression<Func<bool>> filte)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
          return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.UnitsInStock = product.UnitsInStock;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.CategoryId = product.CategoryId;
        }
    }
}
