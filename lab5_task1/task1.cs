using wonderful_string_tools;

namespace lab5_task1;

public class task1
{
    public static void Run()
    {
        Console.Clear();
        Console.WriteLine("@ Определить, какое из двух слов длиннее и насколько.");
        Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
        Console.Write("@ Введите первое слово: ");

        string? w1 = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(w1))
            return;

        Console.Write("@ Введите второе слово: ");

        string? w2 = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(w2))
            return;

        Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");

        if (w1.Length == w2.Length)
            Console.WriteLine($"@ Строки {w1} и {w2} равны.");

        else if (StringTools.IsFirstWordLonger(w1, w2))
            Console.WriteLine($"@ Первое слово {w1} длиннее второго слова {w2} на {StringTools.HowWordLonger(w1, w2)} символов.");
        else
            Console.WriteLine($"@ Второе слово {w2} длиннее первого слова {w1} на {StringTools.HowWordLonger(w1, w2)} символов.");
        Console.ReadKey();
    }
}
