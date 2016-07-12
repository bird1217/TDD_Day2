using System.Collections.Generic;
using System.Linq;

namespace ShoppingCartLibrary
{
    public class ShopppingCart
    {
        public List<Book> _bookList = new List<Book>();
        private ICalculate _calculate;

        public void Add(Book book)
        {
            this._bookList.Add(book);
        }

        public double CalculatePrice()
        {
            int groupCount = _bookList.GroupBy(t => t.chapters).Count();

            getStrtegy(groupCount);

            int sum = _bookList.Sum(t => t.Price);

            return _calculate.CalculatePrice(sum);
        }

        private ICalculate getStrtegy(int groupCount)
        {
            switch (groupCount)
            {
                case 1:
                    _calculate = new SingleCalculate();
                    break;

                case 2:
                    _calculate = new DoulbeCalculate();
                    break;

                case 3:
                    _calculate = new TripleCalculate();
                    break;

                case 4:
                    _calculate = new QuadrupleCalculate();
                    break;

                case 5:
                    _calculate = new QuintupleCalculate();
                    break;
                default:
                    break;
            }
            return _calculate;
        }
    }
}