using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hata_Yönetimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayı giriniz: ");
            int sayi=Convert.ToInt32(Console.ReadLine()); //Eğer string değer girilirse kod hata verecektir.
            Console.WriteLine("Girmiş olduğunu sayı: " + sayi);
            //Bu yüzden 'try', 'catch' boluğu kullannılır.
            try
            {
                //Hata verme ihtimali olan kodu bu bloğa yazıyoruz.
                Console.WriteLine("Bir sayı giriniz: ");
                int sayi1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmiş olduğunu sayı: " + sayi1);
            }
            catch (Exception ex)
            {
                //Hata yakalandığında çalışan bölüm.
                Console.WriteLine("Hata: " + ex.Message.ToString());
            }
            finally
            {
                //Hata alsa veya almasa çalışan bölüm.
                Console.WriteLine("İşlem tamamlandı.");
            }

            //Boş değer denetleme 
            try
            {
                int a = int.Parse(null);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Boş değer girdiniz.");
                Console.WriteLine(ex);                
            }

            Console.ReadLine();
        }
    }
}
