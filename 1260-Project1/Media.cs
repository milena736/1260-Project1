using System;
using System.Collections.Generic;
using System.Text;

namespace _1260_Project1
{
    public abstract class Media : LibraryItem
    {
        private string author;
        private int year;
        public string Author { get; set; }
        public int Year { get; set; }
        

        public Media(string itemId, string title, string author, int year) : base(itemId, title)
        {
           
            this.Author = author;
            this.Year = year;
            

        }
        public override string DisplayInfo()
        {
            return string.Format($"Type: {Type()} Title: {Title}, Author: {Author}, Year: {Year}");
        }

        public override string Type()
        {
            return "Media";
        }
        
    }
}
