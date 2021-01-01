using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            int büyüksayi = (sayi1 < sayi2) ? sayi2 : sayi1;
            int kücüksayi = (sayi1 < sayi2) ? sayi1 : sayi2;
            for (int i = kücüksayi; i < büyüksayi; i++)
            {
                int sayac = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                        sayac++;
                }
                if (sayac < 3)
                    Console.WriteLine(i);
            }
        }
    }
}

