using System;
using System.Collections.Generic;

// Müşteri sınıfı: Bir müşteriyi temsil eder.
public class Musteri
{
    public string Ad { get; set; }  // Müşterinin adı
    public string Email { get; set; }  // Müşterinin email adresi
    public List<Siparis> Siparisler { get; set; } = new List<Siparis>();  // Müşterinin siparişleri listesi

    // Yeni bir sipariş eklemek için metod
    public void SiparisEkle(Siparis siparis)
    {
        Siparisler.Add(siparis);
    }

    // Müşterinin tüm siparişlerini yazdır
    public void SiparisleriListele()
    {
        Console.WriteLine($"{Ad} adlı müşterinin siparişleri:");
        foreach (var siparis in Siparisler)
        {
            Console.WriteLine($"- Sipariş Tarihi: {siparis.Tarih}, Toplam Tutar: {siparis.Toplam} TL");
        }
    }
}

// Sipariş sınıfı: Bir siparişi temsil eder.
public class Siparis
{
    public DateTime Tarih { get; set; }  // Sipariş tarihi
    public decimal Toplam { get; set; }  // Sipariş toplam tutarı
}

// Test Programı
public class Program
{
    public static void Main()
    {
        // Müşteri nesnesi oluştur
        Musteri musteri = new Musteri { Ad = "Mehmet Can", Email = "mehmetcan@example.com" };

        // Sipariş nesneleri oluştur
        Siparis siparis1 = new Siparis { Tarih = new DateTime(2024, 11, 15), Toplam = 250.50m };
        Siparis siparis2 = new Siparis { Tarih = DateTime.Now, Toplam = 480.75m };

        // Müşterinin siparişlerine ekle
        musteri.SiparisEkle(siparis1);
        musteri.SiparisEkle(siparis2);

        // Müşterinin siparişlerini listele
        musteri.SiparisleriListele();

        // Konsolu açık tutmak için ReadLine
        Console.WriteLine("Çıkmak için bir tuşa basın...");
        Console.ReadLine();
    }
}
