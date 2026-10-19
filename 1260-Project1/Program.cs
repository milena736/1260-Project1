using System.ComponentModel.Design;

namespace _1260_Project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Library = new Library();

            LibraryItem item1 = new Book(1, "The Great Gatsby", "F. Scott Fitzgerald", 1925, 218);
            Library.AddItem(item1);
            LibraryItem item2 = new Magazine(2, "National Geographic", "National Geographic Society", 2023, 8);
            Library.AddItem(item2);
            LibraryItem item3 = new Book(3, "To Kill a Mockingbird", "Harper Lee", 1960, 281);
            Library.AddItem(item3);


            Member member1 = new Member(1, "John Doe");
            Library.AddMember(member1);
            Member member2 = new Member(2, "Jane Smith");
            Library.AddMember(member2);

            Library.CheckOutItem(1, member1); 
            Library.ReturnItem(1);
            Library.CheckOutItem(2, member2);
            Console.WriteLine("Loans:");
            Library.DisplayLoans();
            Console.WriteLine("Items:");
            Library.DisplayItems();
            Console.WriteLine("Members:");
            Library.DisplayMembers();
           var foundItem = Library.Find(1);
           Console.WriteLine("Found Item: '{0}'", foundItem);
           

        }

    }
}
