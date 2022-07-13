using ConsoleApp4.Abstract;
using ConsoleApp4.Concrete;
using System;

namespace MyApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dialog? dialog = null;
            IButton? button = null;

            while (true)
            {
                Console.WriteLine(

                    @"
                      1.Windows
                      2.Web");
                Console.WriteLine("\n\tEnter your choice: ");

                dialog = Console.ReadLine() switch
                {
                    "1" => new WindowsDialog(),
                    "2" => new WebDialog(),
                    _ => null
                };

                if (dialog == null) break;
                button = dialog?.CreateButton();
                button?.OnClick();
                button?.Render();

            }

        }
    }
}