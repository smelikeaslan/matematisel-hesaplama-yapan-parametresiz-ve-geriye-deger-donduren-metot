using System;

class Program
{
    static void Main(string[] args)
    {
       
        Console.Write("Üçgenin taban uzunluğunu girin: ");
        double taban = Convert.ToDouble(Console.ReadLine());

        Console.Write("Üçgenin yüksekliğini girin: ");
        double yukseklik = Convert.ToDouble(Console.ReadLine());

       
        double alan = UcgenAlaniHesapla(taban, yukseklik);

        
        Console.WriteLine($"Üçgenin alanı: {alan}");
    }

    
    static double UcgenAlaniHesapla(double taban, double yukseklik)
    {
        return (taban * yukseklik) / 2;
        Console.ReadKey();
    }
    
}