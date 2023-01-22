using System;

namespace BankApp
{
    class Program
    {
        public static void Main(string[] args)
        {

            int gelen_islem;
            do
            {
                System.Console.WriteLine("Lütfen isteddiğiniz işlemi seçiniz :");
                System.Console.WriteLine("** BANKA UYGULAMAM **");
                System.Console.WriteLine("(1) Kullanici Kayit");
                System.Console.WriteLine("(2) Kullanici Sil");
                System.Console.WriteLine("(3) Hesaba Para Yatir");
                System.Console.WriteLine("(4) Hesaptan Para Çek");
                System.Console.WriteLine("(5) Hesaplar Arasi Para Transferi");
                System.Console.WriteLine("(6) Hesaplari Listele");
                System.Console.WriteLine("(7) Kullanici Hesabi Ara");
                System.Console.WriteLine("(0) Çikis");
                
                gelen_islem  = int.Parse(Console.ReadLine());
                switch (gelen_islem)
                {
                    case 1: MyBankApp.yeniKullanici();break;
                    case 2: MyBankApp.KullaniciSil(); break;
                    case 3: MyBankApp.KullaniciParaYatir();break;
                    case 4: MyBankApp.KullanicParaCek();break;
                    case 5: MyBankApp.HesaplarArasiTransfer();break;
                    case 6: MyBankApp.KullanicilariGorünütüle();break;
                    case 7: MyBankApp.KullaniciAra();break;
                    default: System.Console.WriteLine("Lütfen 0 - 5 arasi sayi giriniz ."); break;
                }

            }while(gelen_islem != 0 );
          

        }   
    }
}