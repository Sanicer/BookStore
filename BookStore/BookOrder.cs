using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore
{
    public class BookOrder
    {
        public List<Book> books { get; set; }

        public BookOrder(List<Book> booksOrder)
        {
            books = booksOrder;
        }

        // returns the total cost of the book order
        public double totalCost(List<Category> onSaleCategories, bool isTaxed)
        {
            double total = 0;
            bool onSale;

            foreach (var book in books)
            {
                // check if book is on sale
                onSale = isBookOnSale(onSaleCategories, book);

                // sale discount is -5%
                if (onSale)
                    total += book.cost * 0.95;
                else
                    total += book.cost;
            }

            // tax is +10%
            if (isTaxed)
                total *= 1.1;

            return total;
        }

        // used to check if book is on sale
        private bool isBookOnSale(List<Category> onSaleCategories, Book book)
        {
            foreach (var category in onSaleCategories)
            {
                if (category == book.category)
                    return true;
            }
            return false;

        }
    }
}
