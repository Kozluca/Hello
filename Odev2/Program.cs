using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Lütfen aşağıdaki bilgileri doldurunuz");
            Console.Write("T.C Kimliknumaranızı Giriniz : ");
            string Tc = Console.ReadLine();   //TC numarası int icinde çok yüksek değer aldığı için int veri tipini kullanmadım //
            
            Console.Write("Adınız : ");
            string Adı = Console.ReadLine();

            Console.Write("soyadınız : ");
            string Soyadı = Console.ReadLine();

            Console.Write("Telefon Numaranız :");
            string Telefon= Console.ReadLine();  //Telefon numarası int icinde çok yüksek değer aldığı için int veri tipini kullanmadım //

            Console.Write("Yaşınız :");
            string Yaş = Console.ReadLine();

            Console.Write("ilk aldığınız ürünün fiyatını giriniz ");
            int ilkurun = Convert.ToInt32(Console.ReadLine());
            // ürün fiyatlarında matematiksel işlem yapmam gerektiği için int veri tipini kullandım //

            Console.Write("ikinci ürünün fiyatını giriniz ");
            int ikinciurun = Convert.ToInt32(Console.ReadLine());

            int toplam = (ilkurun + ikinciurun);
            int indirim = toplam / 5;

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine( Tc+ " T.C numaralı "+ Adı +" "+Soyadı+ " isimli kişi için kayıt oluşturulmuştur.");
            Console.WriteLine( Telefon+" telefon numarasına mesaj gönderilmiştir");
            Console.WriteLine(+toplam +" TL Toplam harcama karşılığı kazanılan %20 indirim puan miktarı " + indirim+ " TL'dir");

            Console.ReadLine();
        }
    }
}
