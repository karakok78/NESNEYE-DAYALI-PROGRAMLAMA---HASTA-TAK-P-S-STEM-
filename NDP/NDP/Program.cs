/****************************************************************************
 * *                         SAKARYA ÜNİVERSİTESİ
 * *                BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
 * *                  BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ
 * *                     NESNEYE DAYALI PROGRAMLAMA DERSİ
 * *                        2019-2020 BAHAR DÖNEMİ
 * *
 * *                      ÖDEV NUMARASI........: 1
 * *                      ÖĞRENCİ ADI..........: TUNAHAN KARAKÖK
 * *                      ÖĞRENCİ NUMARASI.....: B17120043
 * *                      DERSİN ALINDIĞI GRUP.: A 
 ****************************************************************************/

using System;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace NDP
{
    class Program
    {
        static void Main(string[] args)
        {
            
                
                int secim; // YAPILACAK İŞLEMİN SEÇİMİ İÇİN DEĞİŞKEN TANIMLANDI
                int id;  // hasta id'sinin olduğu indexlere atama yapılması için geçici değişken tanımı
                int[] ID = new int[1];              
                string [] TC = new string[1];
                string[] AD = new string[1];
                string[] SOYAD = new string[1];                 //hasta bilgilerinin tutulacağı diziler oluşturuldu
                int[] YAS = new int[1];
                string[] SİKAYET = new string[1];

                enbas: // programın başa dönülmesi için goto komutu eklendi
                
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("HASTA TAKİP SİSTEMİNE HOŞGELDİNİZ !");
                Console.WriteLine(" --------------------------------- ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Yapmak istediğiniz işlemi seçiniz");     //yapılması istenilen işlem seçim ekranı
                Console.WriteLine("1-Yeni Hasta Ekleme");
                Console.WriteLine("2-Hasta Listesi Gör");
                
                secim = Convert.ToInt32(Console.ReadLine());
                
                if (secim == 1)
                {
                Console.Clear();
                    Array.Resize(ref ID, ID.Length + 1);
                    Array.Resize(ref TC, TC.Length + 1);
                    Array.Resize(ref AD, AD.Length + 1);         //dizide gereksiz boyutların azaltılması için her ekleme öncesi dizi boyutları 1 artırıldı
                    Array.Resize(ref SOYAD, SOYAD.Length + 1);
                    Array.Resize(ref YAS, YAS.Length + 1);
                    Array.Resize(ref SİKAYET, SİKAYET.Length + 1);

                    Console.Write("Hastanın ID'si :");
                    id = Convert.ToInt32(Console.ReadLine());
                    ID[id] = id;
                    Console.Write("Hastanın TC'si :");
                    TC[id] = Console.ReadLine();
                    Console.Write("Hastanın Adı :");                      //HASTALARA AİT BİLGİLERİN DİZİLERE ATILDIĞI KOD BLOĞU
                    AD[id] = Console.ReadLine();
                    Console.Write("Hastanın Soyadı :");
                    SOYAD[id] = Console.ReadLine();
                    Console.Write("Hastanın Yaşı :");
                    YAS[id] = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Hastanın Şikayeti :");
                    SİKAYET[id] = Console.ReadLine();
                    Console.WriteLine("                ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(" ---------------------- ");
                    Console.WriteLine("HASTA BAŞARIYLA EKLENDİ");
                    Console.WriteLine(" ---------------------- ");
                    Console.WriteLine("                ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("ANA MENÜYE DÖNMEK İÇİN 1 ÇIKMAK İÇİN 2 YE BASIN");       //KULLANICININ DEVAM VEYA TAMAM SEÇİMİNİN SORULDUĞU İŞLEM
                    int karar = Convert.ToInt32(Console.ReadLine());
                    if (karar==1)
                    {
                        Console.Clear();   //Kullanıcı programı kullanmaya devam etme seçimi yaparsa ekran temizlenerek ana menüye dönülüyor
                        goto enbas;
                }
                else
                {
                    Environment.Exit(0);   //çıkış işlemi isteğe bağlı
                }
                        
                    
            }
                else if (secim == 2)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(" ID ");
                    Console.Write("        ");
                    Console.Write(" TC ");
                    Console.Write("        ");         //hasta bilgilerinin gösterileceği ekran ve başlık yerleşimi yapılıyor
                    Console.Write(" AD ");
                    Console.Write("        ");
                    Console.Write(" SOYAD ");
                    Console.Write("        ");
                    Console.Write(" YAŞ ");
                    Console.Write("        ");
                    Console.WriteLine(" ŞİKAYET ");
                    Console.ForegroundColor = ConsoleColor.White;
                    for (int i = 1; i < ID.Length; i++)
                    {
                    Console.Write(ID[i]); Console.Write("        "); Console.Write(TC[i]); Console.Write("     "); Console.Write(AD[i]); Console.Write("     "); Console.Write(SOYAD[i]); Console.Write("           "); Console.Write(YAS[i]); Console.Write("        "); Console.WriteLine(SİKAYET[i]);
                    }
                    Console.WriteLine("                                 ");      // DİZİLERDE TUTULAN HASTA BİLGİLERİ EKRANA BASTIRILDI
                    Console.WriteLine("ANA MENÜYE DÖNMEK İÇİN 1 ÇIKMAK İÇİN 2 YE BASIN");
                    int karar = Convert.ToInt32(Console.ReadLine());
                    if (karar == 1)
                    {
                        Console.Clear();           //DEVAM İŞLEMİ ANA MENÜYE DÖNÜŞ
                        goto enbas;
                    }
                    else
                    {
                    Environment.Exit(0);           //PROGRAMIN SONLANDIRILMASI İSTEĞE BAĞLI
                    }

                
                    

                }


                Console.ReadKey();
            

    {

            }
        }
    }
}
