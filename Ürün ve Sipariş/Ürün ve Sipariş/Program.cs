using System;
using System.Collections.Generic;

// Ürün sınıfı: Bir ürünü temsil eder.
public class Urun
{
    public string Ad { get; set; }  // Ürün adı
    public int Fiyat { get; set; }  // Ürün fiyatı

    // Ürün bilgilerini döndüren metod
    public string UrunBilgisi()
    {
        return $"{Ad}: {Fiyat} TL";
    }
}

// Sipariş sınıfı: Bir siparişi temsil eder.
public class Siparis
{
    public DateTime Tarih { get; set; }  // Sipariş tarihi
    public decimal Toplam { get; set; }  // Sipariş toplam tutarı
    public List<Urun> Urunler { get; set; } = new List<Urun>();  // Siparişe eklenen ürünler listesi

    // Siparişe ürün eklemek için metod
    public void UrunEkle(Urun urun)
    {
        Urunler.Add(urun);
        Toplam += urun.Fiyat;  // Toplam tutara eklenen ürünün fiyatını ekle
    }

    // Sipariş detaylarını yazdır
    public void SiparisDetaylari()
    {
        Console.WriteLine($"Sipariş Tarihi: {Tarih}");
        Console.WriteLine("Ürünler:");
        foreach (var urun in Urunler)
        {
            Console.WriteLine($"- {urun.UrunBilgisi()}");
        }
        Console.WriteLine($"Toplam Tutar: {Toplam} TL");
    }
}

// Test Programı
public class Program
{
    public static void Main()
    {
        // Sipariş nesnesi oluştur
        Siparis siparis = new Siparis { Tarih = DateTime.Now };

        // Ürün nesneleri oluştur
        Urun urun1 = new Urun { Ad = "Laptop", Fiyat = 15000 };
        Urun urun2 = new Urun { Ad = "Mouse", Fiyat = 500 };

        // Siparişe ürün ekle
        siparis.UrunEkle(urun1);
        siparis.UrunEkle(urun2);

        // Sipariş detaylarını göster
        siparis.SiparisDetaylari();

        // Konsolu açık tutmak için ReadLine
        Console.WriteLine("Çıkmak için bir tuşa basın...");
        Console.ReadLine();
    }
}
