using WonderfulStringsTools;
using Lab5Task1;
using Lab5Task2;
using Lab5Task3;

namespace Lab5;

internal static class MainProg
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();

        while (true)
        {
            Console.Clear();
            Console.Write("""
                @ Лабораторная работа №5. Выполнили Илья Зеленев и Станислав Сахаров, бТИИ-251, вариант 1 @
                @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
                @ 1) Определить, какое из двух слов длиннее и насколько.    @ 4) -> Windows Forms.        @
                @ 2) Напечатать последовательность слов в обратном порядке. @ 5) -> Windows Forms.        @
                @ 3) Удвоить все согласные буквы.                           @ 6) -> Windows Forms.        @
                @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
                @ Введите номер задания и нажмите enter (для выхода нажмите Ctrl^C): 
                """);

            string? input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Task1.Run();
                    break;
                case "2":
                    Task2.Run();
                    break;
                case "3":
                    Task3.Run();
                    break;
                case "4":
                    Application.Run(new FormOf1());
                    break;
                case "5":
                    Application.Run(new FormOf2());
                    break;
                case "6":
                    Application.Run(new FormOf3());
                    break;
            }
        }
    }
}