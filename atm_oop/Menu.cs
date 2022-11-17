using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atm_oop
{
    internal class Menu
    {
        User user = new User();
        public void kullaniciKontrol()
        {
            Console.Write("Kart Numarası Giriniz: ");
            string kKartNo = Console.ReadLine().Replace(" ", "");

            Console.Write("Şifre Giriniz: ");
            string kSifre = Console.ReadLine();
            if (kKartNo.Equals(user.KartNo) && kSifre.Equals(user.Sifre))
            {
                Console.WriteLine("*****FALAN FİLAN BANKA HOŞGELDİNİZ*****");
                menu();
            }
        }

        public void menu()
        {
            Console.Write("YAPMAK İSTEDİĞİNİZ İŞLEMİ SEÇİNİZ\n" +
                "1. BAKİYE SORGULAMA\n" +
                "2. PARA YATIRMA\n" +
                "3. PARA ÇEKME\n" +
                "4. PARA GÖNDERME\n" +
                "5. ŞİFRE DEĞİŞTİRME\n" +
                "6. ÇIKIŞ\n" +
                "SEÇİMİNİZ:");
            char secim = Convert.ToChar(Console.ReadLine());
            switch (secim)
            {
                case '1':
                    {
                        BakiyeSorgula bakiyeSorgula = new BakiyeSorgula();
                        bakiyeSorgula.bakiyeSorgulama();
                        break;
                    }
                case '2':
                    {
                        ParaYatirma paraYatirma = new ParaYatirma();
                        Console.Write("YATIRMAK İSTEDİĞİNİZ MİKTARI GİRİNİZ: ");
                        double miktar = Convert.ToDouble(Console.ReadLine());
                        paraYatirma.paraYatirmaCekme(miktar);
                        break;
                    }
                case '3':
                    {
                        break;
                    }
                case '4': { break; }
                case '5': { break; }
                case '6': { break; }
            }
        }
    }
}
