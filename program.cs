namespace NesProg7ekim;

class Program
{
    static void Main(string[] args)
    {
        int[,] notlar = new int[20, 2];
        
        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine($"{i + 1}. öğrencinin notlarını giriniz: ");
            Console.Write("Vize notu: ");
            notlar[i, 0] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Final notu: ");
            notlar[i, 1] = Convert.ToInt32(Console.ReadLine());
        }
    }
}
