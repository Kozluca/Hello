using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userinput = "42";
            int result = 0;
            int.TryParse(userinput, out result);
            Console.WriteLine("Dönüsüm basarılı.Sonuc : + result ");
            Console.ReadLine();

        }
    }
}
