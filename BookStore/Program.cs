using System;
using System.Collections.Generic;

namespace BookStore
{
    class Program
    {
        static void Main(string[] args)
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
            BookOrder orderNoTax = new BookOrder(Books);

            Console.WriteLine(orderWithTax.totalCost(onSaleCategories, true));
            Console.WriteLine(orderNoTax.totalCost(onSaleCategories, false));
            Console.ReadLine();
        }


    }
}
