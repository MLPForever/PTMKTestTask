using PTMKTestTask.DAL.Context;
using PTMKTestTask.Data;

namespace PTMKTestTask.Models
{
    public static class Solve_1
    { 
        public async static Task Solve()
        {
            PTMKTestTaskDB db = new PTMKTestTaskDB();
            await DbInitializer.InitializeAsync(db);
        }
    }
}
