using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace class_ornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Dikdörtgen alanı için 1, Ucgen alanı için 2 Çıkış için :0");
                int secim = int.Parse(Console.ReadLine());
                if (secim == 2)
                {
                    Console.WriteLine("Üçgenin kısa kenar bilgisini giriniz");
                    double u1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ucgenin uzun kenar bilgisini giriniz");
                    double u2 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Hesaplanıyor");
                    Thread.Sleep(2000);
                    Ucgen u = new Ucgen(u1, u2);
                    Console.WriteLine(u.AlanHesapla());
                    Console.ReadLine();

                }
                else if (secim == 1)
                {
                    Console.WriteLine("Kısa kenar uzunluğunu giriniz");
                    double k1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Uzun kenar uzunluğunu giriniz");
                    double k2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Hesaplanıyor");
                    Thread.Sleep(2000);
                    Dikdortgen d1 = new Dikdortgen(k1, k2);
                    Console.WriteLine(d1.AlanHesapla());
                    Console.ReadLine();

                }
                else if (secim == 0)
                {
                    Console.WriteLine("Çıkış yapılıyor");
                    Thread.Sleep(1500);
                    break;

                }

                else
                {
                    Console.WriteLine("Hatalı giriş yaptınız");

                }
                }
            }



        }
    }
    class GeometrikSekil
    {
        public virtual double AlanHesapla()
        {
            return 0;
        }
    }
    class Dikdortgen : GeometrikSekil
    {
        double uzunKenar;
        double kısaKenar;
        public  Dikdortgen(double uzunKenar,double kısaKenar)
        {
            this.uzunKenar = uzunKenar;
            this.kısaKenar = kısaKenar;

        }
        public override double AlanHesapla()
        {
            return uzunKenar * kısaKenar;

        }

    }
    class Ucgen : GeometrikSekil
    {
        private double taban;
        private double yukseklik;

        public  Ucgen(double taban, double yukseklik)
        {
            this.taban = taban;
            this.yukseklik = yukseklik;

        }
        public override double AlanHesapla()
        {
            return taban * yukseklik / 2;

        }
    }


