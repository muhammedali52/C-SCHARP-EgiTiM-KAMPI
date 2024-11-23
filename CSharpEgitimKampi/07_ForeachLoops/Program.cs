using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region foreAch döngüsü

            //foreach(1;2;3;4)

            //1: değişken türü
            //2: değişken adı
            //3: In
            //4: liste , koleksiyon , dizi

            //string[] cities = {"Milano" ,"Roma","Budapeşte","Ankara","İstanbul","Varşova"};

            //foreach (string x in cities) 
            //{
            //    Console.WriteLine(x);
            //}



            //int[] number = { 154, 562, 3333 ,54455,545,454,545,644};

            //foreach (int i in number) 
            //{
            //    Console.WriteLine(i);
            //}




            //int[] number = { 154, 562, 3333, 54455, 545, 454, 545, 644 ,458 ,521 };

            //foreach (int i in number) 
            //{
            //    if (i %2== 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


            //int[] number = { 154, 562, 3333, 54455, 545, 454, 545, 644, 458, 521 };
            //int total = 0;

            //foreach (int i in number) 
            //{
            //    total += i;
            //}
            //Console.WriteLine(total);



            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,8
            //};

            //foreach (int number in numbers) 
            //{
            //    Console.WriteLine(number);
            //}


            //string word = "merhaba";

            //foreach (char s in word) 
            //{
            //    Console.WriteLine(s);
            //}




            #endregion




            #region örnek sınav sistemi uygulaması


            Console.Write("******** C# EĞİTİM KAMPI SINAV UYGULAMASI********");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //sınıftaki öğernci sayısını kullanıcıdan alma
            Console.WriteLine("-----------------------------------");
            Console.Write("Sınıfınızda Kaç Öğrenci Var : ");
            int studentCount=int.Parse(Console.ReadLine());
            Console.WriteLine("-----------------------------------");


            //öğrenci isim ve not ortalamalarını saklayacak diziler
            string[] studentName=new string[studentCount];
            double[] studentExamAvg=new double[studentCount];


            for(int i=0; i<studentCount; i++) 
            {
                Console.Write((i+1) +". öğrencinin adını giriniz: ");
                studentName[i] = Console.ReadLine();

                double totalExamResult = 0;

                for (int j = 0; j < 3; j++) 
                {
                    Console.Write( studentName[i]+ "  adlı öğrencinin "+ (j+1)+". sınav notunu giriniz: ");
                    double value=double.Parse(Console.ReadLine());
                    totalExamResult += value;
                }
                Console.WriteLine();
                studentExamAvg[i] = totalExamResult / 3;
            }




            //sınav ortalamaları

            for (int i = 0; i < studentCount; i++) 
            {
                Console.WriteLine("-----------------------------------");
                Console.WriteLine($"{studentName[i]} adlı öğrencinin ortalaması  {studentExamAvg[i]}");
                Console.WriteLine();
                //öğrencinin keçip kalma durumu

                if (studentExamAvg[i] >= 50)
                {
                    Console.WriteLine($"{studentName[i]} adlı öğrenci dersten geçti. ");
                }
                else 
                {
                    Console.WriteLine($"{studentName[i]}  adlı öğrenci dersten kaldı.  ");
                }
                Console.WriteLine();
                Console.WriteLine("-----------------------------------");
            }





            #endregion





            Console.Read();
        }
    }
}
