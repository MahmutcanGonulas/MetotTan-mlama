using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //erişim belirteçi, geri dönüş tipi, metot adı(parametre listesi argüman){ 
            //komutlar
            //return
            //}
            int a, b;
            Console.WriteLine("1. sayiyi giriniz");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. sayiyi giriniz");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Toplam == " + (topla(a, b)));

            Metotlar mt=new Metotlar();
            mt.EkranaYazdir("assdad");

            Console.WriteLine("a şuan == {0} \nb şuan== {1}",a,b);
            Console.WriteLine(mt.ArttirVeTopla(ref a,ref b));
            Console.WriteLine("a şuan == {0} \nb şuan== {1}",a,b);
            


        }
        public static int topla(int a, int b)
        {
            return a + b;
        }


    }

    class Metotlar
    {
        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }

        public int ArttirVeTopla(ref int deger1,ref int deger2){
            deger1++;
            deger2++;
            return deger1+deger2;
        }
    }
}
