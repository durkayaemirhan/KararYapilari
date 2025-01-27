using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseAlistirma3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double toplama(double sayi1, double sayi2)
            {
                return sayi1 + sayi2;
            }
            double cikarma(double sayi1, double sayi2)
            {
                return sayi1 - sayi2;
            }
            double carpma(double sayi1, double sayi2)
            {
                return sayi1 * sayi2;
            }
            double bolme(double sayi1, double sayi2)
            {
                return sayi1 / sayi2;
            }


            Console.WriteLine("Menü üzerinden yapmak istediğiniz işlemi seçiniz : ");
            Console.WriteLine("1 - Toplama");
            Console.WriteLine("2 - Çıkarma");
            Console.WriteLine("3 - Çarpma");
            Console.WriteLine("4- Bölme");
            Console.Write("Seçiniz : ");
            string s1 = Console.ReadLine();
            if (s1 == "1")
            {
                Console.Write("Birinci sayiyi girin : ");
                double sayi1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("İkinci sayiyi girin : ");
                double sayi2 = Convert.ToDouble(Console.ReadLine());

                double toplam = toplama(sayi1, sayi2);
                Console.Write("Toplama işleminin sonucu = " + toplam);
                Console.ReadLine();
            }
            else if (s1 == "2")
            {
                Console.Write("Birinci sayiyi girin : ");
                double sayi1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("İkinci sayiyi girin : ");
                double sayi2 = Convert.ToDouble(Console.ReadLine());

                double cikar = cikarma(sayi1, sayi2);
                Console.Write("Çıkarma işleminin sonucu = " + cikar);
            }
            else if (s1 == "3")
            {
                Console.Write("Birinci sayiyi girin : ");
                double sayi1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("İkinci sayiyi girin : ");
                double sayi2 = Convert.ToDouble(Console.ReadLine());

                double carp = carpma(sayi1, sayi2);
                Console.Write("Çarpma işleminin sonucu = " + carp);

            }
            else if (s1 == "4")
            {
                Console.Write("Birinci sayiyi girin : ");
                double sayi1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("İkinci sayiyi girin : ");
                double sayi2 = Convert.ToDouble(Console.ReadLine());
                if (sayi1 == 0 || sayi2 == 0)
                {
                    Console.Write("Herhangi bir sayının 0'a bölümünden kalan sonuç 0 olduğundan işleminizi gerçekleştiremiyoruz");
                    Console.ReadLine();
                }
                else
                {
                    double bol = bolme(sayi1, sayi2);

                    Console.Write("Bölme işleminin sonucu = " + bol);
                    Console.ReadLine();
                }



            }
            else
            {
                Console.Write("Hatalı bir tuşlama yaptınız !! ");
                Console.ReadLine();
            }

        }
    }
}