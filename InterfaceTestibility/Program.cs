using System;

namespace InterfaceTestibility
{
    class Program
    {
        static void Main(string[] args)
        {
            var orderProcessor = new OrderProcessor(new ShippingCalculator());
            var order = new Order { DatePlaced = DateTime.Now, TotalPrice = 450 };
            orderProcessor.Process(order);
        }
    }
}
