using System.Collections.Generic;

namespace ProductList.Models
    {
    public class ProductRepository
        {
        public static List<Category> GetCategories()
            {
            return new List<Category>
    {
        new Category { Id = 1, Name = "Category 1" },
        new Category { Id = 2, Name = "Category 2" },
        new Category { Id = 3, Name = "Category 3" },
        new Category { Id = 4, Name = "Category 4" },
        new Category { Id = 5, Name = "Category 5" },
    };
            }

        public static List<Product> GetProducts()
            {
            return new List<Product>
    {
        new Product { Id = 1, Name = "Product 1", CategoryId = 1 },
        new Product { Id = 2, Name = "Product 2", CategoryId = 1 },
        new Product { Id = 3, Name = "Product 3", CategoryId = 2 },
        new Product { Id = 4, Name = "Product 4", CategoryId = 3 },
        new Product { Id = 5, Name = "Product 5", CategoryId = 3 },
        new Product { Id = 6, Name = "Product 6", CategoryId = 4 },
        new Product { Id = 7, Name = "Product 7", CategoryId = 4 },
        new Product { Id = 8, Name = "Product 8", CategoryId = 4 },
        new Product { Id = 9, Name = "Product 9", CategoryId = 5 },
        new Product { Id = 10, Name = "Product 10", CategoryId = 5 },
        new Product { Id = 11, Name = "Product 11", CategoryId = 5 },
    };
            }
        }
    }