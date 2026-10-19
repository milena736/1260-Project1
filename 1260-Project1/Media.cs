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
        public string Type { get; set; }

        public Media(int ItemId, string title, string author, int year, string Type) : base(ItemId)
        {
            this.title = title;
            this.author = author;
            this.year = year;
            this.Type = Type;

        }

        public abstract void DisplayInfo();
        public abstract void DisplayAvailability();
    }
}
