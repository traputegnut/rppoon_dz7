using System;

namespace LanacOdgovornosti
{
    class Program
    {
        static void Main(string[] args)
        {        
            IOrderHandler appetizerHandler = new AppetizerHandler();
            IOrderHandler mainCourseHandler = new MainCourseHandler();
            IOrderHandler dessertHandler = new DessertHandler();

            //chain
            appetizerHandler.NextHandler = mainCourseHandler;
            mainCourseHandler.NextHandler = dessertHandler;

            //process
            Order order1 = new Order { Dish = "Main Course", TableNumber = 1 };
            Order order2 = new Order { Dish = "Dessert", TableNumber = 2 };
            Order order3 = new Order { Dish = "Soup", TableNumber = 3 }; // Unsupported dish

            appetizerHandler.ProcessOrder(order1);
            appetizerHandler.ProcessOrder(order2);
            appetizerHandler.ProcessOrder(order3);
        }
    }
}
