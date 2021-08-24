using System;

namespace InterfaceTestibility
{
    public class OrderProcessor
    {
        private readonly IShippigCalculator _shippingCalculator;
        public OrderProcessor(IShippigCalculator shippigCalculator)
        {
            _shippingCalculator = shippigCalculator;
        }

        public void Process(Order order)
        {
            if (order.IsShipped)
                throw new InvalidOperationException("This order already shipped..");

            order.Shipment = new Shipment
            {
                Cost = _shippingCalculator.CalculateShipping(order),
                ShippingDate = DateTime.Today.AddDays(1)
            };

        }
    }
}
