using ConsoleMenuLib;
using WonderfulStringsToolsLib;

namespace Lab5Task2;

public class Task2
{
    public static void Run()
    {
        Console.Clear();
        ConsoleMenu.WriteTask(2);
        ConsoleMenu.Write(
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
                ConsoleMenu.Write("""
                    ОШИБКА! Вы использовали неправильный разделитель слов!
                    Попробуйте ещё раз (нажмите Enter для выхода).

                    """);
                ConsoleMenu.WriteFiller();
                Console.ReadKey();
                return;
            }
        }

        ConsoleMenu.WriteFiller();
        ConsoleMenu.Write($"""
            Предложение в обратном порядке слов: {StringTools.ReverseWordsPrint(input)}.

            """);
        ConsoleMenu.WriteEnd();
    }
}