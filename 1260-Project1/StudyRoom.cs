using System;
using System.Collections.Generic;
using System.Text;

namespace _1260_Project1
{
    public class StudyRoom : LibraryItem, IDisplay, ILoanable
    {
        private int roomNumber;
        public int RoomNumber { get; set; }
       


        public StudyRoom(string itemId, string title, int roomNumber) : base(itemId, title)
        {
            this.RoomNumber = roomNumber;
            
        }
        public override string DisplayInfo()
        {
            return string.Format($"Study Room {RoomNumber}: Room Name: {Title} - {(IsAvailable ? "Available" : "Not Available")}");
        }
        public override string Type()
        {
            return "Study Room";
        }


    }
}
