using System;
using System.Collections.Generic;
using System.Text;

namespace _1260_Project1
{
    public class StudyRoom : LibraryItem, IDisplay
    {
        private int roomNumber;
        private bool IsAvailable;
        public int RoomNumber { get; set; }
        

        public StudyRoom(string itemId, int roomNumber) : base(itemId)
        {
            this.RoomNumber = roomNumber;
            IsAvailable = true;
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
