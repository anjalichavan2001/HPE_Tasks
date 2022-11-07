using System;


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
            double area = 0.5 * b * h;
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
}
