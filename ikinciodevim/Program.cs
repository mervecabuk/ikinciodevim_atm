using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ikinciodevim
{ }


class Program
{
    static void Main(string[] args)
    {
        int elimizdekipara = 250;
        string sifre = "ab18";
        int yanlisGirisSayisi = 0;

        Console.WriteLine("Kartlı işlem mi yapmak istiyorsunuz yoksa kartsız işlem mi?");
        Console.WriteLine("Kartlı işlem için 1'e, kartsız işlem için 2'ye basınız:");
        int islemSecim = Convert.ToInt32(Console.ReadLine());

        switch (islemSecim)
        {
            case 1:
                Console.WriteLine("Kartlı İşlem Menüsü");

                while (true)
                {
                    Console.WriteLine("Şifre giriniz:");
                    string girilenSifre = Console.ReadLine();

                    if (girilenSifre == sifre)
                    {
                        Console.WriteLine("==> Şifreniz doğru. Ana Menü");

                        Console.WriteLine("Ana Menü");
                        Console.WriteLine("1. Para Çekmek");
                        Console.WriteLine("2. Para Yatırmak");
                        Console.WriteLine("3. Para Transferleri");
                        Console.WriteLine("4. Eğitim Ödemeleri");
                        Console.WriteLine("5. Ödemeler");
                        Console.WriteLine("6. Bilgi Güncelleme");
                        Console.WriteLine("0. Çıkmak");

                        int secim = Convert.ToInt32(Console.ReadLine());

                        if (secim == 1)
                        {
                            Console.WriteLine("Çekmek istediğiniz miktarı giriniz:");
                            int cekilecekMiktar = Convert.ToInt32(Console.ReadLine());

                            if (cekilecekMiktar > elimizdekipara)
                            {
                                Console.WriteLine("Maalesef çekmek istediğiniz miktar, bankanızdaki paradan daha fazla.");
                            
                            }
                            else
                            {
                                elimizdekipara -= cekilecekMiktar;
                                Console.WriteLine("İstenilen miktar para çekiliyor. Kalan para miktarı: " + elimizdekipara);
                            }
                        }
                        else if (secim == 2)
                        {
                            Console.WriteLine("Kredi kartına 1");
                            Console.WriteLine("Kendi hesabınıza yatırmak için 2");

                            int paraYatirmaSecim = Convert.ToInt32(Console.ReadLine());

                            if (paraYatirmaSecim == 1)
                            {
                                Console.WriteLine("Kredi kartı numaranızı giriniz (12 haneli):");
                                string krediKartiNumarasi = Console.ReadLine();

                                Console.WriteLine("Para miktarını giriniz:");
                                int paraMiktari = Convert.ToInt32(Console.ReadLine());

                                // Kredi kartına para yatırma işlemi gerçekleştirildiğini varsayalım

                                Console.WriteLine("İstenilen miktar kredi kartına yatırıldı.");
                            }
                            else if (paraYatirmaSecim == 2)
                            {
                                Console.WriteLine("Hesabınıza yatırmak istediğiniz miktarı giriniz:");
                                int hesabaYatirilacakMiktar = Convert.ToInt32(Console.ReadLine());

                                // Hesaba para yatırma işlemi

                                Console.WriteLine("İstenilen miktar hesabınıza yatırıldı.");
                            }
                        }
                        else if (secim == 3)
                        {
                            Console.WriteLine("Başka hesaba EFT yapmak için 1'e, başka hesaba havale yapmak için 2'ye basınız:");
                            int transferSecim = Convert.ToInt32(Console.ReadLine());

                            if (transferSecim == 1)
                            {
                                Console.WriteLine("EFT numaranızı giriniz (TR ile başlayan ve sonunda rakamlar içeren 14 haneli bir numara):");
                                string eftNumarasi = Console.ReadLine();

                                Console.WriteLine("Kaç para yatırmak istiyorsunuz?");
                                int eftMiktari = Convert.ToInt32(Console.ReadLine());

                                // EFT işlemi gerçekleştirildiği varsayalım

                                Console.WriteLine("İstenilen miktar EFT işlemiyle hesaba yatırıldı.");
                            }
                            else if (transferSecim == 2)
                            {
                                Console.WriteLine("Havale yapmak istediğiniz hesap numarasını giriniz (11 haneli):");
                                string havaleHesapNumarasi = Console.ReadLine();

                                Console.WriteLine("Kaç para göndermek istiyorsunuz?");
                                int havaleMiktari = Convert.ToInt32(Console.ReadLine());

                                // Havale işlemi gerçekleştirildiği varsayalım

                                Console.WriteLine("İstenilen miktar havale işlemiyle gönderildi.");
                            }
                        }
                        else if (secim == 4)
                        {
                            Console.WriteLine("Eğitim Ödemeleri Menüsü");
                            // Eğitim ödemeleriyle ilgili işlemler
                        }
                        else if (secim == 5)
                        {
                            Console.WriteLine("Ödemeler Menüsü");
                            Console.WriteLine("1. Elektrik Faturası");
                            Console.WriteLine("2. Su Faturası");
                            Console.WriteLine("3. Doğalgaz Faturası");
                            Console.WriteLine("4. İnternet Faturası");
                            Console.WriteLine("5. Telefon Faturası");

                            int faturaSecim = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Lütfen fatura tutarını giriniz:");
                            int faturaTutari = Convert.ToInt32(Console.ReadLine());

                            if (faturaTutari <= elimizdekipara)
                            {
                                elimizdekipara -= faturaTutari;
                                Console.WriteLine("Ödeme işleminiz gerçekleştirildi. Kalan para miktarı: " + elimizdekipara);

                            }
                            else
                            {
                                Console.WriteLine("Maalesef, hesabınızdaki para miktarı bu fatura ödemesini yapmak için yeterli değil.");
                            }
                        }
                        else if (secim == 6)
                        {
                            Console.WriteLine("Şifrenizi değiştirmek için 1'e basınız:");
                            int sifreDegistirmeSecim = Convert.ToInt32(Console.ReadLine());

                            if (sifreDegistirmeSecim == 1)
                            {
                                Console.WriteLine("Yeni şifrenizi giriniz:");
                                sifre = Console.ReadLine();
                                Console.WriteLine("Şifreniz güncellendi.");

                                Console.WriteLine("Ana menüye dönmek için 9'a, çıkış yapmak için 0'a basınız.");
                                int anaMenuSecim = Convert.ToInt32(Console.ReadLine());

                                if (anaMenuSecim == 9)
                                {
                                    Console.WriteLine("Ana menüye dönülüyor...");
                                }
                                else if (anaMenuSecim == 0)
                                {
                                    Console.WriteLine("Çıkış yapılıyor...");
                                    Environment.Exit(0);
                                }
                                else
                                {
                                    Console.WriteLine("Geçersiz bir seçim yapıldı. Çıkış yapılıyor...");
                                    Environment.Exit(0);
                                }
                            }
                            else
                            {
                                Console.WriteLine("Geçersiz bir seçim yapıldı. Çıkış yapılıyor...");
                                Environment.Exit(0);
                            }
                        }
                        else if (secim == 0)
                        {
                            Console.WriteLine("Çıkış yapılıyor...");
                            Environment.Exit(0);
                        }
                        else
                        {
                            Console.WriteLine("Geçersiz bir seçim yapıldı. Çıkış yapılıyor...");
                            Environment.Exit(0);
                        }
                    }
                    else
                    {
                        yanlisGirisSayisi++;
                        Console.WriteLine("==> Şifre yanlış. Kalan hakkınız: " + (3 - yanlisGirisSayisi));

                        if (yanlisGirisSayisi == 3)
                        {
                            Console.WriteLine("Hesabınız bloke oldu. Çıkış yapılıyor...");
                            Environment.Exit(0);
                        }
                    }
                }

            case 2:
                {
                    int secim;
                    bool anaMenu = true;

                    while (anaMenu)
                    {
                        Console.WriteLine("Kartsız İşlemler");
                        Console.WriteLine("1. CepBank Para Çekmek");
                        Console.WriteLine("2. Para Yatırmak");
                        Console.WriteLine("3. Kredi Kartı Ödeme");
                        Console.WriteLine("4. Eğitim Ödemeleri");
                        Console.WriteLine("5. Ödemeler");
                        Console.WriteLine("9. Ana Menüye Dön");
                        Console.WriteLine("0. Çıkış");

                        Console.Write("Seçiminizi yapınız: ");
                        secim = Convert.ToInt32(Console.ReadLine());

                        if (secim == 1)
                        {
                            Console.WriteLine("TC Kimlik Numaranızı giriniz: ");
                            string tcKimlikNo = Console.ReadLine();

                            Console.WriteLine("Cep telefonu numaranızı giriniz: ");
                            string cepTelefonu = Console.ReadLine();

                            if (tcKimlikNo.Length == 11 && cepTelefonu.Length == 11)
                            {
                                Console.WriteLine("1000 TL ödeme yapıldı.");
                                elimizdekipara += 1000;
                            }
                            else
                            {
                                int kalanHak = 2;

                                while (kalanHak > 0)
                                {
                                    Console.WriteLine("Yanlış bilgiler girdiniz! Kalan hakkınız: " + kalanHak);

                                    Console.WriteLine("TC Kimlik Numaranızı giriniz: ");
                                    tcKimlikNo = Console.ReadLine();

                                    Console.WriteLine("Cep telefonu numaranızı giriniz: ");
                                    cepTelefonu = Console.ReadLine();

                                    if (tcKimlikNo.Length == 11 && cepTelefonu.Length == 11)
                                    {
                                        Console.WriteLine("1000 TL ödeme yapıldı.");
                                        elimizdekipara += 1000;
                                        break;
                                    }

                                    kalanHak--;
                                }

                                if (kalanHak == 0)
                                {
                                    Console.WriteLine("Hesap 1 saat kilitlenmiştir.");
                                }
                            }
                        }
                        else if (secim == 2)
                        {
                            Console.WriteLine("Nakit ödeme için 1'e, Hesaptan ödeme için 2'ye basınız: ");
                            int odemeSecim = Convert.ToInt32(Console.ReadLine());

                            if (odemeSecim == 1)
                            {
                                Console.WriteLine("Kredi kartı numaranızı giriniz: ");
                                string kartNo = Console.ReadLine();

                                Console.WriteLine("TC Kimlik Numaranızı giriniz: ");
                                string tcKimlikNo = Console.ReadLine();

                                if (kartNo.Length >= 12 && tcKimlikNo.Length == 11)
                                {
                                    Console.WriteLine("Nakit olarak ödeme gerçekleştirildi.");
                                }
                                else
                                {
                                    Console.WriteLine("Geçersiz bilgiler girdiniz!");
                                }
                            }
                            else if (odemeSecim == 2)
                            {
                                Console.WriteLine("Kredi kartı numaranızı giriniz: ");
                                string kartNo = Console.ReadLine();

                                Console.WriteLine("Hesap numaranızı giriniz: ");
                                string hesapNo = Console.ReadLine();

                                if (kartNo.Length >= 12 && hesapNo.Length == 11)
                                {
                                    Console.WriteLine("Hesaptan ödeme gerçekleştirildi.");
                                }
                                else
                                {
                                    Console.WriteLine("Geçersiz bilgiler girdiniz!");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Geçersiz seçim!");
                            }
                        }
                        else if (secim == 3)
                        {
                            Console.WriteLine("Başka Hesaba EFT için 1'e, Başka Hesaba Havale için 2'ye basınız: ");
                            int eftHavaleSecim = Convert.ToInt32(Console.ReadLine());

                            if (eftHavaleSecim == 1)
                            {
                                Console.WriteLine("EFT numaranızı giriniz: ");
                                string eftNo = Console.ReadLine();

                                if (eftNo.StartsWith("tr") && eftNo.Length == 12)
                                {
                                    Console.WriteLine("Yatırılacak para miktarını giriniz: ");
                                    double yatirilacakPara = Convert.ToDouble(Console.ReadLine());

                                    if (yatirilacakPara <= elimizdekipara)
                                    {
                                        Console.WriteLine("İşlem başarılı! EFT gerçekleştirildi.");
                                        elimizdekipara -= yatirilacakPara;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Hesap bakiyeniz yetersiz.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Geçersiz EFT numarası!");
                                }
                            }
                            else if (eftHavaleSecim == 2)
                            {
                                Console.WriteLine("Hesap numarasını giriniz: ");
                                string hesapNo = Console.ReadLine();

                                if (hesapNo.Length == 11)
                                {
                                    Console.WriteLine("Gönderilecek para miktarını giriniz: ");
                                    double gonderilecekPara = Convert.ToDouble(Console.ReadLine());

                                    if (gonderilecekPara <= elimizdekipara)
                                    {
                                        Console.WriteLine("İşlem başarılı! Havale gerçekleştirildi.");
                                        elimizdekipara -= gonderilecekPara;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Hesap bakiyeniz yetersiz.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Geçersiz hesap numarası!");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Geçersiz seçim!");
                            }
                        }
                        else if (secim == 4)
                        {
                            Console.WriteLine("Eğitim Ödemeleri sayfası arızalı.");
                        }
                        else if (secim == 5)
                        {
                            Console.WriteLine("Elektrik Faturası - 1");
                            Console.WriteLine("Telefon Faturası - 2");
                            Console.WriteLine("İnternet Faturası - 3");
                            Console.WriteLine("Su Faturası - 4");
                            Console.WriteLine("OGS Ödemeleri - 5");

                            Console.Write("Fatura tipini seçiniz: ");
                            int faturaSecim = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Fatura tutarını giriniz: ");
                            double faturaTutar = Convert.ToDouble(Console.ReadLine());

                            if (faturaTutar <= elimizdekipara)
                            {
                                Console.WriteLine("Fatura ödendi.");
                                elimizdekipara -= faturaTutar;
                            }
                            else
                            {
                                Console.WriteLine("Hesap bakiyesi yetersiz.");
                            }
                        }
                        else if (secim == 9)
                        {
                          
                            continue;
                        }
                        else if (secim == 0)
                        {
                          
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Geçersiz seçim!");
                        }
                    }

                }
        }
    }
}
//bu kodumda 4 tane hata var. ve 9'a basınca ana menüye dönme ifadesini nasıl yapacağım bilmiyorum. goto ile yapmak aklıma gelse de beceremedim