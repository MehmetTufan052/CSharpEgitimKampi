using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Yazdırma Komutları
            //Console.WriteLine("Selam");
            //Console.Write("Merhaba Dünya");

            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorileri *****");

            #endregion

            #region String Değişkenler

            //string
            //Değişken_türü Değişken_adı;

            //string name;
            //name = "Tufan";
            //Console.Write(name);


            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail,district,city;

            //customerName = "Tufan";
            //customerSurname = "Eser";
            //customerPhone = "+90 555 444 33 22";
            //customerEmail = "deneme@gmail.com";
            //district = "Fatsa";
            //city = "Ordu";

            //Console.WriteLine("**** Rezervasyon Kartı ****");
            //Console.WriteLine();
            //Console.WriteLine("-----------------------");
            //Console.WriteLine("Müşteri : "+customerName+" "+customerSurname);
            //Console.WriteLine("İletişim : "+customerPhone);
            //Console.WriteLine("Email Adresi : "+customerEmail);
            //Console.WriteLine("Adres : " + district+ "/" + city);
            //Console.WriteLine("-----------------------");

            //Console.WriteLine();

            //customerName = "Emre";
            //customerSurname = "Türkoğlu";
            //customerPhone = "+90 555 444 55 66";
            //customerEmail = "deneme2@gmail.com";
            //district = "Aybastı";
            //city = "Ordu";

            //Console.WriteLine("-----------------------");
            //Console.WriteLine("Müşteri : " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim : " + customerPhone);
            //Console.WriteLine("Email Adresi : " + customerEmail);
            //Console.WriteLine("Adres : " + district + "/" + city);
            //Console.WriteLine("-----------------------");



            #endregion

            #region Int Değişkenler

            //int
            //int number=24;
            //Console.Writeline(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("****** Restoran Menü Fiyatı *******");
            Console.WriteLine();
            Console.WriteLine("-----Hamburger: "+hamburgerPrice+" TL");
            Console.WriteLine("-----Pizza: "+pizzaPrice+" TL");
            Console.WriteLine("-----Kola: "+cokePrice+" TL");
            Console.WriteLine("-----Limonata: "+lemonadePrice+" TL");
            Console.WriteLine("-----Kızartma: "+friesPrice+" TL");
            Console.WriteLine("-----Su: "+waterPrice+" TL");
            Console.WriteLine();
            Console.WriteLine("****** Restoran Menü Fiyatı *******");

            Console.WriteLine();

            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;


            int totalHamburgerPrice;
            int totalCokePrice;
            int totalWaterPrice;
            int totalFriesPrice;
            int totalPizzaPrice;
            int totalLemonadePrice;

            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3; 
            friesCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalWaterPrice = waterCount * waterPrice;
            totalFriesPrice = friesCount * friesPrice;         
            totalPizzaPrice = pizzaCount * pizzaPrice;
            totalLemonadePrice = lemonadeCount * lemonadePrice;


            Console.WriteLine("----------------");
            Console.WriteLine("Hamburger Tutarı :"+totalHamburgerPrice+" TL");
            Console.WriteLine("Kola Tutarı :"+totalCokePrice+" TL");
            Console.WriteLine("Su Tutarı :"+totalWaterPrice+" TL");
            Console.WriteLine("Patates Kızartması Tutarı :"+totalFriesPrice+" TL");
            Console.WriteLine("Pizza Tutarı :"+totalPizzaPrice+" TL");
            Console.WriteLine("Limonata Tutarı :"+totalLemonadePrice+" TL");

            int totalPrice = totalHamburgerPrice + totalCokePrice + totalWaterPrice + totalFriesPrice + totalPizzaPrice + totalLemonadePrice;

            Console.WriteLine("Toplam Ödenecek Tutar :" + totalPrice + " TL");

            #endregion

            Console.Read();
        }
    }
}
