using System;


namespace CircleApplication
{
    class Circle
    {
        static void Main(string[] args)
        {
            double pi = Math.PI;
            double r;
            Console.WriteLine("Enter Radius: ");
            r = Convert.ToDouble(Console.ReadLine());
            double area = pi * r * r;
            Console.WriteLine("Radius: {0}, Area: {1}", r, area);
            Console.ReadLine();
        }
    }
}
