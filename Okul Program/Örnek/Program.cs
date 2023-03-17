using Örnek;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Örnek
{
    class Okul
    {
        public byte dvmszlk;
        public  float ort;
        public string adSoyad;
        public string tc;

    }
    class Ogrenci : Okul
    {

        bool disiplin;

        public void dersProgramı()
        {
            Console.Clear();
            Console.WriteLine("   -  Ders Programı  - ");
            Console.WriteLine("");
            Console.Write(" Pazartesi : Edebiyat | Edebiyat | Matematik | Matematik | Matematik | Beden Egitimi Ve Görsel | Beden Egitimi Ve Görsel ");
            Console.WriteLine("");
            Console.Write(" Salı :      Kimya    |  Kimya   | Felsefe   | Felsefe   | Matematik | Din Kültürü Ve Ahlak    | Din Kültürü Ve Ahlak     ");
            Console.WriteLine("");
            Console.Write(" Carsamba :  Edebiyat | Edebiyat | Edebiyat  | Matematik | Matematik | Cografya                | Cografya");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write(" Persembe :  Tarih    | Tarih    | Fizik     | Fizik     | Biyoloji  | Robotik ve Kodlama      | Robotik ve Kodlama      ");
            Console.WriteLine("");
            Console.Write(" Cuma     :  NTP      |  NTP     | NTP       | NTP       | NTP       | Edebiyat                | Secmeli Ders ");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(" Ders Programı - 17.03.2023");
        }
        public void ogrenciBilgi()
        {
            Console.Clear();
            Console.Write(" Ad - Soyad : ");
            adSoyad = Console.ReadLine();
            Console.WriteLine("");
            Console.Write(" Okul Numaranızı Giriniz : ");
            int okulNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            System.Threading.Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine(okulNo + "|" + adSoyad + "|" + "Olarak Giriş Yapılıyor.");
        }
        public void ortalama()
        {
            Console.Clear();
            Console.Write(" Edebiyat Ortalamanızı Giriniz : ");
            byte eo = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("");
            Console.Write(" Matematik Ortalamanızı Giriniz : ");
            byte mo = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("");
            Console.Write(" Kimya Ortalamanızı Giriniz : ");
            byte ko = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("");
            Console.Write(" Tarih Ortalamanızı Giriniz : ");
            byte to = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("");
            Console.Write(" Biyoloji Ortalamanızı Giriniz : ");
            byte bo = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("");
            Console.Write(" Felsefe Ortalamanızı Giriniz : ");
            byte fo = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("");
            Console.Write(" Yabancı Dil Ortalamanızı Giriniz : ");
            byte yo = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("");
            Console.Write(" Meslek Dersi Ortalamanızı Giriniz : ");
            byte ao = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("");
            ort = (mo + ao + to + ko + eo + bo + fo + yo) / 8;
            Console.Write(" Genel Ortalamnız : " + ort);
        }
        public void belge()
        {
            Console.Clear();
            if (ort >= 50 && ort <= 69)
            {
                if (disiplin == false || dvmszlk < 5)
                {
                    Console.WriteLine("");
                    Console.WriteLine(" Düz Geçtiniz !");
                }
                if(disiplin == true)
                {
                    Console.WriteLine("");
                    Console.WriteLine(" Kaldınız!");
                }
                if(dvmszlk >= 5)
                {
                    Console.WriteLine("");
                    Console.WriteLine(" Belge Alamadan Düz Gectiniz!!");
                }
            }
            if (ort >= 70 && ort < 85)
            {
                if (disiplin == false || dvmszlk < 5)
                {
                    Console.WriteLine(" Tesekkur Belgesi ile Geçtiniz !");
                }
                if (disiplin == true)
                {
                    Console.WriteLine(" Kaldınız!");
                }
                if (dvmszlk >= 5)
                {
                    Console.WriteLine(" Belge Alamadan Düz Gectiniz!");
                }
            }
            if (ort >= 85 )
            {
                if (disiplin == false || dvmszlk < 5)
                {
                    Console.WriteLine(" Takdir Belgesi ile Geçtiniz !");
                }
                if (disiplin == true)
                {
                    Console.WriteLine(" Kaldınız!");
                }
                if (dvmszlk >= 5)
                {
                    Console.WriteLine(" Belge Alamadan Düz Gectiniz!");
                }
            }
            Console.ReadKey();
        }
        public void devamsizlik()
        {
            Console.Clear();
            Console.WriteLine("Ogrencini Devamsızlıgını Giriniz : ");
            dvmszlk = Convert.ToByte(Console.ReadLine());
            Console.Write(dvmszlk + " Devamsızlık Bilginiz");
        }
    }     
    class Ogrentmen : Okul
    {
        int maas = 5500;
        string brans;
        public void ogrentmenBilgi()
    
        {
            Console.Write("Ad - Soyad : ");
            adSoyad = Console.ReadLine();
            Console.WriteLine("");
            Console.Write("TC No Giriniz : ");
            tc = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Brans Giriniz :");
            brans = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine(tc + " | " + adSoyad +" "+ brans + " | Olarak Giriş Yapılıyor.");
        }
        public void maasHesapla()
        {

            Console.Write("Kac Ders Saati Giris Yaptınıgınızı Giriniz : ");
            byte dersSaati = Convert.ToByte(Console.ReadLine());
            maas = dersSaati * 50;
            Console.WriteLine("");
            if (brans == "Beden")
            {
                maas += dersSaati * 2 * 17;
            }
            if (brans == "İngilizce")
            {
                maas += dersSaati * 20 * 20;
            }
            if (brans == "Cografya")
            {
                maas += dersSaati * 2 * 14;
            }
            if (brans == "Din")
            {
                maas += dersSaati * 2 * 10;
            }
            if (brans == "Tarih")
            {
                maas += dersSaati * 2 * 15;
            }
            if (brans == "Biyoloji")
            {
                maas += dersSaati * 2 * 5;
            }
            if (brans == "Kimya")
            {
                maas += dersSaati * 2 * 10;
            }
            if (brans == "Matematik")
            {
                maas += dersSaati * 5 * 10;
            }
            if (brans == "Edebiyat")
            {
                maas += dersSaati * 11 * 4;
            }
            if (brans == "Felsefe")
            {
                maas += dersSaati * 2 * 10;
            }
            if(brans == "Bilisim")
            {
                maas += dersSaati * 20 * 20;
            }
            if (brans == "Bilisim" && adSoyad == "Yunus Emre UZUN")
            {
                maas += dersSaati * 40 * 40;
               
            }
           
            Console.WriteLine("");
            Console.WriteLine("Aldıgınız Maas : " + maas);
        }
        public void izin()
        {
            Console.WriteLine("Kac Gün İzin Yaptıgınızı Yazınız : ");
            short izin = Convert.ToByte(Console.ReadLine());
            izin *= 300;
            Console.WriteLine("");
            Console.WriteLine(adSoyad + " Kesintili Maasınız : " + (maas - izin));
            System.Threading.Thread.Sleep(500);
            if (maas < 5500)
            {
                maas = 5500;
                Console.WriteLine("");
                Console.WriteLine("1 Aylık Maasınızı Alıyorsunuz : "+ maas);
            }
            if (adSoyad == "Yunus Emre UZUN ")
            {
                maas *=izin * 20;
            }
            System.Threading.Thread.Sleep(1000);

            Console.ReadKey();
        }

    }
    internal class Program 
    {

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Ogrenci o1 = new Ogrenci();
            Ogrentmen o2 = new Ogrentmen();
            Console.WriteLine("Ogretmen Menüsü İçin (1) , Öğrenci Menüsü İçin (2) ");
            Console.WriteLine("");
            int secim = Convert.ToInt32(Console.ReadLine());
            if(secim == 1)
            {
                while(true)
                {
                    Console.Clear();
                    Console.WriteLine("        - Ogretmen Giris  -");
                    Console.WriteLine("");
                    Console.WriteLine("Ogretmen Giris   (1)");
                    Console.WriteLine("");
                    Console.WriteLine("Maas Raporu      (2) ");
                    Console.WriteLine("");
                    Console.WriteLine("Girdigi Sınıflar (3)");
                    Console.WriteLine("");
                    Console.WriteLine("İzin Goruntule   (4)");
                    Console.WriteLine("");
                    Console.Write(" Secim Yapınız : ");
                    byte menu = Convert.ToByte(Console.ReadLine());
                    if(menu == 1)
                    {
                        Console.Clear();
                        o2.ogrentmenBilgi();
                        Console.ReadKey();
                    }
                    if(menu == 2)
                    {
                        Console.Clear();
                        o2.maasHesapla();
                        Console.ReadKey();
                    }
                    if(menu == 3  )
                    {
                        Console.Clear();
                        Console.WriteLine(" 10 - D");
                        Console.WriteLine(" 11 - D");
                        Console.ReadKey();

                    }
                    if(menu == 4)
                    {
                        Console.Clear();
                        o2.izin();
                        Console.ReadKey();
                    }
                }
            }
            if(secim == 2)
            {
                while (true)
                {
                    Console.Clear(); 
                    Console.WriteLine("          OKUL - VBS     ");
                    Console.WriteLine("");
                    Console.WriteLine(" Öğrenci Bilgi (1)");
                    Console.WriteLine("");
                    Console.WriteLine(" Ders Programı (2)");
                    Console.WriteLine("");
                    Console.WriteLine(" Devamsizlik Girisi (3)");
                    Console.WriteLine("");
                    Console.WriteLine(" Ortalama (4)");
                    Console.WriteLine("");
                    Console.WriteLine(" Belge Durumu (5)");
                    Console.WriteLine("");
                    Console.Write(" Giriş Yapıcağınız Menüyü Seçiniz : ");
                    byte secim2 = Convert.ToByte(Console.ReadLine());
                    if (secim == 1)
                    {
                        o1.ogrenciBilgi();
                        Console.ReadKey();
                    }
                    if (secim == 2)
                    {
                        o1.dersProgramı();
                        Console.ReadKey();
                    }
                    if (secim == 3)
                    {
                        o1.devamsizlik();
                        Console.ReadKey();
                    }
                    if (secim == 4)
                    {
                        o1.ortalama();
                        Console.ReadKey();
                    }
                    if (secim == 5)
                    {
                        o1.belge();
                    }
                    if (secim > 5)
                    {
                        Console.WriteLine(" Yanlış Karakter / Sayı Girişi.");
                    }
                }
            }
            
        }
    }
}
