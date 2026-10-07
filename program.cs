namespace NesProg7ekim;

class Program
{
    static void Main(string[] args)
    {
        int[,] notlar = new int[20, 2];

        int toplamvize = 0; 
        int toplamfinal = 0;

        
        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine($"{i + 1}. öğrencinin notlarını giriniz: ");
            Console.Write("Vize notu: ");
            notlar[i, 0] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Final notu: ");
            notlar[i, 1] = Convert.ToInt32(Console.ReadLine());
            toplamvize += notlar[i, 0];
            toplamfinal += notlar[i, 1];
        }
        Console.WriteLine($"Sınıfın vize ortalaması: {toplamvize / 20}");
        Console.WriteLine($"Sınıfın final ortalaması: {toplamfinal / 20}");

    }
}
