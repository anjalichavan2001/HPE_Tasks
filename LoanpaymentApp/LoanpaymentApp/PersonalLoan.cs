using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanpaymentApp
{
    class PersonalLoan : Loan
    {
        public PersonalLoan(double principalAmount, int tenure)
        {
            PrincipalAmount = principalAmount;
            Tenure = tenure;
            InterestRate = 12.5;
        }
    }
}
