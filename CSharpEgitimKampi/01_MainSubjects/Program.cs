using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Yazdırma Komutları
            //Console.WriteLine("WriteLine yazı yazdıktan sonra, İmleci bir alt satıra indirir");
            //Console.Write("Merhaba Dünyalı");

            //Console.WriteLine("** Yemek Kategorileri **");
            //Console.WriteLine();
            //Console.WriteLine("Soğuk Başlangıçlar");
            //Console.WriteLine("Ana Yemekler");
            //Console.WriteLine("Salatalar");
            //Console.WriteLine("Tatlılar");
            //Console.WriteLine("Içecekler");
            //Console.WriteLine();
            //Console.WriteLine("** Yemek Kategorileri **");
            #endregion


            #region String Değişkenler:
            //string name;
            //string surName;
            //name = "Jemal";
            //surName = "Amanova";

            //string customerPhone, customerEmail, district, city;
            //customerPhone = "+(90) 535 756 11 11";
            //customerEmail = "deneme@gmail.com";
            //district = "Ataşehir";
            //city = "Istanbu";

            //Console.WriteLine("** Müşteri Bilgileri **");
            //Console.WriteLine();
            //Console.WriteLine("------------------------------");
            //Console.WriteLine("Müşteri: " + name + " " + surName);
            //Console.WriteLine("Iletişim: " + customerPhone + "," +customerEmail);
            //Console.WriteLine("Adres: " + district + "," + city);
            //Console.WriteLine("------------------------------");

            #endregion

            #region Int değişkenler:

            int pizzaPrice = 200;
            int kolaPrice = 40;
            int waterPrice = 15;

            int totalPrice = pizzaPrice + kolaPrice + waterPrice;
            Console.WriteLine(totalPrice);

            #endregion

            Console.Read();
        }
    }
}
