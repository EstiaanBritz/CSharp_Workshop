namespace WebApplication1.Data
{
    public class FakeDB
    {
        public List<Product> Products { get; set; } = new List<Product>();

        public FakeDB()
        {
            Product product1 = new Product
            {
                Id = 1,
                Name = "Product1",
                Description = "Description for Product1",
                Price = 19.99,
                PackQuantity = 10,
                BrandName = "Brand1",
                Length = 5.0,
                Weight = 2.5,
                Category = new Category { Name = "Category1" },
                ProductColors = new List<ProductColor> { new ProductColor { ColorName = "Red" }, new ProductColor { ColorName = "Blue" } },
                Created = DateTime.Now,
                Updated = DateTime.Now,
                Deleted = false
            };
            Products.Add(product1);

            Product product2 = new Product
            {
                Id = 2,
                Name = "Product2",
                Description = "Description for Product2",
                Price = 29.99,
                PackQuantity = 15,
                BrandName = "Brand2",
                Length = 6.0,
                Weight = 3.0,
                Category = new Category { Name = "Category2" },
                ProductColors = new List<ProductColor> { new ProductColor { ColorName = "Green" }, new ProductColor { ColorName = "Purple" } },
                Created = DateTime.Now,
                Updated = DateTime.Now,
                Deleted = false
            };
            Products.Add(product2);

            Product product3 = new Product
            {
                Id = 3,
                Name = "Product3",
                Description = "Description for Product3",
                Price = 39.99,
                PackQuantity = 20,
                BrandName = "Brand3",
                Length = 7.0,
                Weight = 3.5,
                Category = new Category { Name = "Category3" },
                ProductColors = new List<ProductColor> { new ProductColor { ColorName = "Blue" }, new ProductColor { ColorName = "Red" } },
                Created = DateTime.Now,
                Updated = DateTime.Now,
                Deleted = false
            };
            Products.Add(product3);

            Product product4 = new Product
            {
                Id = 4,
                Name = "Product4",
                Description = "Description for Product4",
                Price = 49.99,
                PackQuantity = 25,
                BrandName = "Brand4",
                Length = 8.0,
                Weight = 4.0,
                Category = new Category { Name = "Category4" },
                ProductColors = new List<ProductColor> { new ProductColor { ColorName = "Purple" }, new ProductColor { ColorName = "Green" } },
                Created = DateTime.Now,
                Updated = DateTime.Now,
                Deleted = false
            };
            Products.Add(product4);

            Product product5 = new Product
            {
                Id = 5,
                Name = "Product5",
                Description = "Description for Product5",
                Price = 59.99,
                PackQuantity = 30,
                BrandName = "Brand5",
                Length = 9.0,
                Weight = 4.5,
                Category = new Category { Name = "Category5" },
                ProductColors = new List<ProductColor> { new ProductColor { ColorName = "Red" }, new ProductColor { ColorName = "Blue" } },
                Created = DateTime.Now,
                Updated = DateTime.Now,
                Deleted = false
            };
            Products.Add(product5);

            Product product6 = new Product
            {
                Id = 6,
                Name = "Product6",
                Description = "Description for Product6",
                Price = 69.99,
                PackQuantity = 35,
                BrandName = "Brand1",
                Length = 10.0,
                Weight = 5.0,
                Category = new Category { Name = "Category1" },
                ProductColors = new List<ProductColor> { new ProductColor { ColorName = "Green" }, new ProductColor { ColorName = "Purple" } },
                Created = DateTime.Now,
                Updated = DateTime.Now,
                Deleted = false
            };
            Products.Add(product6);

            Product product7 = new Product
            {
                Id = 7,
                Name = "Product7",
                Description = "Description for Product7",
                Price = 79.99,
                PackQuantity = 40,
                BrandName = "Brand2",
                Length = 11.0,
                Weight = 5.5,
                Category = new Category { Name = "Category2" },
                ProductColors = new List<ProductColor> { new ProductColor { ColorName = "Blue" }, new ProductColor { ColorName = "Red" } },
                Created = DateTime.Now,
                Updated = DateTime.Now,
                Deleted = false
            };
            Products.Add(product7);

            Product product8 = new Product
            {
                Id = 8,
                Name = "Product8",
                Description = "Description for Product8",
                Price = 89.99,
                PackQuantity = 45,
                BrandName = "Brand3",
                Length = 12.0,
                Weight = 6.0,
                Category = new Category { Name = "Category3" },
                ProductColors = new List<ProductColor> { new ProductColor { ColorName = "Purple" }, new ProductColor { ColorName = "Green" } },
                Created = DateTime.Now,
                Updated = DateTime.Now,
                Deleted = false
            };
            Products.Add(product8);

            Product product9 = new Product
            {
                Id = 9,
                Name = "Product9",
                Description = "Description for Product9",
                Price = 99.99,
                PackQuantity = 50,
                BrandName = "Brand4",
                Length = 13.0,
                Weight = 6.5,
                Category = new Category { Name = "Category4" },
                ProductColors = new List<ProductColor> { new ProductColor { ColorName = "Red" }, new ProductColor { ColorName = "Blue" } },
                Created = DateTime.Now,
                Updated = DateTime.Now,
                Deleted = false
            };
            Products.Add(product9);

            Product product10 = new Product
            {
                Id = 10,
                Name = "Product10",
                Description = "Description for Product10",
                Price = 109.99,
                PackQuantity = 55,
                BrandName = "Brand5",
                Length = 14.0,
                Weight = 7.0,
                Category = new Category { Name = "Category5" },
                ProductColors = new List<ProductColor> { new ProductColor { ColorName = "Green" }, new ProductColor { ColorName = "Purple" } },
                Created = DateTime.Now,
                Updated = DateTime.Now,
                Deleted = false
            };
            Products.Add(product10);

            Product product11 = new Product
            {
                Id = 11,
                Name = "Product11",
                Description = "Description for Product11",
                Price = 119.99,
                PackQuantity = 60,
                BrandName = "Brand1",
                Length = 15.0,
                Weight = 7.5,
                Category = new Category { Name = "Category1" },
                ProductColors = new List<ProductColor> { new ProductColor { ColorName = "Blue" }, new ProductColor { ColorName = "Red" } },
                Created = DateTime.Now,
                Updated = DateTime.Now,
                Deleted = false
            };
            Products.Add(product11);

            Product product12 = new Product
            {
                Id = 12,
                Name = "Product12",
                Description = "Description for Product12",
                Price = 129.99,
                PackQuantity = 65,
                BrandName = "Brand2",
                Length = 16.0,
                Weight = 8.0,
                Category = new Category { Name = "Category2" },
                ProductColors = new List<ProductColor> { new ProductColor { ColorName = "Purple" }, new ProductColor { ColorName = "Green" } },
                Created = DateTime.Now,
                Updated = DateTime.Now,
                Deleted = false
            };
            Products.Add(product12);

            Product product13 = new Product
            {
                Id = 13,
                Name = "Product13",
                Description = "Description for Product13",
                Price = 139.99,
                PackQuantity = 70,
                BrandName = "Brand3",
                Length = 17.0,
                Weight = 8.5,
                Category = new Category { Name = "Category3" },
                ProductColors = new List<ProductColor> { new ProductColor { ColorName = "Red" }, new ProductColor { ColorName = "Blue" } },
                Created = DateTime.Now,
                Updated = DateTime.Now,
                Deleted = false
            };
            Products.Add(product13);

            Product product14 = new Product
            {
                Id = 14,
                Name = "Product14",
                Description = "Description for Product14",
                Price = 149.99,
                PackQuantity = 75,
                BrandName = "Brand4",
                Length = 18.0,
                Weight = 9.0,
                Category = new Category { Name = "Category4" },
                ProductColors = new List<ProductColor> { new ProductColor { ColorName = "Green" }, new ProductColor { ColorName = "Purple" } },
                Created = DateTime.Now,
                Updated = DateTime.Now,
                Deleted = false
            };
            Products.Add(product14);

            Product product15 = new Product
            {
                Id = 15,
                Name = "Product15",
                Description = "Description for Product15",
                Price = 159.99,
                PackQuantity = 80,
                BrandName = "Brand5",
                Length = 19.0,
                Weight = 9.5,
                Category = new Category { Name = "Category5" },
                ProductColors = new List<ProductColor> { new ProductColor { ColorName = "Blue" }, new ProductColor { ColorName = "Red" } },
                Created = DateTime.Now,
                Updated = DateTime.Now,
                Deleted = false
            };
            Products.Add(product15);

            Product product16 = new Product
            {
                Id = 16,
                Name = "Product16",
                Description = "Description for Product16",
                Price = 169.99,
                PackQuantity = 85,
                BrandName = "Brand1",
                Length = 20.0,
                Weight = 10.0,
                Category = new Category { Name = "Category1" },
                ProductColors = new List<ProductColor> { new ProductColor { ColorName = "Purple" }, new ProductColor { ColorName = "Green" } },
                Created = DateTime.Now,
                Updated = DateTime.Now,
                Deleted = false
            };
            Products.Add(product16);

            Product product17 = new Product
            {
                Id = 17,
                Name = "Product17",
                Description = "Description for Product17",
                Price = 179.99,
                PackQuantity = 90,
                BrandName = "Brand2",
                Length = 21.0,
                Weight = 10.5,
                Category = new Category { Name = "Category2" },
                ProductColors = new List<ProductColor> { new ProductColor { ColorName = "Red" }, new ProductColor { ColorName = "Blue" } },
                Created = DateTime.Now,
                Updated = DateTime.Now,
                Deleted = false
            };
            Products.Add(product17);
        }
    }
    
}
