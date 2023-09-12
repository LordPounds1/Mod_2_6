using System;

namespace Mod_2_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите см = ");
            int sm = Convert.ToInt32(Console.ReadLine());
            int metr = sm / 100;
            Console.WriteLine("Число полных метров: " + metr);
        }
    }
}
