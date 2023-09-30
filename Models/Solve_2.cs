using PTMKTestTask.DAL.Entities;

namespace PTMKTestTask.Models
{
    public static class Solve_2
    {
        public static void Solve(string[] args)
        {
            string FullName = args[1];
            DateOnly DateOfBirth = DateOnly.Parse(args[2]);
            char Gender = char.Parse(args[3]);
            User User = new User(FullName, DateOfBirth, Gender);
            User.Save();
        }
    }
}
