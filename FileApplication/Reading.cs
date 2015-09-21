using System;
using System.IO;


namespace FileApplication
{
    class Reading
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the file you want to read");
            string file = Console.ReadLine();
            try
            {
                using (StreamReader io = new StreamReader(file))
                {
                    string line;
                    while ((line = io.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read: ");
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
