using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingCartLibrary
{
    public class ShopppingCart
    {
        private List<Book> _bookList = new List<Book>();

        public void Add(Book book)
        {
            this._bookList.Add(book);
        }

        public int GetPayment()
        {
            return _bookList.Sum(t => t.Price);
        }
    }
}
