using System;
public class Mainclass
{
    public static void Main()
    {
        int fund1, fund2, high;
        Console.WriteLine("Введите длину меньшего основания:");
        fund1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите длину большего основания:");
        fund2 = int.Parse(Console.ReadLine());
        if (fund1 < fund2)
        {
            Console.WriteLine("Введите высоту трапеции:");
            high = int.Parse(Console.ReadLine());
            double wall = Math.Sqrt(Math.Pow((fund2 - fund1) / 2, 2) + Math.Pow(high, 2));
            double per = fund1 + fund2 + wall * 2;
            Console.WriteLine("Периметр основания равен {0}", per);
        }
    }
}