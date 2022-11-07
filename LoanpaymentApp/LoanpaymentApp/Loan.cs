namespace LoanpaymentApp
{
    public abstract class Loan : ILoan
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        
        public double PrincipalAmount;
        public int Tenure;
        public double Total;
        public double InterestRate;

        public void CalculateRepaymentAmount()
        {
            if (PrincipalAmount <= 0)
                log.Error("Enter valid amount");
            if (Tenure < 0)
                log.Error("Enter valid Tenure");
            if (InterestRate <= 0)
                log.Error("Enter valid rate of Tnterest");
            Total = ((PrincipalAmount * InterestRate * Tenure) / 100 )+ PrincipalAmount;  
            
        }
       
    }
}
