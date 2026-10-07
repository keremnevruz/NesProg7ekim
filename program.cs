namespace NesProg7ekim;

class Program
{
    static void Main(string[] args)
    {
        int[,] notlar = new int[20, 2];
        Console.WriteLine("Lütfen 20 öğrencinin notlarını giriniz (Öğrenci No ve Not):");
        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine($"Öğrenci {i + 1}:");
            Console.Write("Öğrenci No: ");
            notlar[i, 0] = int.Parse(Console.ReadLine());
            Console.Write("Not: ");
            notlar[i, 1] = int.Parse(Console.ReadLine());
        }
    }
}
