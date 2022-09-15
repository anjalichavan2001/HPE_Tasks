using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter a:");
            a = Convert.ToInt32(Console.ReadLine());   //take input from user
            Console.WriteLine("Enter b:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b:");
            Calculation c1 = new Calculation(a,b);     //creating instance of Calculation class.
            Thread t1 = new Thread(c1.add);                
            Thread t2 = new Thread(c1.subtract);       //invoking the instance methods for calculating.
            Thread t3 = new Thread(c1.multiply);
            Thread t4 = new Thread(c1.divide);
            t1.Start();
            t2.Start();
            t3.Start();
            t4.Start();
            Console.ReadLine();

        }
    }
}
