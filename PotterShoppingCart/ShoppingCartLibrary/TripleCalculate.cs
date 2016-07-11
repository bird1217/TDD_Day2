namespace ShoppingCartLibrary
{
    public class TripleCalculate : ICalculate
    {
        public double CalculatePrice(int Price)
        {
            return Price * Discount;
        }

        public double Discount
        {
            get { return 0.9; }
        }
    }
}