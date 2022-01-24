using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İf_Else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;

            if (time>=6 && time<11) //VE ifadesi
            {
                Console.WriteLine("Günaydın.");
            }
            else if(time<=18)
            {
                Console.WriteLine("İyi Günler.");
            }
            else
            {
                Console.WriteLine("İyi Geceler.");
            }
            //Tek satırlık koşul ifadesi. İfade doğruysa "İyi Günler", değilse "İyi Geceler" çalışır.
            string sonuc = time <= 18 ? "İyi Günler": "İyi Geceler.";

            sonuc = time >= 6 && time <= 11 ? "Günaydın" : time <= 18 ? "İyi Günler" : "İyi Geceler.";
            Console.WriteLine(sonuc);

            int month=DateTime.Now.Month;

            //Expressions
            switch (month)
            {
                case 1:
                    Console.WriteLine("Ocak Ayındasınız.");
                    break;
                case 2:
                    Console.WriteLine("Şubat Ayındasınız.");
                    break;
                case 3:
                    Console.WriteLine("Mart Ayındasınız.");
                    break;
                case 4:
                    Console.WriteLine("Nisan Ayındasınız.");
                    break;

                default:
                    Console.WriteLine("Yanlış veri.");
                    break;
            }

            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Kış Mevsimindesiniz.");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("İlkbahar Mevsimindesiniz.");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Yaz Mevsimindesiniz.");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Sonbahar Mevsimindesiniz.");
                    break;
                default:
                    break;
            }

            Console.ReadLine();
        }
    }
}
