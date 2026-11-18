using WonderfulStringsTools;

namespace Lab5Task3;

public class Task3
{
    public static void Run()
    {
        Console.Clear();
        Console.Write("""
            @ Удвоить все согласные кириллические буквы.
            @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
            @ Введите предложение на кириллице: 
            """);

        string? input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input))
            return;

        Console.Write($"""
            @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
            @ Удвоение согласных: {StringTools.ToDoubleConsonants(input)}
            @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
            @ Для выхода нажмите Enter.                  @
            """);
        Console.ReadKey();
    }
}
