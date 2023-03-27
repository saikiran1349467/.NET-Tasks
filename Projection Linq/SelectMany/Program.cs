using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectMany
{
    public class OrderItem
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
    }

    public class Order
    {
        public int OrderId { get; set; }
        public List<OrderItem> Items { get; set; }
    }

   
    class Program
    {
        static void Main(string[] args)
        {
            List<Order> orders = new List<Order>
        {
            new Order 
            {
                OrderId = 1, Items = new List<OrderItem> 
                {
                    new OrderItem 
                    { 
                        ItemId = 1, ItemName = "Product A" 
                    },
                    new OrderItem 
                    { ItemId = 2, ItemName = "Product B" 
                    }
                }
            },
            new Order { OrderId = 2, Items = new List<OrderItem> { new OrderItem { ItemId = 3, ItemName = "Product C" }, new OrderItem { ItemId = 4, ItemName = "Product D" } } },
            new Order { OrderId = 3, Items = new List<OrderItem> { new OrderItem { ItemId = 5, ItemName = "Product E" }, new OrderItem { ItemId = 6, ItemName = "Product F" } } },
        };

            var orderItems = orders.SelectMany(o => o.Items);

            foreach (var item in orderItems)
            {
                Console.WriteLine($"Item Id: {item.ItemId} Item Name: {item.ItemName}");
            }
        }
    }


}
