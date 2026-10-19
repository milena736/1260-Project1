using System;
using System.Collections.Generic;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace _1260_Project1
{
    internal class Magazine : Media
    {
        private int issueNumber;
        public int IssueNumber { get; set; }
    

    public Magazine(string itemId, string title, string author, int year, int IssueNumber)
            : base(itemId, title, author, year)
        {
            
            this.IssueNumber = IssueNumber;
        }

        public override string DisplayInfo()
        {
            return string.Format($"Type: {Type()} Title: {title}, Author: {author}, Year: {year}, IssueNumber: {IssueNumber}");
        }

        public override string Type()
        {
            return "Magazine";
        }
    }
}
