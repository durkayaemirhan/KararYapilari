using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForAlistirma2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userValue=string.Empty;
            int UserValueInt = 0;
            int Factorial = 1;
            
            Console.Write("Lütfen bir sayı giriniz : ");
            userValue = Console.ReadLine();
            UserValueInt = int.Parse(userValue);
            for(int i = UserValueInt;   i>1;    i--)
            {
                Factorial= Factorial*i;
                 
            }
            Console.WriteLine(Factorial);   




        }
    }
}








#region  TEMEL I/O İŞLEMLERİ

string path = @"C:\Test\TestDizini";
string target = @"C:\Test\HedefDizini";

if(!Directory.Exists(path))
{
    Directory.CreateDirectory(path);
    Console.WriteLine("Oluşturma tarihi " + Directory.GetCreationTime(path));
    Console.WriteLine("Son erişim tarihi " + Directory.GetLastAccessTime(path));
    Console.WriteLine("Son değiştirme tarihi "+ Directory.GetLastWriteTime(path));
    Console.WriteLine("Bulunduğu dizinin adı " + Directory.GetParent(path));

}
if(Directory.Exists(target))
{
    Directory.Delete(target, true);
}
Directory.Move(path, target);
string[] directories = Directory.GetDirectories(@"C:\Test\");
foreach(string dir in directories)
{
    Console.WriteLine(dir);
}
File.CreateText(target + @"\NewFile.txt");
Console.WriteLine("{0} dizinindeki dosya sayısı : {1}", target, Directory.GetCreationTime(target).Length;
Console.ReadLine();


#endregion