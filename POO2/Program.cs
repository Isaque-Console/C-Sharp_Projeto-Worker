using System;

namespace POO2
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime t1 = new DateTime(2020, 09, 02);
            DateTime t2 = new DateTime(2020, 09, 05);
            TimeSpan s1 = t2.Subtract(t1);
            Console.WriteLine(s1);
            Console.WriteLine("Olá, meus amigos!");
        }
    }
}
