using System;
public class LCM
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Please enter a list of numbers that you wish to find lcm");
        Console.WriteLine("You have entered {0} number of numbers", args.Length);
        if (args.Length == 0)
        {
            Environment.Exit(1);
        }
        int[] numbers = new int[args.Length];
        //convert args to int
        for (int i = 0; i < args.Length; i++)
        {
            numbers[i] = int.Parse(args[i]);
            Console.WriteLine(numbers[i]);
        }
        int result = 1;
        for (int i = 0; i < args.Length; i++)
        {
            result = lcm(result, numbers[i]);
        }
        Console.WriteLine("LCM of given numbers = {0}", result);
    }
    public static int lcm(int a, int b)
    {
        int gcd = gcdNumbers(a, b);
        return (a * b) / gcd;
    }
    public static int gcdNumbers(int a, int b)
    {
        int temp;
        if (a > b)
        {
            temp = a;
            a = b;
            b = temp;
        }
        if (b % a == 0)
            return a;
        else
            return gcdNumbers(b % a, a);
    }
}
