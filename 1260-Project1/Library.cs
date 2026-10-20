using System;
using System.Collections.Generic;
using System.Text;

namespace _1260_Project1
{
    public class Library 
    {
        public List<LibraryItem> Items;
        public List<Member> Members;
        public List<Loan> Loans;

        public Library()
        {
            this.Items = new List<LibraryItem>();
            this.Members = new List<Member>();
            this.Loans = new List<Loan>();
        }
        public LibraryItem Find(string ItemId)
        {
            return Items.Find(item => item.ItemId == ItemId);
            if (ItemId == null)
            {
                throw new InvalidOperationException($"Item with ID {ItemId} not found.");
            }
        }

        public bool AddItem(LibraryItem item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item), "Item cannot be null.");
            }
            if (Items.Find(i => i.ItemId == item.ItemId) != null)
            {
                return false;
            }
            Items.Add(item);
            return true;
        }

        public void AddMember(Member member)
        {
            Members.Add(member);
        }
        
        public void CheckOutItem(string ItemId, Member MemberId)
        {
            var item = Find(ItemId);
            if (item != null && MemberId != null)
            {
                item.CheckOut();
                Loans.Add(new Loan(MemberId, item));
            }
        }
        public void ReturnItem(string ItemId)
        {
            var item = Find(ItemId);
            if (item != null && item.IsAvailable == false)
            {
                item.Return();
                var loan = Loans.Find(l => l.ItemId.ItemId == ItemId);
                if (loan != null)
                {
                    loan.ReturnItem();
                   
                }
            }
        }
        
        public int SignedCount()
        {
            int count = Items.Count(item => item is IDisplay);
            return count;
        }
        


        public void FinalReport()
        {
            Console.WriteLine("=== 1. Classes, UML, and Relationships ===" );
            Console.WriteLine("Classes:");
            Console.WriteLine("LibraryItem, StudyRoom, Media, Book, Magazine, Member, Loan");
            Console.WriteLine("Interfaces:         ILoanable, IDisplay");
            Console.WriteLine("Classes for sorting:ValueSort, GroupByKey");
            Console.WriteLine("Relationships:");
            Console.WriteLine("StudyRoom and Media inherit from Library item.");
            Console.WriteLine("Book and magazine inherit from Media");
            Console.WriteLine("Loans links members to a Library item");
            Console.WriteLine("A member can check out manny items");
            Console.WriteLine("Library manages members and Library items.");
            Console.WriteLine();
            Console.WriteLine("=== 2. Ingeritance and Abstraction ===");
            Console.WriteLine("1.Abstract base class is LibraryItem");
            Console.WriteLine("2.Middle abstract class is Media.");
            

           
        }
    }
}
