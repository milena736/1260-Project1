using System;
using System.Collections.Generic;
using System.Text;

namespace _1260_Project1
{
    public class Loan
    {
        private int loanId;
        public int LoanId { get; set; }
        public string kind;
        public int count { get; } = 0;


        public Loan(int loanId, string kind, int count)
        {
            this.LoanId = loanId ++;
            this.kind = kind;
            this.count = count;

        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Loan ID: {LoanId}, Kind: {kind}, Count: {count}");
        }
    }
}