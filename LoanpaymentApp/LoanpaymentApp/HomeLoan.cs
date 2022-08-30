﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanpaymentApp
{
    class HomeLoan : Loan
    {
        public HomeLoan(double principalAmount, int tenure)
        {
            PrincipalAmount = principalAmount;
            Tenure = tenure;
            InterestRate = 7.5;
        }
    }
}
