using System;

namespace sedova7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите слово:");
            string a = Convert.ToString(Console.ReadLine());
            string res = "";
            foreach (var item in a)
            {
                int n = item;
                res += item.ToString() + n;
            }
            Console.WriteLine(res);
        }
    }
}
