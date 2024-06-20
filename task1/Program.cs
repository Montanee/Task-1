using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Выберите опцию: ");
        Console.WriteLine("1. Конвертировать из Цельсия в Фаренгейт");
        Console.WriteLine("2. Конвертировать из Фаренгейта в Цельсия");
        int выбор = Convert.ToInt32(Console.ReadLine());

        if (выбор == 1)
        {
            Console.Write("Введите температуру в Цельсиях: ");
            double температураВЦельсиях = Convert.ToDouble(Console.ReadLine());
            double температураВФаренгейтах = (температураВЦельсиях * 9 / 5) + 32;
            Console.WriteLine("Температура в Фаренгейтах: " + температураВФаренгейтах);
        }
        else if (выбор == 2)
        {
            Console.Write("Введите температуру в Фаренгейтах: ");
            double температураВФаренгейтах = Convert.ToDouble(Console.ReadLine());
            double температураВЦельсиях = (температураВФаренгейтах - 32) * 5 / 9;
            Console.WriteLine("Температура в Цельсиях: " + температураВЦельсиях);
        }
        else
        {
            Console.WriteLine("Неверный выбор.");
        }
    }
}
