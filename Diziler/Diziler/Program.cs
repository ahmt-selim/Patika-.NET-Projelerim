using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dizi Tanımlama
            string[] renkler = new string[5];

            string[] hayvanlar = { "Kedi", "Köpek", "Kuş", "Maymun" };

            int[] dizi;
            dizi = new int[5];

            //Dizizlere değer atma ve erişim
            renkler[0] = "Mavi";
            
            dizi[3] = 10;

            Console.WriteLine(hayvanlar[1]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);

            //Döngler ve dizi kullanımı
            //Girilen n tane sayının ortalamasını alan program
            Console.Write("Dizinin boyutunu girin: ");
            int diziUzunlugu = int.Parse(Console.ReadLine());
            int[] sayiDizisi = new int[diziUzunlugu];

            for (int i = 0; i < diziUzunlugu; i++)
            {
                Console.Write((i + 1) + ". Sayıyı giriniz: ");
                sayiDizisi[i]=int.Parse(Console.ReadLine());
            }
            int toplam = 0;
            foreach (var sayi in sayiDizisi)
            {
                toplam += sayi;
            }
            Console.WriteLine("Ortalama: " + toplam / diziUzunlugu);

            //Sort
            int[] dizi1 = { 23, 12, 4, 86, 72, 45, 19,55 };

            Console.WriteLine("***Sırasız Dizi***");
            foreach (var sayi in dizi1)
            {
                Console.WriteLine(sayi);
            }
            Console.WriteLine("***Sıralı Dizi****");
            Array.Sort(dizi1);

            foreach (var sayi in dizi1)
            {
                Console.WriteLine(sayi);
            }

            //Clear
            Console.WriteLine("****Array Clear***");
            Array.Clear(dizi1, 1, 2); //Sayı dizisi elemanlarını kullanarak girilen 2 değer arası indexleri 0'lar.

            foreach (var sayi in dizi1)
            {
                Console.WriteLine(sayi);
            }

            //Reverse
            Console.WriteLine("***Array Reverse***");
            Array.Reverse(dizi1);
            foreach (var sayi in dizi1)
            {
                Console.WriteLine(sayi);
            }

            //IndexOf
            Console.WriteLine("***Array IndexOf***");
            Console.WriteLine(Array.IndexOf(dizi1, 23)); //Verilen değer dizide varsa onun indexini döndürür.

            //Resize
            Console.WriteLine("***Array Resize***");
            Array.Resize<int>(ref dizi1, 9); //Dizinin boyutunu değiştirir.
            dizi1[8] = 99;

            foreach (var sayi in dizi1) { Console.WriteLine(sayi); }


            Console.ReadLine();
        }
    }
}
