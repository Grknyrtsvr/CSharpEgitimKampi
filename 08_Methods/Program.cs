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
            #region Void metotlar

            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Hakan Öztürk");
            //    Console.WriteLine("Merve Çınar");
            //}
            //CustomerList();

            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}
            //Sum();

            #endregion

            #region Geriye değer döndürmeyen string parametreli metotlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}
            //WriteMethod("Gürkan Yurtsever");

            //void CustomerCard(string name,string surName)
            //{
            //    Console.WriteLine("Müşteri: " + name + " " + surName);
            //}
            //CustomerCard("Gürkan", "Yurtsever");
            //CustomerCard("Mehmet", "Çınar");

            #endregion

            #region Geriye değer döndürmeyen int parametreli metotlar

            //void Sum(int n1,int n2,int n3)
            //{
            //    int result = n1 + n2 + n3;
            //    Console.WriteLine(result);
            //}
            //Sum(5, 8, 9);

            #endregion

            #region Geriye değer döndüren metotlar

            //string CustomerName()
            //{
            //    return "Buse Yıldız";
            //}
            //CustomerName();

            //string StudenCard()
            //{
            //    string name = "Ali";
            //    string surname = "Yıldız";
            //    return name + " " + surname;
            //}
            //Console.WriteLine(StudenCard());

            #endregion

            #region Geriye değer döndüren string parametreli metotlar

            //string countryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = "Ülke: " + countryName + " Başkent: " + capital + " Bayrak rengi: " + flagColor; ;
            //    return cardInfo;
            //}
            //string x, y, z;
            //Console.Write("Ülke adını giriniz:");
            //x = Console.ReadLine();
            //Console.Write("Başkenti giriniz:");
            //y = Console.ReadLine();
            //Console.Write("Bayrak rengini giriniz:");
            //z = Console.ReadLine();

            //Console.WriteLine(countryCard(x, y, z));

            #endregion

            #region Geriye değer döndüren int parametreli metotlar

            //int Sum(int n1,int n2)
            //{
            //    int result = n1 + n2;
            //    return result;
            //}
            //Console.WriteLine(Sum(45, 85));
            //Console.WriteLine(Sum(78, 52));
            //Console.WriteLine(Sum(23, 92));

            #endregion

            #region Örnek uygulama

            //string ExamResult(string student,int exam1,int exam2,int exam3)
            //{
            //    int result = (exam1 + exam2 + exam3) / 3;
            //    if(result>=50)
            //    {
            //        return student + " isimli öğrenci sınavı geçti " + "Ortalama: " + result;
            //    }
            //    else
            //    {
            //        return student + " isimli öğrenci sınavı geçemedi " + "Ortalama: " + result;
            //    }
            //}
            //Console.WriteLine(ExamResult("Ali", 25, 41, 55));
            //Console.WriteLine(ExamResult("Ayşe", 36, 88, 33));

            #endregion

            Console.Read();
        }
    }
}
