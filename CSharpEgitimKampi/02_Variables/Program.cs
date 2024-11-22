using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double değişkenler
            //double number;

            //number = 4.85;

            //Console.WriteLine(number);

            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;
            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.75;
            //tomatoPrice = 6.88;

            //Console.WriteLine("---- Elma Birim Fiyatı:" + applePrice + " TL");
            //Console.WriteLine("---- Portakal Birim Fiyatı:" + orangePrice + " TL");
            //Console.WriteLine("---- Çilek Birim Fiyatı:" + strawberryPrice + " TL");
            //Console.WriteLine("---- Patates Birim Fiyatı:" + potatoPrice + " TL");
            //Console.WriteLine("---- Domates Birim Fiyatı:" + tomatoPrice + " TL");

            //Console.WriteLine();
            //Console.WriteLine();

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;

            //Console.WriteLine("Alınan Ürün: Elma- "+" Birim Fiyatı: " +applePrice+" -Gramaj: "+appleGram +" -Toplam Tutar: "+appleTotalPrice);
            //Console.WriteLine("Alınan Ürün: Portakal- "+" Birim Fiyatı: " +orangePrice+" -Gramaj: "+orangeGram +" -Toplam Tutar: "+orangeTotalPrice);
            //Console.WriteLine("Alınan Ürün: Çilek- "+" Birim Fiyatı: " +strawberryPrice+" -Gramaj: "+strawberryGram +" -Toplam Tutar: "+strawberryTotalPrice);
            //Console.WriteLine("Alınan Ürün: Patates- "+" Birim Fiyatı: " +potatoPrice+" -Gramaj: "+potatoGram +" -Toplam Tutar: "+potatoTotalPrice);
            //Console.WriteLine("Alınan Ürün: Domates- "+" Birim Fiyatı: " +tomatoPrice+" -Gramaj: "+tomatoGram +" -Toplam Tutar: "+tomatoTotalPrice);

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;

            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Alışverişin toplam fiyatı :" +shoppingTotalPrice +" TL");






            #endregion


            #region CHAR DEĞİŞKENLER

            //char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);






            #endregion

            #region klavyeden veri girişleri string değişkenler

            //Console.WriteLine("**** c# hava yolları yolcu bilgileri ****");
            //string pasangerName, pasangerSurname, pasangerDistrict, pasangerCity, pasangerAge, pasangerIdentityNumber;

            //Console.Write("yolcu adı: ");
            //pasangerName=Console.ReadLine();

            //Console.Write("yolcu soyadı: ");
            //pasangerSurname=Console.ReadLine();

            //Console.Write("ilçe bilgisi: ");
            //pasangerDistrict = Console.ReadLine();

            //Console.Write("şehir bilgisi: ");
            //pasangerCity = Console.ReadLine();

            //Console.Write("yaş bilgisi: ");
            //pasangerAge = Console.ReadLine();

            //Console.Write("tc kimlik no bilgisi: ");
            //pasangerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();

            //Console.WriteLine("--------------------------------");

            //Console.WriteLine("tc kimlik numarası "+pasangerIdentityNumber+"  "+"yolcu ad-soyad "+pasangerName+" "+pasangerSurname + " "+ pasangerDistrict+"/"+pasangerCity+" "+pasangerAge);


            #endregion

            #region klavyeden tam sayı girişi ve dönüşümleri


            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen Aldığınız ayakkabı sayısını giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız bilgisayar sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız sandalye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız televizyon sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice=shoesCount*shoesPrice+tvCount*tvPrice+chairCount*chairPrice+computerCount*computerPrice;


            //Console.Write("toplam ödemeniz gereken tutar: "+totalPrice);


            #endregion

            #region klavyeden ondalıklı sayı işlemleri

            //double exem1, exem2, exem3, result;

            //Console.Write("lütfen 1.sınav notunu giriniz: ");
            //exem1=double.Parse(Console.ReadLine());

            //Console.Write("lütfen 2.sınav notunu giriniz: ");
            //exem2 = double.Parse(Console.ReadLine());

            //Console.Write("lütfen 3.sınav notunu giriniz: ");
            //exem3 = double.Parse(Console.ReadLine());

            //result = (exem1 + exem2 + exem3) / 3;

            //Console.Write("sınav ortalamanız: " + result);
            #endregion


            #region klavyeden karakter girişleri


            //char gender;
            //Console.Write("Lütfen Cinsiyet Seçiniz: ");
            //gender=char.Parse(Console.ReadLine());

            //Console.Write("seçtiğiniz cinsiyet: "+gender);


            #endregion





            Console.Read();
        }
    }
}
