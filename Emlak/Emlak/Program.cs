using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emlak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string durum;
            string il;
            string ilçe;
            string adres;
            string isitma;
            int katsayisi;
            Console.WriteLine("Satılık mı? , Kiralık mı?");
            durum = Console.ReadLine();
            Ev yeniev = new Ev();
            Console.WriteLine("Lütfen il giriniz");
            il = Console.ReadLine();
            Console.WriteLine("Lütfen ilçe giriniz");
            ilçe = Console.ReadLine();
            Console.WriteLine("Lütfen adres giriniz");
            adres = Console.ReadLine();
            Console.WriteLine("Lütfen ısıtma türünü giriniz");
            isitma = Console.ReadLine();
            Console.WriteLine("Lütfen katsayisini giriniz");
            katsayisi = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ev " + durum + il + "/" + ilçe + " olup " + adres + "adresindedir" + "ısıtma türü : " + isitma + " olup " + katsayisi + " katlıdır.");
            Console.ReadKey();
        }
    }
}
