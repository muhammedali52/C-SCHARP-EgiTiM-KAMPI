using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        private const string V = "ogrenci basarisiz oldu";

        static void Main(string[] args)
        {

            #region void metotlar

            //() 
            // geriye değer döndürmeyen metotlar
            // customer -> listele - ekle - sil - güncelle
            // void 


            //void CustomerList()
            //{
            //    Console.WriteLine("ALİ YILDIZ");
            //    Console.WriteLine("AYŞE YILDIZ");
            //    Console.WriteLine("HAKAN ÖZTÜRK");
            //    Console.WriteLine("MERVE ÇINAR");
            //}



            //CustomerList();
            //CustomerList();
            //CustomerList();
            //CustomerList();



            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x+y;
            //    Console.WriteLine(z);
            //}

            //Sum();


            #endregion

            #region geriye değer döndürmeyen string parametreli metotlar



            //void WriteMethod(string customerName) 
            //{ 

            //    Console.WriteLine(customerName);

            //}


            //WriteMethod("muhammed ali köse");



            //void CustomerCard(string name, string surName)
            //{
            //    Console.WriteLine("Müşteri: "+name+ " " + surName);
            //}


            //CustomerCard("ayşe","akgün");

            //CustomerCard("mehmet","yıldız");





            #endregion


            #region geriye değer döndürmeyen int parametreli metotlar



            //void Sum(int number1 ,int number2, int number3) 
            //{
            //    int result=number1+number2+number3;
            //    Console.WriteLine(result);
            //}

            //Sum(4, 5, 6);



            #endregion

            #region geriye değer döndüren  metotlar

            //string CustomerName()
            //{
            //    return "buse yıldız";
            //}


            //CustomerName();



            //string StudentCard()
            //{
            //    string name = "ali";
            //    string surName = "kaya";
            //    return name + " " +surName;
            //}

            //Console.WriteLine(StudentCard());





            #endregion


            #region geriye değer döndüren string parametreli  metotlar

            //string CountryCard(string countryName, string capital, string flagColor) 
            //{
            //    string cardInfo="Ülke:  " +countryName+"- Basşkenti: "+capital+" - Bayrak Rengi: "+flagColor;
            //    return cardInfo;
            //}

            //string x, y, z;
            //Console.WriteLine("ülke adını giriniz: ");
            //x = Console.ReadLine();
            //Console.WriteLine("ülke başkent adını giriniz: ");
            //y = Console.ReadLine();
            //Console.WriteLine("ülke bayrak  rengini giriniz: ");
            //z = Console.ReadLine();




            //Console.WriteLine(CountryCard(x, y, z));

            //Console.WriteLine(CountryCard("ukrayna","kiev","kırmızı-mavi-beyaz"));








            #endregion


            #region geriye değer döndüren int parametreli  metotlar


            //int Sum(int number1, int number2) 
            //{
            //    int result=number1+number2;
            //    return result;
            //}


            //Console.WriteLine(Sum(45,98));
            //Console.WriteLine(Sum(455,98));
            //Console.WriteLine(Sum(475,968));
            //Console.WriteLine(Sum(145,98));
            //Console.WriteLine(Sum(425,198));







            #endregion


            #region örnek uygulama

            string ExamResult(string student,int exam1,int exam2,int exam3) 
            {
                int result = (exam1+exam2+exam3)/3;
                if (result >= 50)
                {
                    return student +" isimli öğrenci sınavı geçti "+" ortalama : "+ result ;
                }
                else 
                {
                    return student + " isimli öğrenci sınavı geçemedi " + " ortalama : " + result;
                }
            }



            Console.WriteLine(ExamResult("ali",45,85,23));
            Console.WriteLine(ExamResult("ayşe",45,25,23));
            Console.WriteLine(ExamResult("veli",45,45,73));
            Console.WriteLine(ExamResult("muhammed",75,87,23));


            #endregion


            Console.Read();
        }
    }
}
