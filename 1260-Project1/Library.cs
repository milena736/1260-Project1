using System;
using System.Collections.Generic;
using System.Text;

namespace _1260_Project1
{
    public class Library
    {
        private List<LibraryItem> items = new List<LibraryItem>();
        private List<Member> members = new List<Member>();

        public void AddItem(LibraryItem item)
        {
            items.Add(item);
        }

        public void AddMember(Member member)
        {
            members.Add(member);
        }
        public void DisplayItems()
        {
            foreach (var item in items)
            {
                item.DisplayInfo();
            }
        }
        public void DisplayMembers()
        {
            foreach (var member in members)
            {
                Console.WriteLine($"MemberID: {member.MemberId}, Name: {member.Name}");
            }
        }
        public void DisplayLoans(List<Loan> loans)
        {
            foreach (var loan in loans)
            {
                loan.DisplayInfo();
            }
        }
        public void DisplayAll()
        {
            Console.WriteLine("Library Items:");
            DisplayItems();
            Console.WriteLine("\nLibrary Members:");
            DisplayMembers();
        }
        public LibraryItem Find(int itemId)
        {
            return items.Find(item => item.ItemId == itemId);
            if (items == null)
            {
                Console.WriteLine($"Item with ID {itemId} not found.");
            }
        } 
        public Member FindMember(int memberId)
        {
            return members.Find(member => member.MemberId == memberId);
            if (members == null)
            {
                Console.WriteLine($"Member with ID {memberId} not found.");
            }
        }
        public void CheckOutItem(int itemId, int memberId)
        {
            var item = Find(itemId);
            var member = FindMember(memberId);
            if (item != null && member != null)
            {
                item.CheckOut(item.ItemId);
                Console.WriteLine($"Item '{item.title}' checked out by Member '{member.Name}'.");
            }
        }
        public void ReturnItem(int itemId, int memberId)
        {
            var item = Find(itemId);
            var member = FindMember(memberId);
            if (item != null && member != null)
            {
                item.Return(item.ItemId);
                Console.WriteLine($"Item '{item.title}' returned by Member '{member.Name}'.");
            }
        }
    }
}
