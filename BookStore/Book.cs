using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore
{
    public class Book
    {
        public String name { get; set; }
        public Category category { get; set; }
        public double cost { get; set; }

        public Book(string bookName, Category bookCategory, double bookCost)
        {
            name = bookName;
            category = bookCategory;
            cost = bookCost;
        }
    }
}
