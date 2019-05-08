using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Inventory_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();
            inventory.AddProduct(new product { id = 1, price = 200000, QuantityOnHand = 3 });
            inventory.AddProduct(new product { id = 2, price = 500000, QuantityOnHand = 5 });
            inventory.AddProduct(new product { id = 3, price = 100000, QuantityOnHand = 9 });

            //tính tổng giá trị của các product trong inventory
            Console.WriteLine("Value:");
            Console.WriteLine(inventory.SumProductPrice());

            //hiển thị thông tin của các product có trong inventory
            foreach(product product in inventory.GetAllFroductList())
            {
                Console.WriteLine("id: " + product.id + " ; price: " + product.price + " ; QuantityOnHand: " + product.QuantityOnHand);
            }
            Console.ReadKey();
        }
    }
}
