using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Area
{

   
    class Program
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args)
        {
            
                Triangle c1 = new Triangle();
                Rectangle r1 = new Rectangle();
                double area1 = c1.CalcArea();
                double area2 = r1.CalcArea();
                log.Info($"Area of circle is {area1}");
                log.Info($"Area of rectangle is {area2}");
                Console.ReadLine();

            
           
        }
    }
}
