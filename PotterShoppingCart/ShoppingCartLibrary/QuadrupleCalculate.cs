namespace ShoppingCartLibrary
{
    public class QuadrupleCalculate : ICalculate
    {
        public double CalculatePrice(int Price)
        {
            return Price * Discount;
        }

        public double Discount
        {
            get { return 0.8; }
        }
    }
}