namespace InterfaceTestibility
{
    public class ShippingCalculator:IShippigCalculator
    {
        public float CalculateShipping(Order order)
        {
            if (order.TotalPrice < 499)
                return order.TotalPrice * 0.1f;

            return 0;
        }
    }
}
