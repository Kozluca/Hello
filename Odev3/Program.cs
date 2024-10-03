using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev3
{
    internal class Program
    {
        static void Main(string[] args)
        {           // Girilien sayının 10 dan büyük mü küçükmüü yada 10 a eşit mi olduğunu belirlediğimiz kısım
            Console.Write("Lütfen bir sayı giriniz:");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number == 10)
            {
                Console.WriteLine("Girdiğiniz sayı 10 a eşittir.");
            }
            else if (number > 10)
            {
                Console.WriteLine("Girdiğiniz sayı 10 dan büyüktür.");
            }
            else if (number < 10)
            {
                Console.WriteLine("Girdiğiniz sayı 10 dan küçüktür");
            }
                     // Girilen sayının Tek mi çift mi olduğunu belirten kısım
            if (number %2 == 0)
            {
                Console.WriteLine("Girdiğiniz sayı çifttir.");
            }
            else
            {
                Console.WriteLine("Girdiğiniz sayı tektir.");
            }
            Console.ReadLine();
        }
    }
}
