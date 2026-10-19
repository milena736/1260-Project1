using System;
using System.Collections.Generic;
using System.Text;

namespace _1260_Project1
{
    public class Member 
    {
        private string name;
        private string memberId;
        public string MemberId { get; set; }
        public string Name { get; set; } 


        public Member(string memberId, string name)
        {
            this.MemberId = memberId;
            this.Name = name;
          
        }
        public string DisplayInfo()
        {
            return string.Format($"Member ID: {MemberId}, Name: {Name}");
        }


    }
}
