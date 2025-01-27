using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace IfElseAlistirma3
{
    internal class Program
    {
        static void Main(string[] args)
           
        {

        #region Menü
        label1:
            Console.Clear();
            Console.WriteLine("Menü üzerinden yapmak istediğiniz işlemi seçiniz : ");
            Console.WriteLine("'+' - Toplama");
            Console.WriteLine("'-' - Çıkarma");
            Console.WriteLine("'*' - Çarpma");
            Console.WriteLine("'/' - Bölme");
            Console.Write("Seçiniz : ");
            string s1 = Console.ReadLine();
            double sayi1, sayi2;
            string a1;
            #endregion
            #region KULLANICIDAN ALINAN DEĞERLEMEYE GÖRE İŞLEMLER
            if (s1 == "+")
            {
                Console.Write("Birinci sayiyi girin : ");
                sayi1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("İkinci sayiyi girin : ");
                sayi2 = Convert.ToDouble(Console.ReadLine());

                double toplam = toplama(sayi1, sayi2);
                Console.WriteLine("Toplama işleminin sonucu = " + toplam);
                Console.Write("İşlem yapmaya devam etmek için 'd' tuşuna basınız : ");
                
                a1 = Console.ReadLine();
                if (a1 == "d")
                {
                    goto label1;
                }
                else
                {
                    Console.ReadLine();
                }


            }
            else if (s1 == "-")
            {
                Console.Write("Birinci sayiyi girin : ");
                sayi1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("İkinci sayiyi girin : ");
                sayi2 = Convert.ToDouble(Console.ReadLine());

                double cikar = cikarma(sayi1, sayi2);
                Console.WriteLine("Çıkarma işleminin sonucu = " + cikar);
                Console.Write("İşlem yapmaya devam etmek için 'd' tuşuna basınız : ");

                a1 = Console.ReadLine();
                if (a1 == "d")
                {
                    goto label1;
                }
                else
                {
                    Console.ReadLine();
                }
            }
            else if (s1 == "*")
            {
                Console.Write("Birinci sayiyi girin : ");
                sayi1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("İkinci sayiyi girin : ");
                sayi2 = Convert.ToDouble(Console.ReadLine());

                double carp = carpma(sayi1, sayi2);
                Console.WriteLine("Çarpma işleminin sonucu = " + carp);
                Console.Write("İşlem yapmaya devam etmek için 'd' tuşuna basınız : ");

                a1 = Console.ReadLine();
                if (a1 == "d")
                {
                    goto label1;
                }
                else
                {
                    Console.ReadLine();
                }

            }
            else if (s1 == "/")
            {
                Console.Write("Birinci sayiyi girin : ");
                sayi1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("İkinci sayiyi girin : ");
                sayi2 = Convert.ToDouble(Console.ReadLine());
                if (sayi1 == 0 || sayi2 == 0)
                {
                    Console.Write("Herhangi bir sayının 0'a bölümünden kalan sonuç 0 olduğundan işleminizi gerçekleştiremiyoruz");
                    Console.ReadLine();
                }
                else
                {

                    var sonuc = bol(sayi1, sayi2);

                    Console.WriteLine("Bölme işleminin sonucu = " + sonuc);
                    
                    Console.Write("İşlem yapmaya devam etmek için 'd' tuşuna basınız :  ");

                    a1 = Console.ReadLine();
                    if (a1 == "d")
                    {
                        goto label1;
                    }
                    else
                    {
                        Console.ReadLine();
                    }
                }
            }
            else
            {
                Console.Write("Hatalı bir tuşlama yaptınız !! ");
                Console.ReadLine();
            }

        }
        #endregion
        #region Matematiksel İşlemler
        static double toplama(double sayi1, double sayi2)
        {
            return sayi1 + sayi2;
        }
        static double cikarma(double sayi1, double sayi2)
        {
            return sayi1 - sayi2;
        }
        static double carpma(double sayi1, double sayi2)
        {
            return sayi1 * sayi2;
        }
        static double bol(double sayi1, double sayi2)
        {
            return sayi1 / sayi2;
        }
        #endregion
    }
}