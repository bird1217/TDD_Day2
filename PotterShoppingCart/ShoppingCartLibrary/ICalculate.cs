using System;
namespace ShoppingCartLibrary
{
    interface ICalculate
    {
        double CalculatePrice(int Price);

        double Discount { get; }
    }

    public class SingleCalculate : ICalculate
    {
        public double CalculatePrice(int Price)
        {
            return Price * Discount;
        }

        public double Discount
        {
            get { return 1; }
        }
    }

    public class DoulbeCalculate : ICalculate
    {
        public double CalculatePrice(int Price)
        {
            return Price * Discount;
        }

        public double Discount
        {
            get { return  0.95; }
        }
    }
}
