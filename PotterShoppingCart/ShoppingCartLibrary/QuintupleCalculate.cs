using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingCartLibrary
{
    public class QuintupleCalculate :ICalculate
    {
        public double CalculatePrice(int Price)
        {
            return Price * Discount;
        }

        public double Discount
        {
            get { return 0.75; }
        }
    }
}
