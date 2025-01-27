using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseAlistirma2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            label1:
            Console.Write("Sisteme kayıtlı kullanıcı adınızı girin : ");
            string kullaniciAdi = Console.ReadLine();
            kullaniciAdi = kullaniciAdi.ToUpper();
            if (kullaniciAdi == "ABC"||kullaniciAdi=="123"||kullaniciAdi=="236"||kullaniciAdi=="CMK")
            {
                Console.Write("Kullanıcı girişiniz başarılı !! ");
                Console.ReadLine();
                
            }
            else if (kullaniciAdi == "HHH" || kullaniciAdi == "BBB" || kullaniciAdi == "MMM")
            {
                Console.Write("Kullanıcı girişi için erişiminiz  kısıtlanmıştır !! ");
                Console.ReadLine();
                goto label1;
            }
            else
            {
                Console.Write("Hatalı bir kullanıcı kodu girdiniz. ");
                Console.ReadLine();
                goto label1;
            }

        }
    }
}
