using ConsoleMenuLib;
using WonderfulStringsToolsLib;

namespace Lab5Task3;

public class Task3
{
    public static void Run()
    {
        Console.Clear();
        ConsoleMenu.WriteTask(3);
        ConsoleMenu.Write("Введите предложение на кириллице: ");

        string? input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input))
            return;

        ConsoleMenu.WriteFiller();
        ConsoleMenu.Write($"""
            Удвоение согласных: {StringTools.ToDoubleConsonants(input)}

            """);
        ConsoleMenu.WriteEnd();
    }
}