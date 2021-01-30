using DateAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DateAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;

        public InMemoryProductDal()
        {
            _products = new List<Product> {
            
                new Product{ProductId=1, CatatgoryId=1, ProductName="Kitap", UnitPrice=15, UnitsInStock=15},
                new Product{ProductId=1, CatatgoryId=2, ProductName="Kamera", UnitPrice=500, UnitsInStock=3},
                new Product{ProductId=1, CatatgoryId=3, ProductName="Telefon", UnitPrice=1500, UnitsInStock=2},
                new Product{ProductId=1, CatatgoryId=4, ProductName="Kumanda", UnitPrice=150, UnitsInStock=65},
                new Product{ProductId=1, CatatgoryId=5, ProductName="Bardak", UnitPrice=85, UnitsInStock=1},

            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            
            Product productToDelete = _products.SingleOrDefault(p=> p.ProductId == product.ProductId);

            _products.Remove(productToDelete);


        }

        public List<Product> GetAll()
        {
            return _products;


        }

        public List<Product> GetAllByCatagory(int catagoryId)
        {
            return _products.Where(p => p.CatatgoryId == catagoryId).ToList();

        }

        public void Update(Product product)
        {
            //Gönderdiğim ürün Id'sine sahip olan listedeki ürünü bul
            Product productToUptade = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUptade.ProductName = product.ProductName;
            productToUptade.CatatgoryId = product.CatatgoryId;
            productToUptade.UnitPrice = product.UnitPrice;
            productToUptade.UnitsInStock = product.UnitsInStock;


        }
    }
}
