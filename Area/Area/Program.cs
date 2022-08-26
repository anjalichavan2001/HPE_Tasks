using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Area
{
    public abstract class Shape
    {
        public void PrintArea(double area)
        {
            Console.WriteLine("Area is {0}", area);
        }
    }

    public class Triangle : Shape
    {
        public double CalcArea()
        {
             Console.WriteLine("Enter base");
             int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter height");
            int h = Convert.ToInt32(Console.ReadLine());
            double  area = 0.5*b*h;
            PrintArea(area);
            return area;

        }
    }
    public class Rectangle : Shape
    {
        public double CalcArea()
        {
            Console.WriteLine("Enter length");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter breadth");
            int breadth = Convert.ToInt32(Console.ReadLine());
            double area = 2 * (length * breadth);
          
            PrintArea(area);
            return area;
        

        }
    }
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
