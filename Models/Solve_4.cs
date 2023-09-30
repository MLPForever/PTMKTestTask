using PTMKTestTask.DAL.Entities;

namespace PTMKTestTask.Models
{
    public static class Solve_4
    {
        private static Random r = new Random();
        public static void Solve()
        {
            List<User> Users = new List<User>();
            for (int i = 0; i < 1000000; i++)
            {
                Users.Add(new User(GenerateName(false), GenerateDateOfBirth(), r.Next(1, 3) < 2 ? 'm' : 'f'));               
            }
            for (int i = 0; i < 100; i++)
            {
                Users.Add(new User(GenerateName(true), GenerateDateOfBirth(), 'm'));
            }
            User.SaveRange(Users);
        }
        private static string GenerateName(bool NeedF)
        {
            string[] consonants = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "l", "n", "p", "q", "r", "s", "sh", "zh", "t", "v", "w", "x" };
            string[] vowels = { "a", "e", "i", "o", "u", "ae", "y" };
            string Name = "";
            for (int i = 0; i < 3; i++)
            {               
                int len = r.Next(3, 10);
                int b = 0;
                while (b < len)
                {
                    if (r.Next(1, 3) < 2)
                        Name += b == 0 ? consonants[r.Next(consonants.Length)].ToUpper() : consonants[r.Next(consonants.Length)];
                    else
                        Name += b == 0 ? vowels[r.Next(vowels.Length)].ToUpper() : vowels[r.Next(vowels.Length)];
                    b++;
                }
                Name += i != 2 ? " " : string.Empty;
            }
            return NeedF ? "F" + Name.Substring(1, Name.Length - 1) : Name;
        }
        private static DateOnly GenerateDateOfBirth()
        {
            DateTime start = new DateTime(1980, 1, 1);
            int range = (DateTime.Today - start).Days;
            return DateOnly.FromDateTime(start.AddDays(r.Next(range)));
        }

    }
}
