using System;
using System.Collections.Generic;

// Yazar sınıfı: Bir yazarı temsil eder.
public class Yazar
{
    public string Ad { get; set; }  // Yazarın adı
    public string Ulke { get; set; }  // Yazarın ülkesi
    public List<Kitap> Kitaplar { get; set; } = new List<Kitap>();  // Yazarın kitapları listesi

    // Kitap eklemek için metod
    public void KitapEkle(Kitap kitap)
    {
        Kitaplar.Add(kitap);
    }

    public void KitaplariListele()
    {
        Console.WriteLine($"{Ad} adlı yazarın kitapları:");
        foreach (var kitap in Kitaplar)
        {
            Console.WriteLine($"- {kitap.Baslik} (ISBN: {kitap.ISBN}, Yayın Tarihi: {kitap.YayinTarihi.ToShortDateString()})");
        }
    }
}

// Kitap sınıfı: Bir kitabı temsil eder.
public class Kitap
{
    public string Baslik { get; set; }  // Kitap başlığı
    public string ISBN { get; set; }  // Kitap ISBN numarası
    public DateTime YayinTarihi { get; set; }  // Kitap yayın tarihi
    public Yazar Yazar { get; set; }  // Kitabın yazarı
}

// Test Programı
public class Program
{
    public static void Main()
    {
        // Yazar nesnesi oluştur
        Yazar yazar = new Yazar { Ad = "Orhan Pamuk", Ulke = "Türkiye" };

        // Kitap nesneleri oluştur
        Kitap kitap1 = new Kitap { Baslik = "Masumiyet Müzesi", ISBN = "9789750812993", YayinTarihi = new DateTime(2008, 8, 29), Yazar = yazar };
        Kitap kitap2 = new Kitap { Baslik = "Kara Kitap", ISBN = "9789750804035", YayinTarihi = new DateTime(1990, 5, 1), Yazar = yazar };

        // Yazarın kitaplarına ekle
        yazar.KitapEkle(kitap1);
        yazar.KitapEkle(kitap2);

        // Yazarın kitaplarını listele
        yazar.KitaplariListele();

        Console.WriteLine("Çıkmak için bir tuşa basın...");
        Console.ReadLine();
    }
}
