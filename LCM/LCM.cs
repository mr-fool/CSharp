using System;
public class LCM
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Please enter a list of numbers that you wish to find lcm\n");
        Console.WriteLine("You have entered {0} number of numbers\n", args.Length);
        int[] numbers = new int[args.Length];
        for (int i = 1; i < args.Length; i++)
        {
            numbers[i] = Int.Parse(args[0]);
        }
    }

}
