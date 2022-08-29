using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanpaymentApp
{
    class HomeLoan : Loan
    {
        public override void getAmount()
        {
            Console.WriteLine("Enter principle amount for Home Loan");
            p_amount = Convert.ToDouble(Console.ReadLine());
        }

        public override void getRate()
        {
            Console.WriteLine("Enter rate of interest for Home Loan");
            rate = Convert.ToDouble(Console.ReadLine());
        }

        public override void getYrs()
        {
            Console.WriteLine("Enter tenure for Home Loan");
            yrs = Convert.ToInt32(Console.ReadLine());
        }
        public void printTotal()
        {
            Console.WriteLine("Total amount to be paid for home loan {0}",total);
        }
    }
}
