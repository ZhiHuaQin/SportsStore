using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vic.SportsStore.Domain.Concrete;
using Vic.SportsStore.Domain.Entities;

namespace Vic.SportsStore.DebugConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new EFDbContext())
            {
                for (int i = 0; i < 10; i++)
                {
                    var product = new Product()
                    {
                        Name = $"Basketball_{i}",
                        Price = 12.34m,
                        Description = "This is a basketball",
                        Category = "Basketball"
                    };
                    ctx.Products.Add(product);
                    ctx.SaveChanges();
                }
            }
        }
    }
}
