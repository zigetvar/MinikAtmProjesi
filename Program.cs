using System;

namespace minikAtmProjesi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ATM ye Hoşgeldiniz");
            Console.WriteLine("Yapmak istediğiniz işlemi seçiniz/1/2/3/q");
            Console.WriteLine("1-Bakiye Sorgulama");
            Console.WriteLine("2-Para Çekme");
            Console.WriteLine("3-Para Yatırma");
            Console.WriteLine("Çıkış Yapmak İçin q'ya Bas");

            string secenek = Console.ReadLine();
            int bakıye = 5000;

            if (secenek=="1")
            {
                Console.WriteLine("Bakiyenizde bulunan miktar:"+ bakıye);
                Console.ReadLine();
            }

            else if (secenek=="2")
            {
                Console.WriteLine("Lütfen Çekeceğiniz Miktarı Giriniz");
                int cekilen_para = Convert.ToInt32(Console.ReadLine());
                
                if (cekilen_para>bakıye)
                {
                    Console.WriteLine("Bakiyeniz Yetersiz");
                    Console.ReadLine();
                }

                else
                {
                    Console.WriteLine("Paranız Hesabınızdan Başarılı Bir Şekilde Çekildi.");
                    Console.WriteLine("Bakiyenizde Kalan Toplam Tutar:" + (bakıye - cekilen_para));
                    Console.ReadLine();
                }
            

            }

            else if (secenek=="3")
            {
                Console.WriteLine("Lütfen Yatırılacak Tutarı Giriniz");
                int yatirilacak_tutar = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Hesabınızdaki Toplam Tutar:"+ (bakıye+yatirilacak_tutar));
                Console.ReadLine();
            }

            else if (secenek=="q")
            {
                Console.WriteLine("ATM'DEN ÇIKIŞ YAPILIYOR");
                Console.WriteLine("İYİ GÜNLER... ");
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("Lütfen Bir Seçenekte Bulununuz...");
                Console.ReadLine();
            }

        }
    }
}
