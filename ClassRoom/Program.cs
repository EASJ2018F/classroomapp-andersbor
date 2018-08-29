using System;

namespace ClassRoom
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("hallo");
   
            Student st = new Student {Name = "Anders", Fødselsdag = 8, Fødselsmåned = 3};

            Console.WriteLine(st);
        }
    }
}
