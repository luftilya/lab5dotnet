using ConsoleMenuLib;
using WonderfulStringsToolsLib;

namespace Lab5Task1;

public class Task1
{
    public static void Run()
    {
        Console.Clear();
        ConsoleMenu.WriteTask(1);
        ConsoleMenu.Write("Введите первое слово: ");

        string? firstWord = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(firstWord))
            return;

        var bannedSignes = " .;/|\\`~@#№$%^:&?*()+=<>";

        foreach (char sign in bannedSignes)
        {
            if (firstWord.Contains(sign))
            {
                ConsoleMenu.WriteFiller();
                ConsoleMenu.Write("""
                    ОШИБКА! Вы использовали разделитель или разделители
                    при вводе слова, что неправильно.
                    Попробуйте ещё раз (нажмите Enter для выхода).

                    """);
                ConsoleMenu.WriteFiller();
                Console.ReadKey();
                return;
            }
        }

        ConsoleMenu.Write("Введите второе слово: ");

        string? secondWord = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(secondWord))
            return;

        foreach (char sign in bannedSignes)
        {
            if (secondWord.Contains(sign))
            {
                ConsoleMenu.WriteFiller();
                ConsoleMenu.Write("""
                    ОШИБКА! Вы использовали разделитель или разделители
                    при вводе слова, что неправильно.
                    Попробуйте ещё раз (нажмите Enter для выхода).

                    """);
                ConsoleMenu.WriteFiller();
                Console.ReadKey();
                return;
            }
        }

        ConsoleMenu.WriteFiller();

        if (firstWord.Length == secondWord.Length)
            ConsoleMenu.Write($"""
                Строки "{firstWord}" и "{secondWord}" равны по длине.

                """);
        else if (StringTools.IsFirstWordLonger(firstWord, secondWord))
            ConsoleMenu.Write($"""
                Первое слово "{firstWord}" длиннее второго слова "{secondWord}" на {StringTools.HowWordLonger(firstWord, secondWord)} символов.
                
                """);
        else
            ConsoleMenu.Write($"""
                Второе слово "{secondWord}" длиннее первого слова "{firstWord}" на {StringTools.HowWordLonger(firstWord, secondWord)} символов.
                
                """
                );
        ConsoleMenu.WriteEnd();
    }
}