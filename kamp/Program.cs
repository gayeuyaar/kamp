using System;

namespace kamp
{
    class MainClass



    {
    
        static void Main(string[] args)

        {
           

            urun urun1 = new urun();
            urun1.UrunAdi = "Kazak";
            urun1.UrunSaticisi = "Trendyolmilla";
            urun1.UrunFiyati=" 69.99";
            urun1.DegerlendirmePuani = "4/5";

            urun urun2 = new urun();
            urun2.UrunAdi = "ayakkabı";
            urun2.UrunSaticisi = "Nike";
            urun2.UrunFiyati = "289.99";
            urun2.DegerlendirmePuani = "4/5";

            urun urun3 = new urun();
            urun3.UrunAdi = "Klavye";
            urun3.UrunSaticisi = "Rampage";
            urun3.UrunFiyati =" 90";
            urun3.DegerlendirmePuani = "3.5/5";

           urun[] urunler = new urun[] { urun1, urun2, urun3 };

            Console.WriteLine("*********for döngüsü*******");

            for (int i = 0; i < urunler.Length; i++)

            { 
            }
            { 
                int i = 0;
            


                Console.WriteLine(urunler[i].UrunAdi + " " + urunler[i].UrunSaticisi + "tarafından satılıyor" + urunler[i].UrunFiyati +
                    "TL" + "ve" + urunler[i].DegerlendirmePuani + "degerlendirme puanı var.");
            }
            Console.WriteLine("**********while döngüsü*******");
            int a = 0;
            while (a < urunler.Length) ;

            Console.WriteLine(urunler[a].UrunAdi + " ", urunler[a].UrunSaticisi + "tarafından satılıyor " + urunler[a].UrunFiyati
                + "TL" + "ve" + urunler[a].DegerlendirmePuani + "değerlendirme puanı var.");

            a++;
        }
            class urun
        {
            public string UrunAdi { get; set; }
            public string UrunSaticisi { get; set; }
            public string UrunFiyati { get; set; }
            public string DegerlendirmePuani { get; set; }
        }
        }

             

    
    
    }

