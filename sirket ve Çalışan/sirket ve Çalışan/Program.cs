using System;
using System.Collections.Generic;

// Şirket sınıfı: Bir şirketi temsil eder.
public class Sirket
{
    public string Ad { get; set; }  // Şirket adı
    public string Lokasyon { get; set; }  // Şirket lokasyonu
    public List<Calisan> Calisanlar { get; set; } = new List<Calisan>();  // Şirketin çalışanları

    // Çalışanı ekleme metodu
    public void CalisanEkle(Calisan calisan)
    {
        Calisanlar.Add(calisan);
    }

    public void CalisanlariListele()
    {
        Console.WriteLine($"{Ad} şirketindeki çalışanlar:");
        foreach (var calisan in Calisanlar)
        {
            Console.WriteLine($"- {calisan.Ad} ({calisan.Pozisyon})");
        }
    }
}

// Çalışan sınıfı
public class Calisan
{
    public string Ad { get; set; }  // Çalışan adı
    public string Pozisyon { get; set; }  // Çalışanın pozisyonu
    public Sirket Sirket { get; set; }  // Çalışanın şirketi
}

// Test Programı
public class Program
{
    public static void Main()
    {
        Sirket sirket = new Sirket { Ad = "TechCorp", Lokasyon = "Ankara" };
        Calisan calisan1 = new Calisan { Ad = "Fatma", Pozisyon = "Yönetici", Sirket = sirket };
        Calisan calisan2 = new Calisan { Ad = "Mert", Pozisyon = "Mühendis", Sirket = sirket };

        sirket.CalisanEkle(calisan1);
        sirket.CalisanEkle(calisan2);

        sirket.CalisanlariListele();

        Console.ReadLine();
    }
}
