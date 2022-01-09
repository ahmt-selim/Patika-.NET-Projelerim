using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merhaba_Dünya
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merhaba Dünya!");
            string isim, soyisim;
            Console.Write("İsminizi girin: ");
            isim=Convert.ToString(Console.ReadLine());
            Console.Write("Soyisminizi girin: ");
            soyisim=Convert.ToString(Console.ReadLine());
            Console.WriteLine("Merhaba "+isim+" "+soyisim);

            Console.ReadLine();
        }
    }
}
