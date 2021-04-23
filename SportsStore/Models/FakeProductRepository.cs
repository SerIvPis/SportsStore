using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public class FakeProductRepository : IProductRepository
    {
        public IQueryable<Product> Products => new List<Product> {
            new Product{ Name="Football", Price = 25 },
            new Product{ Name="Surf board", Price = 179 },
            new Product{ Name="Running shoes", Price = 95 },
            new Product{ Name="Kimono Karate", Price = 24 },
            new Product{ Name="Boots Soccers", Price = 75 }
        }.AsQueryable<Product>();
    }
}
