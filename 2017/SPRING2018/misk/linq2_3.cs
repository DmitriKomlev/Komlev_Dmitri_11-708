using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections;

namespace linq23
{
    class B
    {
        public string producingCountry { get; set; }
        public string category { get; set; }
        public int itemID { get; set; }

    }
    class D
    {
        public int itemID { get; set; }
        public string storeName { get; set; }
        public double price { get; set; }
    }
    class BD
    {
        public int itemID { get; set; }
        public string storeName { get; set; }
        public double price { get; set; }
        public string country { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<B> production = new List<B>
            {    
                new B{ producingCountry = "China", category = "phone", itemID=1},
                new B{ producingCountry = "China", category = "phone", itemID=2},
                new B{ producingCountry = "China", category = "smartphone", itemID=3},
                new B{ producingCountry = "USA", category = "smartphone", itemID=4},
                new B{ producingCountry = "USA", category = "smartphone", itemID=5},
                new B{ producingCountry = "USA", category = "smartphone", itemID=6},
                new B{ producingCountry = "France", category = "smartphone", itemID=7},
                new B{ producingCountry = "Russia", category = "smartphone", itemID=8},



            };
            List<D> sellers = new List<D>
            {
                new D { itemID =1, storeName = "Aliexpress", price = 1000},
                new D { itemID =1, storeName = "reseller", price = 1300},
                new D { itemID =2, storeName = "Aliexpress", price = 30000},
                new D { itemID =2, storeName = "resellser", price = 35000},
                new D { itemID =3, storeName = "Aliexpress", price =7000},
                new D { itemID =3, storeName = "resellser", price =9000},
                new D { itemID =4, storeName = "re_Store", price = 20000},
                new D { itemID =4, storeName = "Aliexpress", price = 11000},
                new D { itemID =5, storeName = "re_Store", price = 70000}
            };

            var commonList = production.Join(sellers,
                                  b => b.itemID,
                                  c => c.itemID,
                                  (b, c) => new { productionCountry = b.producingCountry, itemID = b.itemID, price = c.price, stroreName = c.storeName });

            var CommonlistGroupByCountry = commonList.GroupBy(p => p.productionCountry)
                        .Select(g => new { country = g.Key, count = g.Count(), minPrice = g.Select(a=>a).Min(a =>a.price)});
            // продукция, которая ксть в магазинах
            var productionForSalling = CommonlistGroupByCountry.GroupBy(p => p.country)
                        .Select(g => new { country = g.Key, count = 0, minPrice = 0.0});

            var result = production.GroupBy(p => p.producingCountry)
                        .Select(g => new { country = g.Key, count = 0, minPrice = 0.0 })
                        .Except(productionForSalling)
                        .Concat(CommonlistGroupByCountry)
                        .OrderBy(r => r.count)
                        .ThenBy(q => q.country); 

            foreach (var e in result)
                Console.WriteLine("{0} {1} {2}", e.count, e.country, e.minPrice);

            Console.ReadLine();
        }
    }
}
