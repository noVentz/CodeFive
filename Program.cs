using System;

namespace CodeFive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Vyachaslau";
            string surName = "Matsialionak";
            Console.WriteLine("Ваше фамилия и имя {0} {1}", name, surName);
            string swap = name;
            name = surName;
            surName = swap;
            Console.WriteLine("Ваше фамилия и имя {0} {1}", name, surName);
        }
    }
}
