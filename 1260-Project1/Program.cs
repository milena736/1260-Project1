using System.ComponentModel.Design;

namespace _1260_Project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Library = new Library();
            //adding LibraryItems
            LibraryItem item1 = new Book("11", "The Great Gatsby", "F. Scott Fitzgerald", 1925, 218);
            Library.AddItem(item1);
            Console.WriteLine(item1.DisplayInfo());
            LibraryItem item2 = new Magazine("21", "National Geographic", "National Geographic Society", 2023, 8);
            Library.AddItem(item2);
            LibraryItem item3 = new Book("12", "To Kill a Mockingbird", "Harper Lee", 1960, 281);
            Library.AddItem(item3);
            LibraryItem item4 = new StudyRoom("01", 1);
            Library.AddItem(item4);

            //adding new members
            Member member1 = new Member("1", "John Doe");
            Library.AddMember(member1);
            Member member2 = new Member("2", "Jane Smith");
            Library.AddMember(member2);
            //Check out and return tests
            Library.CheckOutItem("1", member1);
            Library.ReturnItem("1");
            Library.CheckOutItem("2", member2);

            // Display the current state of the library
            Console.WriteLine("Loans:");
            Library.DisplayLoans();
            Console.WriteLine("Items:");
            Library.DisplayItems();
            Console.WriteLine("Members:");
            Library.DisplayMembers();

            //Library.Find() test
            var foundItem = Library.Find("1");
            Console.WriteLine("Found Item: '{0}'", foundItem.DisplayInfo());
            
            // Group 3: 2nd Requirement, a loop of base type LibraryItem calling 
            //the abstract type method
            List<LibraryItem> loop = new List<LibraryItem>();
            loop.Add(item1);
            loop.Add(item2);
            loop.Add(item3);
            int loopNumber = 1;
            foreach (var item in loop)
            {
                Console.WriteLine(String.Format(" {0,2}: {1}", loopNumber++, item.Type()));
            }
            //Group 3: 3rd Requirement, using 'is' to test interface implementation
            Console.WriteLine(Library.SignedCount());

         



        }

    }
}
