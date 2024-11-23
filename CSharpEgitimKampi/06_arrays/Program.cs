using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region TEMEL DİZİ ÖRNEKLERİ

            //sarı,kırmızı,mavi,beyaz
            //adana,ordu,kastamonu
            //DeğişkenTürü [] DiziAdı =new DeğişkenTürü[ElemanSayısı]

            //string[] colors = new string[4];
            //colors[0] = "kırmızı";
            //colors[1] = "sarı";
            //colors[2] = "mavi";
            //colors[3] = "yeşil";


            //Console.WriteLine(colors[1]);

            //string[] cities = new string[5];
            //cities[0] = "milano";
            //cities[1] = "istanbul";
            //cities[2] = "ankara";
            //cities[3] = "yalova";
            //cities[4] = "eskişehir";

            //Console.WriteLine(cities[4]);


            //int[] numbers = new int[10];
            //numbers[0] = 40;
            //numbers[1] = 264; 
            //numbers[2] = 344;
            //numbers[3] = 44;
            //numbers[7] = 58;

            //Console.WriteLine(numbers[7]);



            //string[] cities = { "prag", "roma", "atina", "ankara", "bursa" };

            //Console.WriteLine(cities[2]);
            #endregion

            #region dizideki tüm elemanları listeleme

            //string[] colors = {"Sarı","Mavi","Beyaz","Turuncu","Kırmızı","Siyah","Mor" };


            //for (int i = 0; i < colors.Length; i++) 
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 145, 42, 553, 454, 585, 46, 17, 18, 879, 1110, 5411, 412, 5413, 5414 };

            //for (int i = 0; i < numbers.Length; i++) 
            //{
            //    if(numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}



            //char[] symbols = { 'A', 'b', 't', '+', '-', '/', '*'};

            //for (int i = 0; i < symbols.Length; i++) 
            //{
            //    Console.WriteLine(symbols[i]);
            //}


            //int[] myArryay = { 154, 4542, 54, 64, 6464, 313, 994, 4976, 21, 4131, 649461, 64643 };
            //int maxNumber=myArryay[0];

            //for (int i = 0; i < myArryay.Length; i++) 
            //{
            //    if (myArryay[i]>maxNumber)
            //    {
            //        maxNumber = myArryay[i];
            //    }
            //}
            //Console.WriteLine(maxNumber);


            //string[] persons = {"Ali","Ayşe","Ahmet","Cem","Veli","Deniz","Yusuf" };

            //Console.WriteLine(persons.Length);



            //int[] numbers = { 145, 42, 553, 454, 585, 46, 17, 18, 879, 1110, 5411, 412, 5413, 5414 };
            //Array.Sort(numbers);

            //for (int i = 0; i < numbers.Length; i++) 
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //int[] numbers = {145,42,553,454,585,46,17,18,879,1110,5411,412,5413,5414};
            //Array.Reverse(numbers);

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}





            #endregion



            #region dizi metotları


            //string[] customers = {"ali","ayşe","mehmet","dursun","çınar" };
            //int index = Array.IndexOf(customers, "dursun");
            //Console.WriteLine(index);



            //int[] numbers = { 132, 265, 8673, 9874, 565, 4566, 6567, 348, 1549, 5410, 3511, 4612, 5713, 9814 };

            //Console.WriteLine(" DİZİNİN EN BÜYÜK ELEMANI: "+numbers.Max() +"  dizinin en küçük elemanı : "+numbers.Min());



            #endregion

            #region klavyeden değer alma

            //string[] cities = new string[5];

            //for (int i = 0; i < cities.Length; i++) 
            //{
            //    Console.WriteLine("lütfen "+(i+1) +" şehri giriniz");
            //    cities[i] = Console.ReadLine();
            //}

            //Console.WriteLine();
            //Console.WriteLine("----------------");

            //for (int i = 0; i < cities.Length; i++) 
            //{
            //    Console.WriteLine(cities[i]);
            //}


            //int[] numbers = { 71, 23, 73, 49, 85, 65, 47, 84, 95, 110 };
            //int sum = 0;

            //for (int i = 0; i < numbers.Length; i++) 
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum);




            //int[] numbers = { 21, 42, 23, 54, 215, 36, 47, 18, 349, 120};

            //Console.WriteLine("çift sayılar");
            //Console.WriteLine();

            //for (int i = 0; i < numbers.Length; i++) 
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            //Console.WriteLine("--------------");
            //Console.WriteLine("tek sayılar");
            //Console.WriteLine();
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 1)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}



            #endregion
            Console.Read();
        }
    }
}
