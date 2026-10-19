using System;
using System.Collections.Generic;
using System.Text;

namespace _1260_Project1
{
    public class Loan : IDisplay
    {
        public Member Name { get; set; }
        public LibraryItem itemId { get; set; }
        public DateTime OutDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? ReturnDate { get; set; }

        public Loan(Member name, LibraryItem itemId)
        {
            this.Name = name;
            this.itemId = itemId;
            this.OutDate = DateTime.Now;
            this.DueDate = this.OutDate.AddDays(14);
            this.ReturnDate = null;
        }
        public void ReturnItem()
        {
            this.ReturnDate = DateTime.Now;
        }
        public string DisplayInfo()
        {
           
            return String.Format($"Member: {Name.Name}, Item: {itemId.DisplayInfo()}, Checked Out: {OutDate}, DueDate: {DueDate}" +
                $", Returned:{(ReturnDate.HasValue ? ReturnDate.Value.ToString() : "Not Returned")}");
            
        }
    }
}