using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul8
{
    public class Item
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public string Color { get; set; }

        public Item(string name, double price, int stock, string color)
        {
            this.Name = name;
            this.Price = price;
            this.Stock = stock;
            this.Color = color;
        }
    }

    public class ItemsList
    {
        public List<Item> Items = new List<Item>();
        public void logNameAndPrice()
        {
            foreach (Item item in Items)
            {
                Console.WriteLine($"Produkt: '{item.Name}' | Pris: '{item.Price}'");
            }
        }

        public static List<Item> ItemsInStock(List<Item> items)
        {
            List<Item> list_InStock = new List<Item>();
            foreach (Item item in items)
                if (item.Stock > 0) list_InStock.Add(item);

            return list_InStock;
        }

        public static List<Item> ItemsOfColor(List<Item> items, string[] colors)
        {
            List<Item> result = new();
            foreach(Item item in items)
                if (colors.Contains(item.Color)) result.Add(item);

            return result;
        }
    }
}
