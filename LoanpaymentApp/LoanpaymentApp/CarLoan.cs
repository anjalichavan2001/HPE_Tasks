using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanpaymentApp
{
    class CarLoan : Loan
    {
        public override void getAmount()
        {
            Console.WriteLine("Enter principle amount for Car Loan");
            p_amount = Convert.ToDouble(Console.ReadLine());
        }

        public override void getRate()
        {
            Console.WriteLine("Enter rate of interest for Car Loan");
            rate = Convert.ToDouble(Console.ReadLine());
        }

        public override void getYrs()
        {
            Console.WriteLine("Enter tenure for Car Loan");
            yrs = Convert.ToInt32(Console.ReadLine());
        }
        public void printTotal()
        {
            Console.WriteLine("Total amount to be paid for car loan {0}", total);
        }
    }
}
