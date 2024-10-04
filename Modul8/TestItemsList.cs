using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul8
{
    public class TestItemsList
    {
        public static void Run()
        {
            ItemsList list1 = new ItemsList()
            {
                Items =
                {
                    new Item("Lego tog", 350, 8, "blue"),
                    new Item("2x8 klodser, lille pakke", 50, 4, "blue"),
                    new Item("2x4 klodser, lille pakke", 40, 0, "red"),
                    new Item("Lego piratskib", 600, 2, "yellow"),
                    new Item("Lego starter pack", 650, 0, "multi-colored")
                }
            };

            list1.logNameAndPrice();

            // Spacing
            Console.WriteLine(" ");


            List<Item> list1_instock = ItemsList.ItemsInStock(list1.Items);

            //string[] color_check = { "multi-colored" };
            List<Item> list1_incolor = ItemsList.ItemsOfColor(list1.Items, new[] { "multi-colored" });



            string in_stock = string.Join(" | ", list1_instock.Select(item => item.Name));
            Console.WriteLine($"Produkter på lager: {in_stock}");

            string in_colors = string.Join(" | ", list1_incolor.Select(item => item.Name));
            Console.WriteLine($"Produkter af valgte farver: {in_colors}");

        }

        
    }
}
