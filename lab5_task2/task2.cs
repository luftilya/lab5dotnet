using wonderful_string_tools;

namespace lab5_task2;

public class task2
{
    public static void Run()
    {
        Console.Clear();
        Console.WriteLine("@ Напечатать последовательность слов в обратном порядке.");
        Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
        Console.Write("@ Введите предложение С ЗАПЯТОЙ МЕЖДУ СЛОВАМИ БЕЗ ПРОБЕЛОВ: ");

        string? input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input))
            return;

        Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
        Console.WriteLine("@ Предложение в обратном порядке слов:");
        Console.WriteLine($"@ {StringTools.ReverseWordsPrint(input)}.");
        Console.ReadKey();
    }
}
