using System;
using System.Collections.Generic;
using System.Text;

namespace _1260_Project1
{
    internal class StudyRoom : ILoanable
    {
        private int roomNumber;
        private bool isAvailable;
        public int RoomNumber { get; set; }
        public bool IsAvailable { get; set; }

        public StudyRoom(int roomNumber, bool isAvailable)
        {
            this.RoomNumber = roomNumber;
            this.IsAvailable = isAvailable;
        }

        public void CheckOut()
        {
            if (!IsAvailable)
            {
                throw new InvalidOperationException($"Study Room {RoomNumber} is not available for checkout.");
            }
            IsAvailable = false;

        }
        public void Return()
        {
            if (IsAvailable)
            {
                throw new InvalidOperationException($"Study Room {RoomNumber} is already available and cannot be returned.");
            }
            IsAvailable = true;
        }

    }
}
