using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Inventory_Project
{
    public class Inventory
    {
        private List<product> ProductList ;
        public Inventory()
        {
            ProductList = new List<product>();
        }

        //hàm lấy ra thông tin các product
        public List<product> GetAllFroductList()
        {
            return ProductList;
        }

        //hàm lấy ra thông tin product theo id
        public product GetProductById(int id)
        {
            foreach(product Product in ProductList)
            {
                if (Product.id == id) return Product;
            }
            return null;
        }

        //ham them 1 doi tuong product vào danh sách
        public void AddProduct(product product)
        {
            ProductList.Add(product);
        }

        //ham edit 1 đối tượng product 
        public void EditProduct(product product)
        {
            foreach (product Product in ProductList)
            {
                if (Product.id == product.id)
                {
                    Product.price = product.price;
                    Product.QuantityOnHand = product.QuantityOnHand;
                }
            }
        }

        //xóa 1 product ra khỏi danh sách
        public void DeleteProduct(int id)
        {
            foreach (product Product in ProductList)
            {
                if (Product.id == id)
                {
                    ProductList.Remove(Product);
                    break;
                }
            }
        }

        //tính tổng giá trị của product đang có trong inventory
        public decimal SumProductPrice()
        {
            decimal sum = 0;
            foreach (product Product in ProductList)
            {
                sum += Product.price * Product.QuantityOnHand;
            }
            return sum;
        }
    }
}
