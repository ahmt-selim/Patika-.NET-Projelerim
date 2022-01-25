using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Döngüler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //FOR Döngüsü

            //Girilen sayıya kadar olan tek sayıları yazdır.
            Console.WriteLine("Bir sayı giriniz: ");
            int sayac=int.Parse(Console.ReadLine());
            for (int i = 1; i < sayac; i++)
            {
                if (i%2==1)
                {
                    Console.WriteLine(i);
                }
            }

            //break, continue
            Console.WriteLine("Break");
            for (int i = 1; i < 10; i++)
            {
                if (i==4)
                {
                    break;
                }
                Console.WriteLine(i);
            }
            Console.WriteLine("Continue");
            for (int i = 0; i < 10; i++)
            {
                if (i==4)
                {
                    continue;
                }
                Console.WriteLine(i);
            }















            Console.ReadLine();
        }
    }
}
