using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Configurations.Seeds
{
    internal class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product { Id = 1, CategoryId = 1, Price = 120, Stock = 20, CreatedDate = DateTime.Now,Name="Rotring Kalem" },
                new Product { Id = 2, CategoryId = 2, Price = 175, Stock = 12, CreatedDate = DateTime.Now, Name = "TYT Matematik Soru Bankası" },
                new Product { Id = 3, CategoryId = 2, Price = 225, Stock = 5, CreatedDate = DateTime.Now, Name = "AYT Biyoloji Soru Bankası" },
                new Product { Id = 4, CategoryId = 3, Price = 100, Stock = 150, CreatedDate = DateTime.Now, Name = "Toprak marka Kareli Defter" }
                );
        }
    }
}
