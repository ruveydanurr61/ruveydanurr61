using System;

namespace PideLahmacun
{
    class Program
    {
        static void Main(string[] args)
        {
            /****************************************************************************
             *                  SAKARYA ÜNİVERSİTESİ
             *         BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
             *          BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ
             *             NESNEYE DAYALI PROGRAMLAMA DERSİ
             *                 2019-2020 BAHAR DÖNEMİ
             *        
             *               ÖDEV NUMARASI.......:1
             *               ÖĞRENCİ ADI-SOYADI.........:RÜVEYDA NUR HATİCE CİNER
             *               ÖĞRENCİ NUMARASI....:B191200032
             *               DERSİN ALINDIĞI GRUP:A
             * 
             * 
             * ***************************************************************************/

            //Consol ekranının rengini değişterecektir.
            Console.BackgroundColor = ConsoleColor.White;

            ////Yazı rengi değişecektir.
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.WriteLine("********** CİNER LAHMACUN PİDE SALONUNA HOŞGELDİNİZ." +
                "AŞAĞIDAKİ ADIMLARI TAKİP EDEBİLİRİSİNİZ. **********");
            Console.WriteLine("...................................................................................................");
            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Sanal sipariş sistemimize hoşgeldiniz. Öncelikle lütfen adınızı yazınız:  ");
            string müşteriAdı = Console.ReadLine();

            Console.WriteLine("Merhaba {0} ! Öncelikle salonumuzla ilgili genel bilgiler verelim.", müşteriAdı);
            Console.Write("\n");

            int lahmacunAdedi, pideAdedi;
            int hazırlanmaSüresi;
            int adetSayısı;

            // MENÜ OLUŞTURULACAKTIR.

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(">>>>> GENEL BİLGİLER <<<<<");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("~");

            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Lahmacun ve Pide boyutlarımız standarttır." +
                " Pide boyutumuz 50 cm , lahmacun ise orta boydur.");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("~");

            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("İçecek seçeneklerimiz şuanlık çay ve ayran olarak iki seçenektir." +
                " Size daha iyi hizmet verebilmek için çalışıyoruz :)  ");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n......FİYAT LİSTEMİZ......");

            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("LAHMACUN ADET....: 5 TL");
            Console.WriteLine("PİDE ADET......: 4 TL");
            Console.WriteLine("ÇAY......: 2 TL");
            Console.WriteLine("AYRAN......: 3 TL");

            Console.WriteLine("\n");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(">");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(" Lahmacun sipariş etmek için lütfen 1'e basınız.");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(">");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(" Pide sipariş etmek için lütfen 2'ye basınız.");

            int seçenek1 = Convert.ToInt32(Console.ReadLine());
            /* seçenek1 pide mi lahmacun mu olduğunu atamak için kullanlılan değişkendir.Eğer müşteri 1'e tıklarsa
            kodumuz alt bloğa girecek ve içecek sayısına göre oradan dallanacaktır.*/
             
