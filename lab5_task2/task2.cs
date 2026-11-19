using ConsoleMenuLib;
using WonderfulStringsToolsLib;

namespace Lab5Task2;

public class Task2
{
    public static void Run()
    {
        Console.Clear();
        ConsoleMenu.WriteTask(2);
        ConsoleMenu.WriteContent(
            "Введите предложение С ЗАПЯТОЙ МЕЖДУ СЛОВАМИ БЕЗ ПРОБЕЛОВ: ");

        string? input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input))
            return;

        var bannedSignes = " .;/|\\`~@#№$%^:&?*()+=<>";

        foreach (char sign in bannedSignes)
        {
            if (input.Contains(sign))
            {
                ConsoleMenu.WriteFiller();
                ConsoleMenu.WriteContent("""
                    ОШИБКА! Вы использовали неправильный разделитель слов!
                    Попробуйте ещё раз (нажмите Enter для выхода).
                    """);
                ConsoleMenu.WriteFiller();
                Console.ReadKey();
                return;
            }
        }

        ConsoleMenu.WriteFiller();
        ConsoleMenu.WriteContent($"""
            Предложение в обратном порядке слов: {StringTools.ReverseWordsPrint(input)}.
            """);
        ConsoleMenu.WriteEnd();
    }
}