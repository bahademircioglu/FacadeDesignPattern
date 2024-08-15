using System;

namespace Facade.HesapBilgisi
{

    public class Program
    {
        public static void Main(string[] args)
        {
            // Facade objesi

            Kredi kredi = new Kredi();

            // Kredi Onayı Sorgusu

            Musteri musteri = new Musteri("Baha Demircioğlu");
            bool uygun = kredi.UygunMu(musteri, 125000);

            Console.WriteLine("\n" + musteri.Name +
                    "'nun kredi istegi " + (uygun ? "onaylandı!" : "reddedildi!"));

            // Uygulamayı hemen bitirmeme satırı:

            Console.ReadKey();
        }
    }

    /// 1. Altsınıf

    public class HesapBilgisi
    {
        public bool YeterliBirikimVarMi(Musteri c, int miktar)
        {
            Console.WriteLine(c.Name + " icin hesap kontrolu yapılıyor.");
            return true;
        }
    }

    /// 2. Altsınıf

    public class KrediSkoru
    {
        public bool KrediSkoruIyiMi(Musteri c)
        {
            Console.WriteLine(c.Name + "'nun kredi skoru kontrol ediliyor.");
            return true;
        }
    }

    /// 3. Altsınıf

    public class KredilerininDurumu
    {
        public bool KredilerininDurumuIyiMi(Musteri c)
        {
            Console.WriteLine(c.Name + "'nun mevcut kredileri kontrol ediliyor.");
            return true;
        }
    }

    /// Müşteri Sınıfı

    public class Musteri
    {
        private string name;

        // Constructor

        public Musteri(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return name; }
        }
    }

    /// Facade (üst) Sınıf

    public class Kredi
    {
        HesapBilgisi hesapbilgisi = new HesapBilgisi();
        KredilerininDurumu kredileri = new KredilerininDurumu();
        KrediSkoru krediskoru = new KrediSkoru();

        public bool UygunMu(Musteri musteri, int miktar)
        {
            Console.WriteLine("{0}, {1}e kadar kredi için başvuruda bulundu. Kotroller gerçekleştirilip, başvuru sonuçlandırılacak:\n",
                musteri.Name, miktar);

            bool uygun = true;

            // Kredi Kontrollerini gerçekleştirip buna bağlı olarak kredi alıp alamayacağına karar ver:

            if (!hesapbilgisi.YeterliBirikimVarMi(musteri, miktar))
            {
                uygun = false;
            }
            else if (!kredileri.KredilerininDurumuIyiMi(musteri))
            {
                uygun = false;
            }
            else if (!krediskoru.KrediSkoruIyiMi(musteri))
            {
                uygun = false;
            }

            return uygun;
        }
    }
}
