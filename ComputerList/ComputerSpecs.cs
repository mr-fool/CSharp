using System;
struct PC
{
    public string cpu;
    public string ram;
    public string gpu;
    public string os;
    public string name;
};

namespace ComputerSpecsList
{
    class ComputerSpecs
    {
        static void Main(string[] args)
        {
            PC PC1;
            PC PC2;
            PC PC3;
            PC PC4;
            PC PC5;

            /* PC1 Sepcs */
            PC1.name = "Lenovo 8811-9EU";
            PC1.cpu = "Intel Core 2 Duo 6700";
            PC1.ram = "DDR2 800 2GB";
            PC1.gpu = "Intel 64 MB integrated graphics";
            PC1.os = "Window XP SP3";

            /*PC2 Specs*/
            PC2.name = "Alienware M11x R2";
            PC2.cpu = "Intel Core i5 U 520";
            PC2.ram = "DDR3 1333 CL 9-9-9-24 8GB";
            PC2.gpu = "GeForce GT 335M";
            PC2.os = "Window 7 Ultimate";

            // PC3 Specs
            PC3.name = "Thinkpad x130e";
            PC3.cpu = "Intel Celeron 867";
            PC3.ram = "DDR3 1333 CL 9-9-9-24 8GB";
            PC3.gpu = "Intel R Extreme Graphics 3";
            PC3.os = "Fedora Xfce 22";
            
            //PC4 Specs
            PC4.name = "Raspberry Pi Model B";
            PC4.cpu = "700 MHz single-core ARM1176JZF-S";
            PC4.ram = "512 MB";
            PC4.gpu = "Broadcom VideoCore IV @ 250 MHz";
            PC4.os = "Raspbian";

            //PC5 Specs
            PC5.name = "Macbook MB404B/A";
            PC5.cpu = "Core 2 Duo T8300 2.40 GHz ";
            PC5.ram = "DDR2-667 2GB";
            PC5.gpu = "Intel GMA X3100";
            PC5.os = "Mac OS X";

            //Printing the Specs of all my pc

            Console.WriteLine("PC 1 name: {0}", PC1.name);
            Console.WriteLine("PC 1 cpu: {0}", PC1.cpu);
            Console.WriteLine("PC 1 ram: {0}", PC1.ram);
            Console.WriteLine("PC 1 gpu: {0}", PC1.gpu);
            Console.WriteLine("PC 1 os: {0}\n", PC1.os);

            Console.WriteLine("PC 2 name: {0}", PC2.name);
            Console.WriteLine("PC 2 cpu: {0}", PC2.cpu);
            Console.WriteLine("PC 2 ram: {0}", PC2.ram);
            Console.WriteLine("PC 2 gpu: {0}", PC2.gpu);
            Console.WriteLine("PC 2 os: {0}\n", PC2.os);

            Console.WriteLine("PC 3 name: {0}", PC3.name);
            Console.WriteLine("PC 3 cpu: {0}", PC3.cpu);
            Console.WriteLine("PC 3 ram: {0}", PC3.ram);
            Console.WriteLine("PC 3 gpu: {0}", PC3.gpu);
            Console.WriteLine("PC 3 os: {0}\n", PC3.os);

            Console.WriteLine("PC 4 name: {0}", PC4.name);
            Console.WriteLine("PC 4 cpu: {0}", PC4.cpu);
            Console.WriteLine("PC 4 ram: {0}", PC4.ram);
            Console.WriteLine("PC 4 gpu: {0}", PC4.gpu);
            Console.WriteLine("PC 4 os: {0}\n", PC4.os);

            Console.WriteLine("PC 5 name: {0}", PC5.name);
            Console.WriteLine("PC 5 cpu: {0}", PC5.cpu);
            Console.WriteLine("PC 5 ram: {0}", PC5.ram);
            Console.WriteLine("PC 5 gpu: {0}", PC5.gpu);
            Console.WriteLine("PC 5 os: {0}\n", PC5.os);

            Console.ReadKey();
        }
    }
}
