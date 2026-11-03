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
                    {
                        Console.Clear();
                        Console.WriteLine("@ Определить, какое из двух слов длиннее и насколько.");
                        Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                        Console.Write("@ Введите первое слово: ");

                        string? w1 = Console.ReadLine();
                        
                        if (string.IsNullOrWhiteSpace(w1))
                            break;

                        Console.Write("@ Введите второе слово: ");

                        string? w2 = Console.ReadLine();
                        
                        if (string.IsNullOrWhiteSpace(w2))
                            break;

                        Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");

                        if (w1.Length == w2.Length)
                            Console.WriteLine($"@ Строки {w1} и {w2} равны.");

                        else if (StringTools.IsFirstWordLonger(w1, w2))
                            Console.WriteLine($"@ Первое слово {w1} длиннее второго слова {w2} на {StringTools.HowWordLonger(w1, w2)} символов.");
                        else
                            Console.WriteLine($"@ Второе слово {w2} длиннее первого слова {w1} на {StringTools.HowWordLonger(w1, w2)} символов.");
                        Console.ReadKey();
                    }
                    break;
                case "2":
                    {
                        Console.Clear();
                        Console.WriteLine("@ Напечатать последовательность слов в обратном порядке.");
                        Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                        Console.Write("@ Введите предложение С ЗАПЯТОЙ МЕЖДУ СЛОВАМИ БЕЗ ПРОБЕЛОВ: ");
                        
                        input = Console.ReadLine();

                        if (string.IsNullOrWhiteSpace(input))
                            break;
                        
                        Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                        Console.WriteLine("@ Предложение в обратном порядке слов:");
                        Console.WriteLine($"@ {StringTools.ReverseWordsPrint(input)}.");
                        Console.ReadKey();
                    }
                    break;
                case "3":
                    {
                        Console.Clear();
                        Console.WriteLine("@ Удвоить все согласные буквы.");
                        Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                        Console.Write("@ Введите предложение по-русски: ");
                        
                        input = Console.ReadLine();

                        if (string.IsNullOrWhiteSpace(input))
                            break;

                        Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                        Console.Write("@ Удвоение согласных: ");
                        Console.WriteLine(StringTools.ToDoubleConsonants(input));
                        Console.ReadKey();
                    }
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