using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDasicion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else
            //Console.Write("Lütfen Şifreyi Girin: ");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre Doğru");
            //}
            // else
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //}

            //string capital, country;
            //Console.Write("Başkenti Girin: ");
            //capital = Console.ReadLine();

            //Console.WriteLine("Ülkeyi Girin");
            //country = Console.ReadLine();

            //if (capital=="ankara" & country=="türkiye")
            //{
            //    Console.Write("Bilgiler Doğrulandı");
            //}
            //else 
            //{
            //    Console.Write("Bilgiler hatalı");
            //}

            //int number;
            //Console.Write("Sayıyı girin");
            //number= int.Parse(Console.ReadLine());

            //if (number == 5 ) 
            //{
            //    Console.WriteLine("Sayı Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı Yanlış");
            //}

            //int exam1, exam2, exam3, average;
            //string result="Hata";

            //Console.Write("Sınav 1: ");
            //exam1=int.Parse(Console.ReadLine());

            //Console.Write("Sınav 2: ");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.Write("Sınav 3: ");
            //exam3 = int.Parse(Console.ReadLine());
            //average=(exam1+exam2+exam3)/3;

            //if(average>0 & average<=50) 
            //{
            //    result="Sonuç vasat";
            //}

            //if (average > 50 & average <= 70)
            //{
            //    result = "Sonuç Orta";
            //}

            //if (average > 70 & average <= 84)
            //{
            //    result = "Sonuç iyi";
            //}

            //if (average > 84 )
            //{
            //    result = "Sonuç Çok İyi";
            //}

            //Console.WriteLine(result); //Eğer resulta ilk başta bir değer atamazsak veya else ile result değeri yazmazsak, hata verecektir.


            //string city;
            //Console.Write("Şehir ismi girin: ");
            //city = Console.ReadLine();

            //if (city == "Ankara" | city == "Adana" | city == "Bursa" | city == "Istanbul")
            //{
            //    Console.WriteLine("Şehir mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir mevcut değil");
            //}

            //Console.Write("Kullanıcı adı giriniz:");
            //string username= Console.ReadLine();

            //if(username!="admin")
            //{
            //    Console.WriteLine("Kullanıcı adı yanlış");
            //}
            //else
            //{
            //    Console.WriteLine("Hoşgeldiniz!");
            //}
            #endregion

            #region Mod İşlmeleri
            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("1. sayıyı girin: ");
            //int num1=int.Parse(Console.ReadLine());

            //Console.Write("2. sayıyı girin: ");
            //int num2 = int.Parse(Console.ReadLine());

            //int result=num1%num2;
            //Console.Write("sayı1'in sayı2'ye modu: " + result);

            //Console.Write("Lütfen Bir Sayı Giriniz: ");
            //int number=int.Parse(Console.ReadLine());

            //if (number%2 == 0) 
            //{
            //    Console.WriteLine("Girdiğiniz Sayı Çifttir. ");
            //}
            //else
            //{
            //    Console.WriteLine("Girdiğiniz sayı tek sayı.");
            //}
            #endregion

            #region Çar Değişkenler İle Karar Yapıları:

            //char team;
            //Console.Write("Lütfen Takımınızın sembölünü girin:");
            //team=char.Parse(Console.ReadLine());

            //if(team == 'g' | team == 'G')
            //{
            //    Console.Write("Tuttuğunuz takım: Galatasaray!");
            //}

            //if (team == 'f' | team == 'F')
            //{
            //    Console.Write("Tuttuğunuz takım: Fenerbahçe!");
            //}

            //if (team == 'b' | team == 'B')
            //{
            //    Console.Write("Tuttuğunuz takım: Beşiktaş!");
            //}
            #endregion

            #region Örnek Proje Uygulaması:

            //Console.WriteLine("** MENÜ **");
            //Console.WriteLine();
            //Console.WriteLine("-----------------");
            //Console.WriteLine("1. Ana Yemekler:");
            //Console.WriteLine("2. Çorbalar:");
            //Console.WriteLine("3.Pizallar: ");
            //Console.WriteLine("4. içecekler:");
            //Console.WriteLine("5. Tatlılar: ");
            //Console.WriteLine("-----------------");
            //Console.WriteLine();

            //string menuItem;
            //Console.Write("Detayını Görmek istediğiniz menüyü seçin: ");
            //menuItem=Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----Ana Yemekler-----");
            //    Console.WriteLine();
            //    Console.WriteLine("1. Körülü Tavuk");
            //    Console.WriteLine("2. Kızartma ");
            //    Console.WriteLine("3. Fasulye pilav");
            //    Console.WriteLine("4. Fırında Somon");
            //    Console.WriteLine("5. Musakka");
            //    Console.WriteLine("-----Ana Yemekler-----");
            //    Console.WriteLine();
            //}

            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----Çorbalar-----");
            //    Console.WriteLine();
            //    Console.WriteLine("1. Mercimek");
            //    Console.WriteLine("2. Ezo ");
            //    Console.WriteLine("3. Kelle");
            //    Console.WriteLine("4. Işkembe");
            //    Console.WriteLine("-----Çorbalar-----");
            //    Console.WriteLine();
            //}

            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----Pizzalar-----");
            //    Console.WriteLine();
            //    Console.WriteLine("1. Mozarella");
            //    Console.WriteLine("2. Bol Malzemos ");
            //    Console.WriteLine("3. Sebze sever");
            //    Console.WriteLine("4. Et Sever");
            //    Console.WriteLine("-----Pizzalar-----");
            //    Console.WriteLine();
            //}

            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----Içecekler-----");
            //    Console.WriteLine();
            //    Console.WriteLine("1. Kola");
            //    Console.WriteLine("2. soda ");
            //    Console.WriteLine("3. Soğuk çay");
            //    Console.WriteLine("4. Sıcak Çay");
            //    Console.WriteLine("-----Içecekler-----");
            //    Console.WriteLine();
            //}

            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----Tatlılar-----");
            //    Console.WriteLine();
            //    Console.WriteLine("1. Triliçe");
            //    Console.WriteLine("2. Kazandibi ");
            //    Console.WriteLine("3. sütlaç");

            //    Console.WriteLine("-----Tatlılar-----");
            //    Console.WriteLine();
            //}
            #endregion

            #region Switch Case
            //Console.WriteLine("Lütfen Ay girişi yapınız: ");
            //int monthNumber=int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1: Console.WriteLine("Ocak"); break;
            //    case 2: Console.WriteLine("Şubat"); break;
            //    case 3: Console.WriteLine("Mart"); break;
            //    case 4: Console.WriteLine("Nisan"); break;
            //    case 5: Console.WriteLine("Mayıs"); break;
            //    case 6: Console.WriteLine("Haziran"); break;
            //    case 7: Console.WriteLine("Temmuz"); break;
            //    case 8: Console.WriteLine("Ağustos"); break;
            //    case 9: Console.WriteLine("Eylül"); break;
            //    case 10: Console.WriteLine("Ekim"); break;
            //    case 11: Console.WriteLine("Kasım"); break;
            //    case 12: Console.WriteLine("Aralık"); break;
            //    default: Console.WriteLine("Hatalı Giriş!"); break;

            //}s
            #endregion

            #region Switch Case Hesap Makinesi:
            //int num1, num2, result;
            //char sembol;

            //Console.Write("1. sayıyı girin:");
            //num1=int.Parse(Console.ReadLine());

            //Console.Write("2. sayıyı girin:");
            //num2 = int.Parse(Console.ReadLine());

            //Console.Write("Yapmak istediğiniz işlemi giriniz:");
            //sembol = char.Parse(Console.ReadLine());

            //switch (sembol)
            //{
            //    case '+':
            //        result=num1 + num2; 
            //        Console.WriteLine("Toplam:"+result); break;

            //    case '-':
            //        result = num1 - num2;
            //        Console.WriteLine("Çıkarma:" + result); break;

            //    case '*':
            //        result = num1 * num2;
            //        Console.WriteLine("Çarpım:" + result); break;

            //    case '/':
            //        result = num1 / num2;
            //        Console.WriteLine("Bölme:" + result); break;
            //}

            #endregion

            Console.Read();
        }
    }
}
