using System;

// Çalışan sınıfı: Bir çalışanı temsil eder.
public class Calisan
{
    public string Ad { get; set; }  // Çalışanın adı
    public string Pozisyon { get; set; }  // Çalışanın pozisyonu
    public Departman Departman { get; set; }  // Çalışanın ait olduğu departman

    // Çalışana bir departman atamak için metod
    public void DepartmanAtama(Departman departman)
    {
        Departman = departman;
    }

    // Çalışan bilgilerini yazdır
    public void BilgileriGoster()
    {
        Console.WriteLine($"Ad: {Ad}, Pozisyon: {Pozisyon}");
        Console.WriteLine($"Departman: {Departman.Ad}, Lokasyon: {Departman.Lokasyon}");
    }
}

// Departman sınıfı: Bir departmanı temsil eder.
public class Departman
{
    public string Ad { get; set; }  // Departman adı
    public string Lokasyon { get; set; }  // Departmanın bulunduğu yer
}

// Test Programı
public class Program
{
    public static void Main()
    {
        // Departman nesnesi oluştur
        Departman departman = new Departman { Ad = "Bilgi Teknolojileri", Lokasyon = "İstanbul" };

        // Çalışan nesnesi oluştur ve departman atama
        Calisan calisan = new Calisan { Ad = "Ayşe Yılmaz", Pozisyon = "Yazılım Geliştirici" };
        calisan.DepartmanAtama(departman);

        // Çalışan bilgilerini göster
        calisan.BilgileriGoster();

        // Konsolu açık tutmak için ReadLine
        Console.WriteLine("Çıkmak için bir tuşa basın...");
        Console.ReadLine();
    }
}
