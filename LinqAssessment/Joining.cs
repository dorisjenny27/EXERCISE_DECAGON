using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAssessment
{
    internal class Joining
    {
        public static void JoiningExample(List<Item> itemlist, List<Sales> saleslist)
        {
            var output = itemlist.Join(saleslist, y => y.ItemId, z => z.ItemId, (y, z) => new
            {
                itemID = y.ItemId,
                itemName = y.ItemDes,
                salesQty = z.Qty

            });
            Console.WriteLine("ItemID" + " " + "ItemName" + "  " + "Quantity");
            Console.WriteLine("-------------------------");
            foreach (var item in output)
            {
                
               
                Console.WriteLine($"{item.itemID, -7} {item.itemName, -7}  {item.salesQty,-3}");
            }
            Console.WriteLine();
        }
    }
}
