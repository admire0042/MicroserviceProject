using Catalog.API.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.API.Data
{
    public class CatalogContextSeed
    {
        public static void SeedData(IMongoCollection<Product> productCollection)
        {
            bool existProduct = productCollection.Find(p => true).Any();

            if (!existProduct)
            {
                productCollection.InsertManyAsync(GetPreconfiguredProducts());
            };
        }

        private static IEnumerable<Product> GetPreconfiguredProducts()
        {
            return new List<Product>()
            {
                new Product()
                {
                    Id = "602d2149e773f2a3990b47f5",
                    Name = "IPhone X",
                    Summary = "This phone is the company's biggest change to its flagship smartphone in years",
                    Description = "Lorem ipsum colon sit amet",
                    ImageFile = "product-1.png",
                    Price = 950.00M,
                    Category = "Smart Phone"
                },
                 new Product()
                {
                    Id = "602d2149e773f2a3990b47f6",
                    Name = "Samsung 10",
                    Summary = "This phone is the company's biggest change to its flagship smartphone in years",
                    Description = "Lorem ipsum colon sit amet",
                    ImageFile = "product-2.png",
                    Price = 840.00M,
                    Category = "Smart Phone"
                },
                  new Product()
                {
                    Id = "602d2149e773f2a3990b47f7",
                    Name = "Huawei Plus",
                    Summary = "This phone is the company's biggest change to its flagship smartphone in years",
                    Description = "Lorem ipsum colon sit amet",
                    ImageFile = "product-3.png",
                    Price = 950.00M,
                    Category = "Smart Phone"
                },
                   new Product()
                {
                    Id = "602d2149e773f2a3990b47f8",
                    Name = "Xiaomi Mi 9",
                    Summary = "This phone is the company's biggest change to its flagship smartphone in years",
                    Description = "Lorem ipsum colon sit amet",
                    ImageFile = "product-3.png",
                    Price = 950.00M,
                    Category = "Smart Phone"
                },
                   new Product()
                {
                    Id = "602d2149e773f2a3990b47f9",
                    Name = "Dunlop Eltes",
                    Summary = "This phone is the company's biggest change to its flagship tyre in years",
                    Description = "Lorem ipsum colon sit amet",
                    ImageFile = "product-4.png",
                    Price = 470.00M,
                    Category = "Tyre"
                },
                   new Product()
                {
                    Id = "602d2149e773f2a3990b47f4",
                    Name = "HTC U11+ Plus",
                    Summary = "This phone is the company's biggest change to its flagship smartphone in years",
                    Description = "Lorem ipsum colon sit amet",
                    ImageFile = "product-5.png",
                    Price = 470.00M,
                    Category = "Smart Phone"
                }
            };
        }
    }
}
