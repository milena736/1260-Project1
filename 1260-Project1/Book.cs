using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace _1260_Project1
{
    public class Book : Media
    {
        private int Pages;
        public int pages { get; private set; }

        public Book (string itemId, string title, string author, int year, int pages) : base(itemId, title, author, year)
        {
            
            this.Pages = pages;
        }

        public override string DisplayInfo()
        {
            return string.Format($"Type: {Type()} Title: {title}, Author: {author}, Year: {year}, Pages: {Pages}");
        }
        public override string Type()
        {
            return "Book";
        }
        

    }
}
