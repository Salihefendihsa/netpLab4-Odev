using System;
using System.Collections.Generic;

// Doktor sınıfı: Bir doktoru temsil eder.
public class Doktor
{
    public string Ad { get; set; }  // Doktorun adı
    public string Branş { get; set; }  // Doktorun branşı
    public List<Hasta> Hastalar { get; set; } = new List<Hasta>();  // Doktorun hastaları

    // Hastaya doktor eklemek için metod
    public void HastaEkle(Hasta hasta)
    {
        Hastalar.Add(hasta);
    }

    // Doktorun hastalarını listele
    public void HastalariListele()
    {
        Console.WriteLine($"{Ad} doktorunun hastaları:");
        foreach (var hasta in Hastalar)
        {
            Console.WriteLine($"- {hasta.Ad} (TCKN: {hasta.TCKN})");
        }
    }
}

// Hasta sınıfı: Bir hastayı temsil eder.
public class Hasta
{
    public string Ad { get; set; }  // Hastanın adı
    public string TCKN { get; set; }  // Hastanın TCKN'si
    public Doktor Doktor { get; set; }  // Hastanın doktoru
}

// Test Programı
public class Program
{
    public static void Main()
    {
        // Doktor nesnesi oluştur
        Doktor doktor = new Doktor { Ad = "Dr. Ali", Branş = "Kardiyoloji" };

        // Hasta nesneleri oluştur
        Hasta hasta1 = new Hasta { Ad = "Ahmet", TCKN = "12345678910", Doktor = doktor };
        Hasta hasta2 = new Hasta { Ad = "Ayşe", TCKN = "98765432100", Doktor = doktor };

        // Doktorun hastalarına ekle
        doktor.HastaEkle(hasta1);
        doktor.HastaEkle(hasta2);

        // Doktorun hastalarını listele
        doktor.HastalariListele();

        Console.WriteLine("Çıkmak için bir tuşa basın...");
        Console.ReadLine();
    }
}
