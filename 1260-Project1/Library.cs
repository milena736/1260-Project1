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
        public void DisplayItems()
        {
            foreach (var item in Items)
            {
                Console.WriteLine(item.DisplayInfo());
            }
        }


        public void DisplayMembers()
        {
            foreach (var member in Members)
            {
                Console.WriteLine(member.DisplayInfo());
            }
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
                var loan = Loans.Find(l => l.ItemId.ItemId == ItemId && l.ReturnDate == null);
                if (loan != null)
                {
                    loan.ReturnItem();
                   
                }
            }
        }
        public void DisplayLoans()
        {
            foreach (var loan in Loans)
            {
                Console.WriteLine(loan.DisplayInfo());
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
            Console.WriteLine(" - Library, LibraryItem, StudyRoom, Media, Book, Magazine, Member, Loan");
            Console.WriteLine();
            Console.WriteLine("Relationships:");
            Console.WriteLine(" - Library manages LibraryItems, Members and Loans");
            Console.WriteLine(" - LibraryItem can be borrowed by Members through Loans");
            Console.WriteLine(" - Members can borrow multiple LibraryItems through Loans");
            Console.WriteLine();
            Console.WriteLine("=== 2. Inheritance and Abstraction ===");
            Console.WriteLine("Inheritance:");
            Console.WriteLine(" - Book and Magazine inherit from Media");
            Console.WriteLine(" - StudyRoom inherits from LibraryItem");
            Console.WriteLine(" - Media inherits from LibraryItem");
            Console.WriteLine(" - LibraryItem implements ILoanable");
            Console.WriteLine();
            Console.WriteLine("Abstraction:");
            Console.WriteLine(" - LibraryItem abstracts common properties and methods for all library items");
            Console.WriteLine(" - ILoanable abstracts the loanable behavior");
        }
    }
}
