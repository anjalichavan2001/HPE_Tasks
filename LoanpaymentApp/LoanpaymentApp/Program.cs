using log4net.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanpaymentApp
{
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
                    Console.WriteLine("4.Exit:");

                    choice = Convert.ToInt32(Console.ReadLine());
                    if (choice == 4)
                        break;
                    Console.WriteLine("Enter Principle amount:");
                    double PrincipleAmount = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter Tenure:");
                    int Tenure = Convert.ToInt32(Console.ReadLine());
                   
                    switch (choice)
                    {
                        case 1:
                            HomeLoan h1 = new HomeLoan(PrincipleAmount,Tenure);
                            h1.CalculateRepaymentAmount();
                            log.Info($"The total amount for Home Loan is : {h1.Total}");
                            break;
                        case 2:
                            CarLoan c1 = new CarLoan(PrincipleAmount, Tenure);
                            c1.CalculateRepaymentAmount();
                            log.Info($"The total amount for Car Loan is : {c1.Total}");
                            break;
                        case 3:
                            PersonalLoan p1 = new PersonalLoan(PrincipleAmount, Tenure);
                            p1.CalculateRepaymentAmount();
                            log.Info($"The total amount for Car Loan is : {p1.Total}");
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
