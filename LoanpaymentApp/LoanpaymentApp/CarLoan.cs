using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanpaymentApp
{
    class CarLoan : Loan
    {
        public CarLoan(double principalAmount, int tenure)
        {
            PrincipalAmount = principalAmount;
            Tenure = tenure;
            InterestRate = 8.5;
        }
    }
}
