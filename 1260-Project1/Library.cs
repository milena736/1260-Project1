using System;
using System.Collections.Generic;
using System.Text;

namespace _1260_Project1
{
    public class Library 
    {
        public List<LibraryItem> items;
        public List<Member> members;
        public List<Loan> loans;

        public Library()
        {
            this.items = new List<LibraryItem>();
            this.members = new List<Member>();
            this.loans = new List<Loan>();
        }
        public LibraryItem Find(string itemId)
        {
            return items.Find(item => item.itemId == itemId);
            if (itemId == null)
            {
                throw new InvalidOperationException($"Item with ID {itemId} not found.");
            }
        }

        public bool AddItem(LibraryItem item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item), "Item cannot be null.");
            }
            if (items.Find(i => i.itemId == item.itemId) != null)
            {
                return false;
            }
            items.Add(item);
            return true;
        }

        public void AddMember(Member member)
        {
            members.Add(member);
        }
        public void DisplayItems()
        {
            foreach (var item in items)
            {
                Console.WriteLine(item.DisplayInfo());
            }
        }


        public void DisplayMembers()
        {
            foreach (var member in members)
            {
                Console.WriteLine(member.DisplayInfo());
            }
        }
        
        
       
        
        
        public void CheckOutItem(string itemId, Member memberId)
        {
            var item = Find(itemId);
            if (item != null && memberId != null)
            {
                item.CheckOut();
                loans.Add(new Loan(memberId, item));
            }
        }
        public void ReturnItem(string itemId)
        {
            var item = Find(itemId);
            if (item != null && item.IsAvailable == false)
            {
                item.Return();
                var loan = loans.Find(l => l.itemId.itemId == itemId && l.ReturnDate == null);
                if (loan != null)
                {
                    loan.ReturnItem();
                   
                }
            }
        }
        public void DisplayLoans()
        {
            foreach (var loan in loans)
            {
                Console.WriteLine(loan.DisplayInfo());
            }
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
