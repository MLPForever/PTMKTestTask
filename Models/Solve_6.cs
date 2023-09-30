using PTMKTestTask.DAL.Context;
using System.Diagnostics;

namespace PTMKTestTask.Models
{
    public static class Solve_6
    {
        public static void Solve()
        {
            PTMKTestTaskDB db = new PTMKTestTaskDB();
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            var Users = db.Users
                        .Where(x => x.IsConditions == true)                        
                        .ToList()
                        .OrderBy(x => x.FullName);
            stopwatch.Stop();
            foreach (var item in Users)
            {
                item.Print();
            }
            Console.WriteLine($"Время выполнения: {stopwatch.ElapsedMilliseconds} мс.");
        }
    }
}
