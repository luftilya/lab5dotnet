using WonderfulStringsTools;

namespace Lab5Task2;

public class Task2
{
    public static void Run()
    {
        Console.Clear();
        Console.Write("""
            @ Напечатать последовательность слов в обратном порядке.
            @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
            @ Введите предложение С ЗАПЯТОЙ МЕЖДУ СЛОВАМИ БЕЗ ПРОБЕЛОВ: 
            """);

        string? input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input))
            return;

        var bannedSignes = " .;/|\\`~@#№$%^:&?*()+=<>";

        foreach (char sign in bannedSignes)
        {
            if (input.Contains(sign))
            {
                Console.Write("""
                @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
                @ ОШИБКА! Вы использовали неправильный разделитель слов!
                @ Попробуйте ещё раз (нажмите Enter для выхода).
                @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
                """);
                Console.ReadKey();
                return;
            }
        }

        Console.Write($"""
            @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
            @ Предложение в обратном порядке слов:
            @ {StringTools.ReverseWordsPrint(input)}.
            @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
            @ Для выхода нажмите Enter.                              @
            """);
        Console.ReadKey();
    }
}
