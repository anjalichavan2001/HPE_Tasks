using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculation
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        //System.Diagnostics.EventLog.CreateEventSource
        public int num1,num2;
        public Calculation(int a,int b)
        {
           num1 = a;
           num2 = b;

        }
        public void add() 
        {
            int t = num1+num2;
            Console.WriteLine("addition of two numbers is {0}", t);
        }
        public void subtract()
        {
            Thread.Sleep(2000);
            int t = num1 - num2;
            Console.WriteLine("subtraction of two numbers is {0}", t);
        }
        public void multiply()
        {
            Thread.Sleep(4000);
            int t = num1 * num2;
            Console.WriteLine("product of two numbers is {0}", t);
        }
        public void divide()
        {
            try
            {
                Thread.Sleep(6000);
                int t = num1 / num2;
                Console.WriteLine("division of two numbers is {0}", t);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error in division: {0}",ex.Message);
                log.Error("Error in division "+ ex.Message);
            }
           
        }
    }
}
