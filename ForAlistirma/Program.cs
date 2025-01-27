using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ForAlistirma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double toplam = 0;
            for (double s1=0;s1<=100;s1++)
                {
                if(s1%2==0)
                {
                    Console.WriteLine(s1);
                    toplam = s1 + toplam;
                }
                 
                Console.WriteLine("100 e kadar olan çift sayıların toplamı : " + toplam);

            }
           
        }
    }
}
