using wonderful_string_tools;

namespace lab5_task3;

public class task3
{
    public static void Run()
    {
        Console.Clear();
        Console.WriteLine("@ Удвоить все согласные буквы.");
        Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
        Console.Write("@ Введите предложение по-русски: ");

        string? input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input))
            return;

        Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
        Console.Write("@ Удвоение согласных: ");
        Console.WriteLine(StringTools.ToDoubleConsonants(input));
        Console.ReadKey();
    }
}
