using log4net.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanpaymentApp
{
    public abstract class Loan
    {
        public double p_amount;
        public double rate;
        public int yrs;
        public double total;
        public abstract void getAmount();
        public abstract void getRate();
        public abstract void getYrs();
        public void getTotal()
        {
             total = ((p_amount * rate * yrs) / 100 )+ p_amount;  
            
        }
       
    }
    class Program
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        static void Main(string[] args)
        {
            int choice;
            try
            {
                do
                {
                    Console.WriteLine("Different type of Loans:");
                    Console.WriteLine("1.HomeLoan:");
                    Console.WriteLine("2.Car Loan:");
                    Console.WriteLine("3.Personal Loan:");
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            HomeLoan h1 = new HomeLoan();

                            h1.getAmount();
                            log.Debug("The amount is taken");
                            h1.getRate();
                            log.Debug("The rate is taken");
                            h1.getYrs();
                            log.Debug("The tenure is taken");
                            h1.getTotal();
                            h1.printTotal();
                            log.Info($"The total amount for Home Loan is : {h1.total}");
                            break;
                        case 2:
                            CarLoan c1 = new CarLoan();

                            c1.getAmount();
                            log.Debug("The amount is taken");
                            c1.getRate();
                            log.Debug("The rate is taken");
                            c1.getYrs();
                            log.Debug("The tenure is taken");
                            c1.getTotal();
                            c1.printTotal();
                            log.Info($"The total amount for Car Loan is : {c1.total}");
                            break;
                        case 3:
                            PersonalLoan p1 = new PersonalLoan();

                            p1.getAmount();
                            log.Debug("The amount is taken");
                            p1.getRate();
                            log.Debug("The rate is taken");
                            p1.getYrs();
                            log.Debug("The tenure is taken");
                            p1.getTotal();
                            p1.printTotal();
                            log.Info($"The total amount for Personal Loan is : {p1.total}");
                            break;
                        default:
                            Console.WriteLine("Invalid choice");
                            log.Warn("Oops,Invalid choice");
                            break;

                    }
                } while (choice < 4);
            }
            catch(Exception ex)
            {
                log.Error(ex.Message);
            }
            Console.ReadLine();

        }
    }
}
