using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kim_Milyoner_Olmak_Ister
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("KimMiloner Olmak Yarışmasına Hoşgeldiniz");
            Console.Write("Hazırsanız Herhangi Bir Tuşa Basınız");
            string start = Console.ReadLine();
            Console.WriteLine("Soru 1 :  Hangisi asal sayıdır ?   A: 2   B: 10");

            String firstanswer = Console.ReadLine(); // karşı taraftan bir değer aldık
            string answer = firstanswer.ToUpper();   // büyük küçük harf farkını ortadan kaldırdık
            int score = 0; // Doğru sayısını saydırmak için score adında bir int değeri tanımladık
            if (answer == "A")
            {
                score = score + 1; // score değerine 0 verdik ve  eğer soru doğru ise +1 arttırdık
                Console.WriteLine("Cevabınız Doğru");
                Console.WriteLine("Doğru sayısı :" + score);
            }
            else
            {
                score = 0; // soru yanlış ise score değerini değiştirmedik 0 da kaldı
                Console.WriteLine("Doğru cevap A şıkkı");
                Console.WriteLine("Doğru sayısı :" + score);
            }
            Console.WriteLine("Hangisi Denizde Yaşayan En Büyük Canlıdır ?   A: Balina  B: Hamsi");
            string secondanswer = Console.ReadLine(); // 2. soru için karşı taraftan değer aldık
            string answer2 = secondanswer.ToUpper();
            if (answer2 == "A")
            {
                score = score + 1;  // en son belirlenen score değeri üzerinden işlem yapılmaya devam ediyor soru doğru ise +1 değeri alır
                Console.WriteLine("Cevabınız Doğru");// soru yanlış ise +0 değeri alır
                Console.WriteLine("Doğru sayısı :" + score);
            }
            else
            {
                Console.WriteLine("Doğru cevap A şıkkı");
                score = score + 0;
                Console.WriteLine("Doğru sayısı :" + score);
            }
            if (score == 2)  // 2 soru doğru cevaplanmışsa ödül alınır program biter.
            {
                Console.WriteLine("TEBRİKLER BÜYÜK ÖDÜLÜ KAZANDINIZ..."); 
            }
            else if (score == 0) // 2. Soru sonunda doğru cevap sayısı 0 ise yarışmayı kaybettiğini anlarız
            {
                Console.WriteLine("YARIŞMAYI KAYBETTİNİZ ...");
            }
            else if (score == 1)// doğru cevap sayısı 1 ise  program 3. soruyu sormaya geçer
            {
                Console.WriteLine("En Büyük Rakam Kaçtır ?  A: 10  B: 9");
                string thirdanswer = Console.ReadLine();
                string answer3 = thirdanswer.ToUpper();
                if (answer3 == "A")
                {
                    score = score + 0;
                    Console.WriteLine("Doğru cevap B şıkkı");
                    Console.WriteLine("Doğru sayısı :" + score);
                }
                else
                {
                    score = score + 1;
                    Console.WriteLine("Cevabınız Doğru");
                    Console.WriteLine("Doğru sayısı :" + score);
                }
                if (score == 2)
                { Console.WriteLine("TEBRİKLER BÜYÜK ÖDÜLÜ KAZANDINIZ..."); } // doğru cevap sayısı 2 ise ödül kazanılır
                else
                {
                    Console.WriteLine("YARIŞMAYI KAYBETTİNİZ ..."); // doğru cevap sayısı 1 ise ödül kaybedilir
                }
            }
            Console.ReadLine();

        }

    }
}

