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
            int groupCount;
            double sum = 0;
            while (_bookList.Count > 0)
            { 
                var bundleList= GetbundleBook(out groupCount);
                getStrtegy(groupCount);

                //加總bundle總價
                int subTotal = bundleList.Sum(t => t.Price);

                sum += _calculate.CalculatePrice(subTotal);

                //從原始購物車移除bundle項目
                bundleList.ForEach(t => _bookList.Remove(t));
            }
            return sum;
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

        private List<Book> GetbundleBook(out int groupCount)
        {
            List<Book> _bundleList = new List<Book>();
            var bundle = from v in _bookList
                         group v by v.chapters
                             into g
                             select g;

            groupCount = bundle.Count();
            foreach (var bundleItem in bundle)
            {
                int chapter = bundleItem.Key;
                Book _bundleItem = _bookList.First(t => t.chapters == chapter);
                _bundleList.Add(_bundleItem);
            }
            return _bundleList;
        }
    }
}