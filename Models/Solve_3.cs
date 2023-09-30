using PTMKTestTask.DAL.Context;

namespace PTMKTestTask.Models
{
    public static class Solve_3
    {
        public static void Solve()
        {
            PTMKTestTaskDB db = new PTMKTestTaskDB();
            var users = db.Users
                        .GroupBy(x => new { x.FullName, x.DateOfBirth })
                        .Select(x => x.First())
                        .ToList()
                        .OrderBy(x => x.FullName);

            foreach (var item in users)
            {
                item.Print();
            }
            
        }
       
    }
}
