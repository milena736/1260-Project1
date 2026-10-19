using System;
using System.Collections.Generic;
using System.Text;

namespace _1260_Project1
{
    public class Library
    {
        private List<LibraryItem> items = new List<LibraryItem>();
        private List<Member> members = new List<Member>();
        public List<Loan> loans = new List<Loan>();

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
        
        
        public LibraryItem Find(int itemId)
        {
            return items.Find(item => item.ItemId == itemId);
            if (items == null)
            {
                Console.WriteLine($"Item with ID {itemId} not found.");
            }
        } 
        
        
        public void CheckOutItem(int itemId, Member memberId)
        {
            var item = Find(itemId);
            if (item != null && memberId != null)
            {
                item.CheckOut();
                loans.Add(new Loan(memberId, item));
            }
        }
        public void ReturnItem(int itemId)
        {
            var item = Find(itemId);
            if (item != null && item.IsAvailable == false)
            {
                item.Return();
                var loan = loans.Find(l => l.Item.ItemId == itemId && l.ReturnDate == null);
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
                loan.DisplayInfo();
            }
        }
    }
}
