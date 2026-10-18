using System;
using System.Collections.Generic;
using System.Text;

namespace _1260_Project1
{
    public class Member 
    {
        private string name;
        public int MemberId { get; set; }
        public string Name { get; set; }

        public List<Loan> Loans { get; set; } 

        public Member(int MemberId, string name)
        {
            this.MemberId = MemberId;
            this.Name = name;
            Loans= new List<Loan>();
        }
       

    }
}
