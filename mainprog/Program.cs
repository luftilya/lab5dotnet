using lab5_task1;
using lab5_task2;
using lab5_task3;
using wonderful_string_tools;

namespace lab5;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();

        while (true)
        {
            Console.Clear();
            Console.WriteLine("@ Лабораторная работа №5. Выполнили Илья Зеленев и Станислав Сахаров, бТИИ-251, вариант 1 @");
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            Console.WriteLine("@ 1) Определить, какое из двух слов длиннее и насколько.    @ 4) -> Windows Forms.        @");
            Console.WriteLine("@ 2) Напечатать последовательность слов в обратном порядке. @ 5) -> Windows Forms.        @");
            Console.WriteLine("@ 3) Удвоить все согласные буквы.                           @ 6) -> Windows Forms.        @");
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            Console.Write("@ Введите номер задания и нажмите enter (для выхода ничего не вводите): ");

            string? input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    task1.Run();
                    break;
                case "2":
                    task2.Run();
                    break;
                case "3":
                    task3.Run();
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