using System;

namespace BankApp
{

    public class MyBankApp
    {
        public static List<Kullanici> my_list = new List<Kullanici>();
        
        public static void yeniKullanici()
        {
            string gelen_isim;
            string gelen_soyisim;
            string gelen_iban;

            System.Console.WriteLine("** Kullanici Kayi Sistemi **");
            
            System.Console.WriteLine("Lütfen isim giriniz :");
            gelen_isim  = Convert.ToString(Console.ReadLine());

            System.Console.WriteLine("Lütfen Soyismi giriniz :");
            gelen_soyisim =  Convert.ToString(Console.ReadLine());

            System.Console.WriteLine("Lütfen Ibani giriniz :");
            gelen_iban = Convert.ToString(Console.ReadLine());

            Kullanici tempKullanici = new Kullanici();

            tempKullanici.Isim1 = gelen_isim;
            tempKullanici.Soyisim1 = gelen_soyisim;
            tempKullanici.Iban1 = gelen_iban;
            tempKullanici.Money1 = 0;
            my_list.Add(tempKullanici);
        }

        public static void KullaniciAra()
        {
            System.Console.WriteLine("Lütfen aranacak kullanicinin ismini soyismini giriniz.");
            string okunanDeger = Convert.ToString(Console.ReadLine());
            string isim1 = Convert.ToString(okunanDeger.Split(' ').First());
            string isim2 = Convert.ToString(okunanDeger.Split(' ')[1]);

            bool isFind = false;
            foreach (var item in my_list)
            {
                if(item.Isim1 == isim1 && item.Soyisim1 == isim2)
                {
                    isFind = true;
                    System.Console.WriteLine( item.Id1 + " " + item.Isim1 + " " + item.Soyisim1 + " " + item.Iban1 +" " + item.Money1);
                    break;
                }
            }

            if(isFind)
                System.Console.WriteLine( isim2 + " Bulundu");
            else
            {
                System.Console.WriteLine("Bulunamadi");
                System.Console.WriteLine("Tekrar Denemek istiyorsaniz 1 istemiyorsaniz 2");
                int islem = int.Parse(Console.ReadLine());
                if(islem == 1)
                    KullaniciAra();
            }

        }
        public static void KullaniciSil()
        {
            System.Console.WriteLine("Lütfen silincek kullanicinin ismini soyismini giriniz.");
            string okunanDeger = Convert.ToString(Console.ReadLine());
            string isim1 = Convert.ToString(okunanDeger.Split(' ').First());
            string isim2 = Convert.ToString(okunanDeger.Split(' ')[1]);

            bool isFind = false;
            foreach (var item in my_list)
            {
                if(item.Isim1 == isim1 && item.Soyisim1 == isim2)
                {
                    isFind = true;
                    my_list.Remove(item);
                    break;
                }
            }

            if(isFind)
                System.Console.WriteLine( isim2 + " silindi.");
            else
            {
                System.Console.WriteLine("Bulunamadi");
                System.Console.WriteLine("Tekrar Denemek istiyorsaniz 1 istemiyorsaniz 2");
                int islem = int.Parse(Console.ReadLine());
                if(islem == 1)
                    KullaniciSil();
            }

        }
        public static void KullaniciParaYatir()
        {
            System.Console.WriteLine("Lütfen para yatirilacak kullanicinin ismini soyismini giriniz.");
            string okunanDeger = Convert.ToString(Console.ReadLine());
            string isim1 = Convert.ToString(okunanDeger.Split(' ').First());
            string isim2 = Convert.ToString(okunanDeger.Split(' ')[1]);

            bool isFind = false;
            foreach (var item in my_list)
            {
                if(item.Isim1 == isim1 && item.Soyisim1 == isim2)
                {
                    isFind = true;
                    System.Console.WriteLine("Lütfen Yatiralack Tutari Giriniz :");
                    double gelenPara = Convert.ToDouble(Console.ReadLine());
                    item.Money1 += gelenPara;
                    break;
                }
            }

            if(isFind)
                System.Console.WriteLine( isim2 + " Bulundu");
            else
            {
                System.Console.WriteLine("Bulunamadi");
                System.Console.WriteLine("Tekrar Denemek istiyorsaniz 1 istemiyorsaniz 2");
                int islem = int.Parse(Console.ReadLine());
                if(islem == 1)
                    KullaniciParaYatir();
            }
        }