            if (seçenek1 == 1)
            {
                int içecekAdedi;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(">");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine(" Kaç adet lahmacun istersiniz? ");
                lahmacunAdedi = Convert.ToInt32(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(">");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("İçecek olarak çay mı ayran mı istersiniz? Bir şey istemiyorsanız yok yazınız.");
                string icecek = Console.ReadLine();

                 /* Seçilen içeceği icecek adlı bi stringe atadık.İstediği içeceğin eşitini sağlayan kod bloğundan kodumuz devam edecek.*/

                if (icecek == "çay" || icecek == "ÇAY" || icecek == "Çay")
                {
                       Console.ForegroundColor = ConsoleColor.Red;
                       Console.Write(">");
                       Console.ForegroundColor = ConsoleColor.Black;
                       Console.WriteLine("Kaç adet {0} istiyorsunuz.", icecek);
                       içecekAdedi= Convert.ToInt32(Console.ReadLine());
                       Console.Clear();

                        //Müşteriye bilgi vermek için toplam fiyat hesaplanıyor.
                       Console.ForegroundColor = ConsoleColor.DarkBlue;
                       int toplamFiyat = lahmacunAdedi * 5 + içecekAdedi * 2;
                       Console.WriteLine(">>>> Toplam tutarınız:{0} <<<<", toplamFiyat);

                        //Müşteriye hazırlnma süresi hakkında bilgi verebilmek için aşağıdaki işlemi kullanıyoruz.
                       Console.ForegroundColor = ConsoleColor.Green;
                       hazırlanmaSüresi = lahmacunAdedi * 4;
                    
                       Console.WriteLine("\n{0} adet lahmacun, ", lahmacunAdedi);
                       Console.Write("{0} adet ", içecekAdedi);
                       Console.WriteLine("{0} sipariş ettiniz.", icecek);
                       Console.WriteLine("Siparişinizin hazırlanma süresi {0} dakikadır.", hazırlanmaSüresi);
                       Console.WriteLine("Bizi tercih ettiğiniz teşekkürler.\n");

                }
                if (icecek == "ayran" || icecek == "Ayran" || icecek == "AYRAN")
                {   
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(">");
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Kaç adet {0} istiyorsunuz.", icecek);
                        içecekAdedi = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();

                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        int toplamFiyat = lahmacunAdedi * 5 + içecekAdedi * 3;
                        Console.WriteLine(">>>> Toplam tutarınız:{0} <<<<", toplamFiyat);

                        Console.ForegroundColor = ConsoleColor.Green;
                        hazırlanmaSüresi = lahmacunAdedi * 4;

                        Console.WriteLine("\n{0} adet lahmacun, ", lahmacunAdedi);
                        Console.Write("{0} adet ", içecekAdedi);
                        Console.WriteLine("{0} sipariş ettiniz.", icecek);
                        Console.WriteLine("Siparişinizin hazırlanma süresi {0} dakikadır.", hazırlanmaSüresi);
                        Console.WriteLine("Bizi tercih ettiğiniz teşekkürler.\n");

                }

                if (icecek == "yok" || icecek == "YOK" || icecek == "Yok")
                {  
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        int toplamFiyat = lahmacunAdedi * 5;
                        Console.WriteLine(">>>> Toplam tutarınız:{0} <<<<", toplamFiyat);

                        Console.ForegroundColor = ConsoleColor.Green;
                        hazırlanmaSüresi = lahmacunAdedi * 4 ;

                        Console.WriteLine("\n{0} adet lahmacun, ", lahmacunAdedi);
                        Console.WriteLine("Siparişinizin hazırlanma süresi {0} dakikadır.", hazırlanmaSüresi);
                        Console.WriteLine("Bizi tercih ettiğiniz teşekkürler.\n");

                }

            }

            if (seçenek1 == 2)
                
            {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(">");
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine(" Kaç adet pide istersiniz? ");
                    pideAdedi = Convert.ToInt32(Console.ReadLine());

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(">");
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("İçecek olarak çay mı ayran mı istersiniz? Bir şey istemiyorsanız yok yazınız.");
                    string icecek2 = Console.ReadLine();


                if (icecek2 == "Çay" || icecek2 == "ÇAY" || icecek2 == "çay")
                {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(">");
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Kaç adet {0} istiyorsunuz.", icecek2);
                        adetSayısı = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();

                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        int toplamFiyat = pideAdedi * 4 + adetSayısı * 2;
                        Console.WriteLine(">>>> Toplam tutarınız:{0} <<<<", toplamFiyat);

                        Console.ForegroundColor = ConsoleColor.Green;
                        hazırlanmaSüresi = pideAdedi * 3;

                        Console.WriteLine("\n{0} adet pide, ", pideAdedi);
                        Console.Write("{0} adet ", adetSayısı);
                        Console.WriteLine("{0} sipariş ettiniz.", icecek2);
                        Console.WriteLine("Siparişinizin hazırlanma süresi {0} dakikadır.", hazırlanmaSüresi);
                        Console.WriteLine("Bizi tercih ettiğiniz teşekkürler.\n");

                }
                if (icecek2 == "ayran" || icecek2 == "AYRAN" || icecek2 == "Ayran")
                {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(">");
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Kaç adet {0} istiyorsunuz.", icecek2);
                        adetSayısı = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();

                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        int toplamFiyat = pideAdedi * 4 + adetSayısı * 3;
                        Console.WriteLine(">>>> Toplam tutarınız:{0} <<<<", toplamFiyat);

                        Console.ForegroundColor = ConsoleColor.Green;
                        hazırlanmaSüresi = pideAdedi * 3;

                        Console.WriteLine("\n{0} adet pide, ", pideAdedi);
                        Console.Write("{0} adet ", adetSayısı);
                        Console.WriteLine("{0} sipariş ettiniz.", icecek2);
                        Console.WriteLine("Siparişinizin hazırlanma süresi {0} dakikadır.", hazırlanmaSüresi);
                        Console.WriteLine("Bizi tercih ettiğiniz teşekkürler.");

                }
                if (icecek2 == "YOK" || icecek2 == "yok" || icecek2 == "Yok")
                {
                        Console.Clear();

                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        int toplamFiyat = pideAdedi * 4;
                        Console.WriteLine(">>>> Toplam tutarınız:{0} <<<<", toplamFiyat);

                        Console.ForegroundColor = ConsoleColor.Green;
                        hazırlanmaSüresi = pideAdedi * 3;

                        Console.WriteLine("\n{0} adet pide sipariş ettiniz. ", pideAdedi);
                        Console.WriteLine("Siparişinizin hazırlanma süresi {0} dakikadır.", hazırlanmaSüresi);
                        Console.WriteLine("Bizi tercih ettiğiniz teşekkürler.");

                }
                
            }

            //İletişim bilgileri maddeler halinde yazılacak.

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nİletişim bilgilerimiz: ");
            Console.Write("Telefon: ");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("0212 123 45 67 ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Adres: ");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Yunus Emre mahallesi Atalay caddesi No:34. İSTANBUL/ESENYURT ");

            Console.ReadKey();
        }
    }
}
