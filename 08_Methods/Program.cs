using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metotlar

            //()
            //Geriye Değer Döndürmeyen Metotlar
            //Customer-Listele,ekle,sil,güncelle

            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Hakan Öztürk");
            //    Console.WriteLine("Merve Çınar");


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

            #region Geriye Değer Döndürmeyen String Parametreli Metotlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}
            //WriteMethod("Mehmet Eser");

            //void CustomerCard(string name,string surName)
            //{

            //    Console.WriteLine("Müşteri:" + name + " " + surName);

            //}

            //CustomerCard("Mehmet", "Tufan");
            //CustomerCard("Serhan", "Pehlivan");
            //CustomerCard("Taha", "Güney");



            #endregion

            #region Geriye Değer Döndürmeyen İnt Parametreli Metotlar

            //void Sum(int number1, int number2,int number3)
            //{

            //    int result=number1+number2+number3;
            //    Console.WriteLine(result);

            //}
            //Sum(4, 5, 6);

            #endregion

            #region Geriye Değer Döndüren  Metotlar

            //string CustomerName()
            //{
            //    return "Buse Yıldız";
            //}

            //CustomerName();


            //string StudentCard()
            //{

            //    string name = "Ali";
            //    string surname = "Yıldız";

            //    return name + " " + surname;


            //}

            //Console.WriteLine(StudentCard());

            #endregion


            #region Geriye Değer Döndürenstring Parametreli Metotlar

            //string CountryCard(string countryName,string capital,string flagColor)
            //{

            //    string cardInfo = "Ülke: " + countryName + "- Başkent: " + capital + "- Bayrak Rengi: " + flagColor;
            //    return cardInfo;

            //}

            //string x, y, z;

            //Console.WriteLine("Ülke Adı Giriniz:");
            //x=Console.ReadLine();

            //Console.WriteLine("Başkent giriniz:");
            //y= Console.ReadLine();

            //Console.WriteLine("Bayrak rengi giriniz: ");
            //z= Console.ReadLine();


            //Console.WriteLine(CountryCard(x, y, z));

            #endregion

            #region Geriye Değer Döndüren String Parametreli Metotlar

            //string CountryCard(string countryName,string capital,string flagColor)
            //{

            //    string cardInfo = "Ülke: " + countryName + "- Başkent: " + capital + "- Bayrak Rengi: " + flagColor;
            //    return cardInfo;

            //}

            //string x, y, z;

            //Console.WriteLine("Ülke Adı Giriniz:");
            //x=Console.ReadLine();

            //Console.WriteLine("Başkent giriniz:");
            //y= Console.ReadLine();

            //Console.WriteLine("Bayrak rengi giriniz: ");
            //z= Console.ReadLine();


            //Console.WriteLine(CountryCard(x, y, z));

            #endregion

            #region Geriye Değer Döndüren Int Parametreli Metotlar

            //int Sum(int number1,int number2)
            //{
            //    int result=number1+number2;

            //    return result;


            //}

            //Console.WriteLine(Sum(44, 25));
            //Console.WriteLine(Sum(50, 120));
            //Console.WriteLine(Sum(24, 65));
            //Console.WriteLine(Sum(42, 95));
            //Console.WriteLine(Sum(40, 35));

            #endregion

            #region Örnek Uygulama

            string ExamResult(string student,int exam1,int exam2,int exam3)
            {

                int result = (exam1 + exam2 + exam3) / 3;

                if (result >= 50)
                {

                    return student+ " isimli öğrenci sınavı geçti "+"Ortalama: "+result;

                }
                else 
                {

                    return student + " isimli öğrenci başarısız oldu " + "Ortalama: " + result;

                }

                
               
            }
            Console.WriteLine(ExamResult("Ali", 30, 40, 70));
            Console.WriteLine(ExamResult("Tufan", 50, 60, 80));

            Console.Read();
            #endregion

        }
    }
}
