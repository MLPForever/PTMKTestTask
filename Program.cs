using PTMKTestTask.Models;

namespace PTMKTestTask
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            await ReadArgsFromKbd(args);
        }

        static async Task ReadArgsFromKbd(string[] args)
        {
            if (args.Length >= 1)
            {
                if (args.First() == "1")
                {
                    await Solve_1.Solve();
                    Console.WriteLine("Таблица создана");
                }
                else if (args.First() == "2")
                {
                    Solve_2.Solve(args);
                    Console.WriteLine("Данные добавлены");
                }
                else if (args.First() == "3")
                {
                    Solve_3.Solve();
                }
                else if (args.First() == "4")
                {
                    Solve_4.Solve();
                }
                else if (args.First() == "5")
                {
                    Solve_5.Solve();
                }
                else if (args.First() == "6")
                {
                    Solve_6.Solve();
                }
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }  
}