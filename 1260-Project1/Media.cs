using System;
using System.Collections.Generic;
using System.Text;

namespace _1260_Project1
{
    public abstract class Media : LibraryItem
    {
        public string title { get; set; }
        public string author { get; set; }
        public int year { get; set; }
        

        public Media(string itemId, string title, string author, int year) : base(itemId)
        {
            this.title = title;
            this.author = author;
            this.year = year;
            

        }
        public override string DisplayInfo()
        {
            return string.Format($"Type: {Type()} Title: {title}, Author: {author}, Year: {year}");
        }

        public override string Type()
        {
            return "Media";
        }
        
    }
}
