using System;

class Program
{
    static void Main()
    {
        // Kullanıcının girdiği sayıyı tutacak değişken
        int sayi;

        // Sayı 0 olmadığı sürece döngü devam eder
        do
        {
            // Kullanıcıdan sayı isteyip sayıya çeviriyoruz
            Console.Write("Bir sayı gir (çıkmak için 0): ");
            sayi = int.Parse(Console.ReadLine());
        }
        while (sayi != 0);

        // 0 girilince döngü biter ve buraya gelir
        Console.WriteLine("Program bitti.");
    }
}