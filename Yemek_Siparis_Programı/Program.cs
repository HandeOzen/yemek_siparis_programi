/****************************************************************************
**               SAKARYA ÜNİVERSİTESİ                                      **
**               BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ                 **
**               BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ                    **
**               NESNEYE DAYALI PROGRAMLAMA DERSİ                          **
**               2019-2020 BAHAR DÖNEMİ                                    **
**                                                                         **
**               ÖDEV NUMARASI..........: 1                                **
**               ÖĞRENCİ ADI............:HANDE ÖZEN                        **
**               ÖĞRENCİ NUMARASI.......:B181200048                        **
**               DERSİN ALINDIĞI GRUP...: YOK                              **
*****************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yemek_Siparis_Programı
{
    class Program
    {
        static void Main(string[] args)
        {
            double secim, adet, toplam = 0;
            double hesap = 0;
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("");
            Console.WriteLine("**               ETLER               **               ICECEKLER               **");
            Console.WriteLine("**                                   **                                       **");
            Console.WriteLine("**    1- Dallas Steak   - 129,99TL   **     7- Ayran        - 16,40TL         **");
            Console.WriteLine("**    2- Dana Kaburga   - 157,50TL   **     8- Şalgam       - 19,50TL         **");
            Console.WriteLine("**    3- Lokum          - 139,95TL   **     9- Pepsi        - 17,85TL         **");
            Console.WriteLine("**    4- Kuzu Kafes     - 260,00TL   **    10- Sprite       - 15.25TL         **");
            Console.WriteLine("**    5- Tomahawk       - 223,35TL   **    11- Türk Kahvesi - 25,99TL         **");
            Console.WriteLine("**    6- Dana Carpaccio -130,45TL    **    12- Çay          -  7,00TL         **");
            Console.WriteLine("**                                   **                                       **");
            Console.WriteLine("********************************************************************************");

            for (int i = 1; i < 100; i++)
            {
                Console.WriteLine("");
                Console.Write(" Alacagınız urunun numarasini giriniz : ");
                secim = Convert.ToDouble(Console.ReadLine());

                if( secim == 1)
                {
                    Console.Write("Kaç porsiyon Dallas Steak istersiniz ? :");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 129.99;
                    hesap = hesap + toplam;
                }
                else if (secim==2)
                {
                    Console.Write("Kaç porsiyon Dana Kaburga istersiniz ? :");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 157.50;
                    hesap = hesap + toplam;

                }
                else if (secim == 3)
                {
                    Console.Write("Kaç porsiyon Lokum istersiniz ? :");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 139.95;
                    hesap = hesap + toplam;

                }
                else if (secim == 4)
                {
                    Console.Write("Kaç porsiyon Kuzu Kafes istersiniz ? :");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 260;
                    hesap = hesap + toplam;

                }
                else if (secim == 5)
                {
                    Console.Write("Kaç porsiyon Tomahawk istersiniz ? :");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 223.35;
                    hesap = hesap + toplam;

                }
                else if (secim == 6)
                {
                    Console.Write("Kaç porsiyon Dana Carpaccio istersiniz ? :");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 130.45;
                    hesap = hesap + toplam;

                }
                else if (secim == 7)
                {
                    Console.Write("Kaç adet Ayran istersiniz ? :");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 16.40;
                    hesap = hesap + toplam;

                }
                else if (secim == 8)
                {
                    Console.Write("Kaç adet Şalgam istersiniz ? :");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 19.50;
                    hesap = hesap + toplam;

                }
                else if (secim == 9)
                {
                    Console.Write("Kaç adet Pepsi istersiniz ? :");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 17.85;
                    hesap = hesap + toplam;

                }
                else if (secim == 10)
                {
                    Console.Write("Kaç adet Sprite istersiniz ? :");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 15.25;
                    hesap = hesap + toplam;

                }
                else if (secim == 11)
                {
                    Console.Write("Kaç adet Türk Kahvesi istersiniz ? :");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 25.99;
                    hesap = hesap + toplam;

                }
                else if (secim == 12)
                {
                    Console.Write("Kaç adet Çay istersiniz ? :");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 7;
                    hesap = hesap + toplam;

                }
                else
                    Console.WriteLine("Böyle bir ürün bulunmamaktadır.");
                Console.WriteLine();
                Console.WriteLine("Başka bir isteğiniz var mı?:");
                string cevap = Console.ReadLine();
                if (cevap == "h" || cevap == "H" || cevap == "Hayır" || cevap == "HAYIR" || cevap == "hayır")
                 break;
                          
            }
            Console.WriteLine("Toplam Tutarınız:"+hesap);
            Console.Read();

        }
    }
}
