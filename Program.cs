using System;
using System.Collections.Generic;
 
namespace Koleksiyonlar
{
    class Program
    {
        public static void Main()
        {
            // List<T> 
            // using.Generic.Collection içerisinde
            // T -> object türündedir.

            List<int> sayiListesi = new List<int>();

            sayiListesi.Add(92);
            sayiListesi.Add(23);
            sayiListesi.Add(45);
            sayiListesi.Add(5);
            sayiListesi.Add(12);
            sayiListesi.Add(4);
            sayiListesi.Add(26);

            List<string> renkListesi = new List<string>();

            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Mor");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Fuşa");

            // .Count methodu ile listeler içerisinde kaç tane eleman var öğrenebiliriz.

            Console.WriteLine(sayiListesi.Count);
            Console.WriteLine(renkListesi.Count);

            // foreach ve List.ForEach ile elemanlara erişim

            foreach (int sayi in sayiListesi)
                Console.WriteLine(sayi);
            foreach (string renk in renkListesi)
                Console.WriteLine(renk);
            
            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));
            sayiListesi.ForEach(sayi => Console.WriteLine(sayi + 1));

            // Listeden eleman çıkartma

            sayiListesi.Remove(26);
            sayiListesi.RemoveAt(2);

            renkListesi.Remove("Fuşa");
            renkListesi.RemoveAt(1);

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            // Liste içerisinde arama yapma

            if (sayiListesi.Contains(4))
                Console.WriteLine("Girilen değer mevcut.");

            // Eleman ile indekse erişme

            Console.WriteLine(renkListesi.BinarySearch("Kırmızı"));

            // Diziyi listeye çevirme

            string[] hayvanlar = { "Kedi", "Köpek", "Aslan" };
            List<string> hayvanListesi = new List<string>(hayvanlar);           

            foreach (string hayvan in hayvanListesi)
                Console.WriteLine(hayvan);

            // Diziyi temizleme

            hayvanListesi.Clear();
            hayvanListesi.Add("Kuş");
            hayvanListesi.ForEach(hayvan => Console.WriteLine(hayvan));

            // List içerisinde nesne tutmak

            List<Kullanıcılar> kullanıcıListesi = new List<Kullanıcılar>();

            Kullanıcılar kullanıcı1 = new Kullanıcılar();
            kullanıcı1.Isim = "Furkan";
            kullanıcı1.Soyisim = "Yılmaz";
            kullanıcı1.Yas = 26;

            Kullanıcılar kullanıcı2 = new Kullanıcılar();
            kullanıcı2.Isim = "Faruk";
            kullanıcı2.Soyisim = "Yılmaz";
            kullanıcı2.Yas = 18;

            kullanıcıListesi.Add(kullanıcı1);
            kullanıcıListesi.Add(kullanıcı2);

            foreach (var kullanıcı in kullanıcıListesi)
            {
                Console.WriteLine("Kullanıcı Adı: " + kullanıcı1.Isim);
                Console.WriteLine("Kullanıcı Soyadı: " + kullanıcı1.Soyisim);
                Console.WriteLine("Kullanıcı Yaşı: " + kullanıcı1.Yas);
            }

        }

    }

    public class Kullanıcılar
    {
        private string isim;
        private string soyisim;
        private int yas;

        public string Isim { get => isim; set => isim = value; }

        public string Soyisim { get => soyisim; set => soyisim = value; }

        public int Yas { get => yas; set => yas = value; }
    }
}