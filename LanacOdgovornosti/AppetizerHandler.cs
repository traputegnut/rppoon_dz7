﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanacOdgovornosti
{
    class AppetizerHandler : IOrderHandler
    {
        public IOrderHandler NextHandler { get; set; }

        public void ProcessOrder(Order order)
        {
            if (order.Dish.Equals("Appetizer", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Preparing {order.Dish} for table {order.TableNumber}");
            }
            else if (NextHandler != null)
            {
                NextHandler.ProcessOrder(order);
            }
            else
            {
                Console.WriteLine($"Sorry, we don't serve {order.Dish} in this restaurant.");
            }
        }
    }
}