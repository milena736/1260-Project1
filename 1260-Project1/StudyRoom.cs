using System;
using System.Collections.Generic;
using System.Text;

namespace _1260_Project1
{
    public class StudyRoom : LibraryItem, IDisplay
    {
        private int roomNumber;
        private bool isAvailable;
        public int RoomNumber { get; set; }
        

        public StudyRoom(int roomNumber, int itemId, bool isAvailable) : base(itemId)
        {
            this.RoomNumber = roomNumber;
            this.IsAvailable = isAvailable;
        }
        public override string DisplayInfo()
        {
            return string.Format($"Study Room {RoomNumber}: {(IsAvailable ? "Available" : "Not Available")}");
        }
        public override string Type()
        {
            return "Study Room";
        }

    }
}
