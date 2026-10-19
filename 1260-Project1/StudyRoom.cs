using System;
using System.Collections.Generic;
using System.Text;

namespace _1260_Project1
{
    public class StudyRoom : LibraryItem, ILoanable
    {
        private int roomNumber;
        private bool isAvailable;
        public int RoomNumber { get; set; }
        public bool IsAvailable { get; set; }

        public StudyRoom(int roomNumber, int itemId, bool isAvailable) : base(itemId)
        {
            this.RoomNumber = roomNumber;
            this.IsAvailable = isAvailable;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Study Room Number: {RoomNumber}, Item ID: {ItemId}");
        }

        public override void DisplayAvailability()
        {
            Console.WriteLine($"Study Room {RoomNumber} is {(IsAvailable ? "available" : "not available")} for checkout.");
        }

       
        

    }
}
