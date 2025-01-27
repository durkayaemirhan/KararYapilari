using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseAlistirma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kullaniciAdi = "admin";
            string sifre = "12345";

            Console.Write("Kullanıcı adınızı giriniz : ");
            string s1 = Console.ReadLine();
            Console.Write("Şifrenizi giriniz : ");
            string s2 = Console.ReadLine();
            
            if (s1 == "admin"&&s2=="12345")
            {
                Console.Write("Kullanıcı adı ve şifreniz doğrudur. Sisteme giriş başarılı !!");
                Console.ReadLine();
            }
            else if(s1=="admin"&&s2!="12345")
            {
                Console.Write("Girdiğiniz şifre hatalıdır !!");
                Console.ReadLine();
            }
            else if(s1!="admin"&&s2=="12345")
            {
                Console.Write("Girdiğiniz kullanıcı adı hatalıdır !!");
                Console.ReadLine();
            }
            else
            {
                Console.Write("Kullanıcı adı ve şifreniz hatalıdır !! ");
                Console.ReadLine();
            }


        }
    }
}
