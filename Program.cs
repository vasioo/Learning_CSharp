using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> shopUtilities =new Dictionary<string, Dictionary<string, double>>();
             string items = Console.ReadLine();
            while (items!="Revision")
            {
                var splitted = items.Split(", ");
                var shopName = splitted[0];
                var product = splitted[1];
                double price = double.Parse(splitted[2]);
               
                if (!shopUtilities.ContainsKey(shopName))
                {
                    shopUtilities.Add(shopName, new Dictionary<string, double>());
                }
                shopUtilities[shopName].Add(product, price);
                items = Console.ReadLine();
            }
            shopUtilities = shopUtilities.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            foreach (var shop in shopUtilities)
            {
                Console.WriteLine($"{shop.Key}->");
                foreach (var item in shop.Value)
                {
                    Console.WriteLine($"Product: {item.Key}, Price: {(item.Value)}");
                }
            }
        }
    }
}
