using System;


namespace UserInformationApplication
{
    class UserInformation
    {
        static void Main(string[] args)
        {
            String name;
            int age;
            Console.WriteLine("What's your name?");
            name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("What's your age?");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your name is {0} and your age is {1}", name, age);
            Console.ReadLine();
        }
    }
}
