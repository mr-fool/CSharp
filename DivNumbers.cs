using System;

namespace DivideError
{
    class DivNumbers
    {
        int result;
        DivNumbers()
        {
            result = 0;
        }
        public void division(int num1, int num2)
        {
            try
            {
                result = num1 / num2;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Exception caught: Cannot divide by zero");
            }
            finally
            {
                Console.WriteLine("Result: {0}", result);
            }
        }
        static void Main(string[] args)
        {
            DivNumbers d = new DivNumbers();
            Console.WriteLine("Please enter the first number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            d.division(num1, num2);
            Console.ReadKey();
        }
    }
}

