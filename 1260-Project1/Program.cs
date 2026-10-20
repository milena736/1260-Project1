using System.ComponentModel.Design;

namespace _1260_Project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Path.Combine(AppContext.BaseDirectory, "data.txt");

            var Library = new Library();

            Library.FinalReport();

            //adding LibraryItems
            LibraryItem item1 = new Book("11", "The Great Gatsby", "F. Scott Fitzgerald", 1925, 218);
            Library.AddItem(item1);
            LibraryItem item2 = new Magazine("21", "National Geographic", "National Geographic Society", 2023, 8);
            Library.AddItem(item2);
            LibraryItem item3 = new Book("12", "To Kill a Mockingbird", "Harper Lee", 1960, 281);
            Library.AddItem(item3);
            LibraryItem item4 = new StudyRoom("01", "Apple Room", 1);
            Library.AddItem(item4);
            //duplicate item test
            LibraryItem item5 = new Book("11", "The Great Gatsby", "F. Scott Fitzgerald", 1925, 218);
            Library.AddItem(item5);

            //adding new members
            Member member1 = new Member("1", "John Doe");
            Library.AddMember(member1);
            Member member2 = new Member("2", "Jane Smith");
            Library.AddMember(member2);

            //Check out and return tests
            Library.CheckOutItem("11", member1);
            Library.ReturnItem("11");
            Library.CheckOutItem("21", member2);
            Console.WriteLine();

            Console.WriteLine("===== Library: =====");
            Console.WriteLine();
            Console.WriteLine("===== Library Items =====");

            List<LibraryItem> list = Library.Items;
            int numA = 1;
            foreach(var item in list)
            {
                Console.WriteLine($" {numA++} {item.DisplayInfo()}");
            }
            Console.WriteLine();
            Console.WriteLine("===== Members: =====");
            List<Member> memberList = Library.Members;

            foreach (var m in memberList)
            {
                Console.WriteLine(m.DisplayInfo());
            }
            Console.WriteLine();
            Console.WriteLine("===== Loans: =====");
            List<Loan> loanList = Library.Loans;
                foreach(var l in loanList)
                {
                    Console.WriteLine(l.DisplayInfo());
                }
            Console.WriteLine();
               
            



            // Group 3: 2nd Requirement, a loop of base type LibraryItem calling 
            //the abstract type method
            Console.WriteLine("=== Group 3: Loop of base type, LibraryItem calling abstact method used by derived classes: ===");
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
            
            Console.WriteLine("Signed count for ILoanable, using is: " +Library.SignedCount());
            Console.WriteLine();

            //Group 4: 1st Requirement, distinct and duplicate count
            List<LibraryItem> itemCounter = new List<LibraryItem>();
            itemCounter.Add(item1);
            itemCounter.Add(item2);
            itemCounter.Add(item3);
            itemCounter.Add(item4);
            itemCounter.Add(item5);

            var hashSet = new HashSet<LibraryItem>();
            hashSet.Add(item1);
            hashSet.Add(item2);
            hashSet.Add(item3);
            hashSet.Add(item4);
            hashSet.Add(item5);

            Console.WriteLine("=== Group 4: Contracts and Collections: ===");
            var itemList = new List<LibraryItem>(hashSet);
            //Bool to test if items are equal
            bool duplicate = itemCounter[0].Equals(itemCounter[4]);
            Console.WriteLine("Duplicate Items:" +duplicate);
            bool distinct = itemCounter[0].GetHashCode() == itemCounter[4].GetHashCode();
            Console.WriteLine("Equal hash codes: " + distinct);
            int createdCount = itemCounter.Count;
            int distinctCount = itemList.Count;
            Console.WriteLine($"Records Created: {createdCount}");
            Console.WriteLine($"Distinct Records: {distinctCount}");
            Console.WriteLine();

            //Group 4: 2nd Requirement, sorting by natural order
            itemList.Sort();
            Console.WriteLine("Items sorted by natural order:");
            int num1 = 1;
            foreach (var item in itemList)
            {
                Console.WriteLine($" {num1++} {item.DisplayInfo()}");
            }
            Console.WriteLine();
            // sorting by custom order using IComparer
            Console.WriteLine("Items sorted by Title:");
            itemList.Sort(new ValueSort());
            int num2 = 1;
            foreach (var item in itemList)
            {
                Console.WriteLine($" {num2++} {item.DisplayInfo()}");
            }
            Console.WriteLine();
            // items sorted by Name using GroupByKey
            Console.WriteLine("Items sorted by Name:");
            itemList.Sort(new GroupByKey());
            int num3 = 1;
            foreach (var item in itemList)
            {
                Console.WriteLine($" {num3++} {item.DisplayInfo()}");
            }

            //Group 5 loading from seed_data.txt

            string filePath = ($"C:\\Users\\milen\\OneDrive\\Documents\\1260-Project1\\1260-Project1\\seed_Data.txt");
           
            List<string> data = new List<string>();

            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    int lineNumber = 0;
                    while ((line = sr.ReadLine()) != null)
                    {
                        lineNumber++;
                        try
                        {
                            data.Add(line);

                        }
                        catch (FormatException ex)
                        {
                            Console.WriteLine($"Line {lineNumber} is invalid, Reason: {ex.Message}");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error reading file: {ex.Message}");
                        }
                    }
                }
            }


            catch (IOException ex)
            {
                Console.WriteLine($"Error reading file: {ex.Message}");
            }
            Console.WriteLine("Valid Data:");
            foreach (var item in data)
            {
                Console.WriteLine(item);
            }


            
          }  

    }
}
