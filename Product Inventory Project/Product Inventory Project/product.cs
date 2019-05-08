using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Inventory_Project
{
    public class product
    {
        public int id { get; set; }

        public decimal price { get; set; }

        public int QuantityOnHand { get; set; }

        public product()
        {

        }

        public product(int id,decimal price,int QuantityOnHand)
        {
            this.id = id;
            this.price = price;
            this.QuantityOnHand = QuantityOnHand;
        }
    }
}