        public static void HesaplarArasiTransfer()
        {
            System.Console.WriteLine("Lütfen para cekilecek kullanicinin ismini soyismini giriniz.");
            string okunanDeger = Convert.ToString(Console.ReadLine());
            string isim1 = Convert.ToString(okunanDeger.Split(' ').First());
            string isim2 = Convert.ToString(okunanDeger.Split(' ')[1]);

            System.Console.WriteLine("Lütfen para yatirilack olan hesabin kullanici ismini soyismini giriniz.");
            string okunanDeger2 = Convert.ToString(Console.ReadLine());
            string isim3 = Convert.ToString(okunanDeger2.Split(' ').First());
            string isim4 = Convert.ToString(okunanDeger2.Split(' ')[1]);
           
            double gelenPara = 0;

            bool isFind = false;
            foreach (var item in my_list)
            {
                if(item.Isim1 == isim1 && item.Soyisim1 == isim2)
                {
                    isFind = true;
                    System.Console.WriteLine("Lütfen Çekilecek Tutari Giriniz :");
                    gelenPara = Convert.ToDouble(Console.ReadLine());
                    item.Money1 -= gelenPara;
                    break;
                }
            }
           
            foreach (var item in my_list)
            {
                if(item.Isim1 == isim3 && item.Soyisim1 == isim4)
                {
                    isFind = true;
                    System.Console.WriteLine("buluundu mu " + item.Isim1);
                    item.Money1 += gelenPara;
                    break;
                }
            }

            if(isFind)
                System.Console.WriteLine( isim2 + " Bulundu");
            else
            {
                System.Console.WriteLine("Bulunamadi");
                System.Console.WriteLine("Tekrar Denemek istiyorsaniz 1 istemiyorsaniz 2");
                int islem = int.Parse(Console.ReadLine());
                if(islem == 1)
                    HesaplarArasiTransfer();
            }
        }

        public static void KullanicParaCek()
        {
            System.Console.WriteLine("Lütfen para çekilecek kullanicinin ismini soyismini giriniz.");
            string okunanDeger = Convert.ToString(Console.ReadLine());
            string isim1 = Convert.ToString(okunanDeger.Split(' ').First());
            string isim2 = Convert.ToString(okunanDeger.Split(' ')[1]);

            bool isFind = false;
            foreach (var item in my_list)
            {
                if(item.Isim1 == isim1 && item.Soyisim1 == isim2)
                {
                    isFind = true;
                    System.Console.WriteLine("Lütfen Çekilecek Tutari Giriniz :");
                    double gelenPara = Convert.ToDouble(Console.ReadLine());
                    item.Money1 -= gelenPara;
                    break;
                }
            }

            if(isFind)
                System.Console.WriteLine( isim2 + " Bulundu");
            else
            {
                System.Console.WriteLine("Bulunamadi");
                System.Console.WriteLine("Tekrar Denemek istiyorsaniz 1 istemiyorsaniz 2");
                int islem = int.Parse(Console.ReadLine());
                if(islem == 1)
                    KullaniciParaYatir();
            }
        }

        public static void KullanicilariGorünütüle()
        {
            System.Console.WriteLine("** KAYITLI KULLANICILAR **");
            foreach (var item in my_list)
            {
                System.Console.WriteLine( item.Id1 + " " + item.Isim1 + " " + item.Soyisim1 + " " + item.Iban1 + " " + item.Money1);
            }
        }
        
    }
}