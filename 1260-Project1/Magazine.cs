using System;
using System.Collections.Generic;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace _1260_Project1
{
    internal class Magazine : LibraryItem
    {
        private int issueNumber;
        public int IssueNumber { get; set; }
    

    public Magazine(int ItemId, string title, string author, int year, string Type, int IssueNumber)
            : base(ItemId, title, author, year, Type)
        {
            this.Type = "Magazine";
            this.IssueNumber = IssueNumber;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Type: {Type} Title: {title}, Author: {author}, Year: {year}, IssueNumber: {IssueNumber}");
        }
    }
}
