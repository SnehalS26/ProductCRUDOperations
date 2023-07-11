using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductOperations
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

    }

    public class ProductCRUD
    {

        private List<Product> products;
        public ProductCRUD()
        {
            products = new List<Product>();
        }
        // OR
        // private List<Product> List { set; get; }

        public void AddProduct(Product prod)
        {
            products.Add(prod);
        }

        public List<Product> GetProducts()
        {
            return products;
        }

        public void UpdateProduct(Product prod)
        {
            foreach (Product p in products)
            {
                if (p.Id == prod.Id)
                {
                    // p-->old data in collection
                    p.Name = prod.Name;//prod  -- ,new data
                    p.Price = prod.Price;
                    break;
                }
            }
        }
        public void DeleteProduct(int id)
        {
            foreach (Product p in products)
            {
                if (p.Id == id)
                {
                    products.Remove(p);
                    break;
                }
            }
        }


    }
}
