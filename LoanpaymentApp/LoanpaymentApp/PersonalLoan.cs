using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanpaymentApp
{
    class PersonalLoan : Loan
    {
        public override void getAmount()
        {
            Console.WriteLine("Enter principle amount for Personal Loan");
            p_amount = Convert.ToDouble(Console.ReadLine());
        }

        public override void getRate()
        {
            Console.WriteLine("Enter rate of interest for Personal Loan");
            rate = Convert.ToDouble(Console.ReadLine());
        }

        public override void getYrs()
        {
            Console.WriteLine("Enter tenure for Personal Loan");
            yrs = Convert.ToInt32(Console.ReadLine());
        }
        public void printTotal()
        {
            Console.WriteLine("Total amount to be paid for personal loan {0}", total);
        }
    }
}
