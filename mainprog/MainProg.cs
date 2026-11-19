using ConsoleMenuLib;
using WonderfulStringsToolsLib;
using Lab5Task1;
using Lab5Task2;
using Lab5Task3;
using System.Text;

namespace Lab5;

internal static class MainProg
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();

        ConsoleMenu.LabNumber = 5;
        ConsoleMenu.SymbolFiller = '@';
        ConsoleMenu.LabTasks = new List<StringBuilder>
        {
            new StringBuilder("Определить, какое из двух слов длиннее и насколько."),
            new StringBuilder("Напечатать последовательность слов в обратном порядке."),
            new StringBuilder("Удвоить все согласные буквы.")
        };
        ConsoleMenu.Init();

        while (true)
        {
            Console.Clear();
            ConsoleMenu.WriteMenu();

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