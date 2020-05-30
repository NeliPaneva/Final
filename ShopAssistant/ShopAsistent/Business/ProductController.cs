using ShopAsistent.Data;
using ShopAsistent.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShopAsistent.Business
{
    public class ProductController
    {
        private ShopContext context;
        public ProductController()
        {
            this.context = new ShopContext();
        }
        public List<Product> GetAll()
        {
            return context.Products.ToList();
        }
        public Product Get(int id)
        {
            var product = this.context.Products.FirstOrDefault(x => x.Id == id);
            return product;
        }
        public void Add(Product product)
        {
            this.context.Products.Add(product);
            this.context.SaveChanges();
        }
        public void Update(Product product)
        {
            var productItem = this.Get(product.Id);
            this.context.Entry(productItem).CurrentValues.SetValues(product);
            this.context.SaveChanges();
        }
        public void Delete(int id)
        {
            var productItem = this.Get(id);
            this.context.Products.Remove(productItem);
            this.context.SaveChanges();
        }

    }
}
