using System.Linq.Expressions;

namespace NesProg7ekim;

class Program
{
    static void Main(string[] args)
    {
        int[,] notlar = new int[20, 2];
        int toplamvize = 0;
        int toplamfinal = 0;
        double ogrortalamasi;

        for (int i = 0; i < 20; i++)
        {
            Console.Write(i + " Öğrenci İçin Vize Notu Giriniz: ");
            notlar[i, 0] = Convert.ToInt32(Console.ReadLine());
            toplamvize += notlar[i, 0];

            Console.Write(i + " Öğrenci İçin Final Notu Giriniz: ");
            notlar[i, 1] = Convert.ToInt32(Console.ReadLine());
            toplamfinal += notlar[i, 1];

            ogrortalamasi = (notlar[i, 0] + notlar[i, 1]) / 2.0;

            string sonuc = ogrortalamasi switch
            {
                >= 90 => "AA",
                >= 85 => "BA",
                >= 80 => "BB",
                >= 75 => "CB",
                >= 70 => "CC",
                >= 65 => "DC",
                >= 60 => "DD",
                >= 50 => "FD",
                _ => "FF"
            };
            {
                Console.WriteLine("Öğrenci " + sonuc);  
            }
        }

        Console.WriteLine("Vize Ortalaması: " + toplamvize / 20.0);
        Console.WriteLine("Final Ortalaması: " + toplamfinal / 20.0);
        Console.WriteLine("Genel Ortalama: " + (toplamvize / 20.0) * 0.4 + (toplamfinal / 20.0) * 0.6);
    }
}