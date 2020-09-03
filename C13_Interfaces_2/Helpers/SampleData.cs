using C13_Interfaces_2.Interfaces;
using C13_Interfaces_2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace C13_Interfaces_2.Helpers
{
    class SampleData
    {
        public static List<IShoppingItem> CartSampleItems()
        {
            var output = new List<IShoppingItem>();
            output.Add(new Product { Id = "100523", Name = "Apple product", Description= "Airpods med laddning" });
            output.Add(new Product { Id = "11502", Name = "Samsung product", Description = "Cellphone med laddning" });
            output.Add(new Product { Id = "23500", Name = "Mac product", Description = "Vattenflaska" });

            output.Add(new License { Id = "155415", Name = "En ny produkt", Description = "Produkten kan flera saker", NumberOfLicenses = 5 });
            output.Add(new License { Id = "155415", Name = "Etvåny produkt", Description = "Produkten kan flera saker", NumberOfLicenses= 1 });
            return output;
        }
    }
}
