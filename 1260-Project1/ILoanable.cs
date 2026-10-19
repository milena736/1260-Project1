using System;
using System.Collections.Generic;
using System.Text;

namespace _1260_Project1
{
    public interface ILoanable
    {
        bool IsAvailable { get; }

        void CheckOut();

        void Return();
    }
}
