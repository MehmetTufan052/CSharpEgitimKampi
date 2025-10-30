using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü

            //Foreach(1;2;3;4)

            //1:Değişken Türü
            //2:Değişken adı
            //3:In
            //4:Liste,Koleksiyon,Dizi

            //string[] cities = { "milano", "roma", "budapeşte", "ankara", "istanbul","varşova" };

            //foreach (string x in cities)
            //{

            //    Console.WriteLine(x);
            //}


            //int[] numbers = { 45, 56, 789, 32, 44, 99, 12345 };
            //foreach (int number in numbers)
            //{ 

            //    Console.WriteLine(number);

            //}



            //int[] numbers = { 45, 56, 789, 32, 44, 99, 12345 };

            //foreach (int x in numbers)
            //{

            //    if (x % 2 == 0)
            //    {

            //        Console.WriteLine(x);

            //    }

            //}


            //int[] numbers = { 45, 56, 789, 32, 44, 99, 12345 };

            //int total = 0;


            //foreach (int i in numbers)

            //{

            //    total +=i;

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

            //string word = "Merhaba";

            //foreach (char c in word)
            //{
            //    Console.WriteLine(c);
            //}



            #endregion

            #region Örnek Sınav Uygulaması


            Console.WriteLine("***** C# Eğitim Kapmı Sınav Uygulaması *****");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            //Sınıftaki öğrenci sayısını kullanıcıdan alma
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Sınıfınızda Kaç Öğrenci Var: ");
            int studentCount=int.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------------");


            //Öğrenci isimlerini ve not ortalamalarını saklayacak diziler
            string[] studentNames=new string[studentCount];
            double[] studentExamAverage =new double[studentCount];
           

            for (int i = 0; i < studentCount; i++)
            {

                Console.Write($"{i + 1}.öğrencinin ismini giriniz: ");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;

               
                //Her öğrenci için 3 sınav notu girişi

                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} adlı öğrencinin {j + 1}.sınav notunu giriniz:");
                    double value=double.Parse(Console.ReadLine());
                    totalExamResult += value; //notları topluyoruz
                    
                }
                studentExamAverage[i] = totalExamResult / 3;
                Console.WriteLine();
                Console.WriteLine();
            }

           

            //sınav ortalamaları

            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması: {studentExamAverage[i]}");

                //Öğrencilerin ortalaması ve geçip kalma durumları

                if (studentExamAverage[i] >= 50)
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçti");
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı");
                }
                Console.WriteLine("--------------------");
            }


            #endregion
        }
    }
}
