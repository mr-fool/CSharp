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
        for (int i = 0; i < args.Length; i++)
        {
            Console.WriteLine(args[i]);
            numbers[i] = int.Parse(args[i]);
            Console.WriteLine(numbers[i]);
        }
    }

}
