using System;
using System.Collections.Generic;
using System.Text;

namespace _1260_Project1
{
    public class Loan
    {
        public Member Name { get; set; }
        public LibraryItem Item { get; set; }
        public DateTime OutDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? ReturnDate { get; set; }

        public Loan(Member name, LibraryItem item)
        {
            this.Name = name;
            this.Item = item;
            this.OutDate = DateTime.Now;
            this.DueDate = this.OutDate.AddDays(14);
            this.ReturnDate = null;
        }
        public void ReturnItem()
        {
            this.ReturnDate = DateTime.Now;
        }
        public void DisplayInfo()
        {
            Console.WriteLine();
            Console.WriteLine($"Member: {Name.Name}, Item: {Item.title}, Checked Out: {OutDate}, DueDate: {DueDate}" +
                $", Returned:{(ReturnDate.HasValue ? ReturnDate.Value.ToString() : "Not Returned")}");
            
        }
    }
}