using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20233007_DoWhile_Ornek2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rastgele=new Random();
            int randomSayi = rastgele.Next(0, 100);

            //Kullanıcıdan bir taminde bulunmasını isteyelim
            //Bulunduğu tahmin rastgele oluşturduğumuz sayıdan büyükse ,daha küçük bir sayı tahmin etmesini
            //Bulunduğu tahmin rastgele oluşturduğumuz sayıdan küçükse , daha büyük bir sayı tahmin etmesini isteyelim
            //Eğer 10 kez tahmin etmesine rağmen doğru sayıyı bulamamışsa hakkının dolduğunu belirtelim
            //Eğer doğru tahmin ederse tebrik mesajıyla kaç tahminde bulduğunu belirtelim
            int tahminSayisi = 1;
            int tahmin;

            do
            {
                if (tahminSayisi>10)
                {
                    Console.WriteLine("Tahmin Hakkınız Doldu");
                }
                Console.Write(tahminSayisi + ".Tahmininizi Giriniz : ");
                tahmin = int.Parse(Console.ReadLine());

                if (tahmin>randomSayi)
                {
                    Console.WriteLine("Daha küçük bir sayı tahmin edin");
                }
                else if (tahmin<randomSayi)
                {
                    Console.WriteLine("Daha büyük bir sayı tahmin edin");
                }
                else
                {
                    Console.WriteLine("TEBRİKLER ..." + tahminSayisi + ".Denemede Buldunuz");
                }
                tahminSayisi++;
                

            } while (tahmin!=randomSayi&&tahminSayisi<=10);

            Console.ReadKey();
        }
    }
}
