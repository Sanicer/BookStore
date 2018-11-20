using BookStore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace BookStoreUnitTest
{
    [TestClass]
    public class BookStoreUnitTest
    {
        [TestMethod]
        public void TotalCostsWithTax()
        {
            List<Category> onSaleCategories = new List<Category>();
            onSaleCategories.Add(Category.Crime);

            List<Book> Books = new List<Book>()
            {
                new Book("Unsolved crimes", Category.Crime, 10.99),
                new Book("A Little Love Story", Category.Romance, 2.40),
                new Book("Heresy", Category.Fantasy, 6.80),
                new Book("Jack the Ripper", Category.Crime, 16.00),
                new Book("The Tolkien Years", Category.Fantasy, 22.90)
            };

            BookOrder orderWithTax = new BookOrder(Books);

            double result = orderWithTax.totalCost(onSaleCategories, true);
        }

        [TestMethod]
        public void TotalCostsWithoutTax()
        {
            List<Category> onSaleCategories = new List<Category>();
            onSaleCategories.Add(Category.Crime);

            List<Book> Books = new List<Book>()
            {
                new Book("Unsolved crimes", Category.Crime, 10.99),
                new Book("A Little Love Story", Category.Romance, 2.40),
                new Book("Heresy", Category.Fantasy, 6.80),
                new Book("Jack the Ripper", Category.Crime, 16.00),
                new Book("The Tolkien Years", Category.Fantasy, 22.90)
            };

            BookOrder orderWithoutTax = new BookOrder(Books);

            double result = orderWithoutTax.totalCost(onSaleCategories, false);
        }

        [TestMethod]
        public void TotalCostsNoSaleCategory()
        {
            List<Category> onSaleCategories = new List<Category>();

            List<Book> Books = new List<Book>()
            {
                new Book("Unsolved crimes", Category.Crime, 10.99),
                new Book("A Little Love Story", Category.Romance, 2.40),
                new Book("Heresy", Category.Fantasy, 6.80),
                new Book("Jack the Ripper", Category.Crime, 16.00),
                new Book("The Tolkien Years", Category.Fantasy, 22.90)
            };

            BookOrder orderWithoutTax = new BookOrder(Books);

            double result = orderWithoutTax.totalCost(onSaleCategories, false);
        }
    }
}
