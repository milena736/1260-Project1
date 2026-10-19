using System;
using System.Collections.Generic;
using System.Text;

namespace _1260_Project1
{
    public class Member 
    {
        private string name;
        private int memberId;
        public int MemberId { get; set; }
        public string Name { get; set; }


        public Member(int memberId, string name)
        {
            this.MemberId = memberId;
            this.Name = name;
          
        }
       

    }
}
