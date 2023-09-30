using PTMKTestTask.DAL.Context;
using PTMKTestTask.DAL.Entities.Base;

namespace PTMKTestTask.DAL.Entities
{
    public class User : Entity
    {
        public User()
        {
            
        }

        public User(string Fullname, DateOnly DateOfBirth, char Gender)
        {
            this.FullName = Fullname;
            this.DateOfBirth = DateOfBirth;
            this.Gender = Gender;
            if (Gender == 'm' & Fullname.StartsWith("F"))
                IsConditions = true;
            else
                IsConditions = false;
        }


        public string FullName { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public char Gender { get; set; }
        public bool IsConditions { get; set; } 

        public int GetAge()
        {
            DateTime today = DateTime.Today;
            int months = today.Month - DateOfBirth.Month;
            int years = today.Year - DateOfBirth.Year;
            if (today.Day < DateOfBirth.Day)
            {
                months--;
            }
            if (months < 0)
            {
                years--;
            }
            return years;
        }
        public void Save()
        {
            PTMKTestTaskDB db = new PTMKTestTaskDB();
            db.Users.Add(this);
            db.SaveChanges();
        }
        public static void SaveRange(List<User> Users)
        {
            PTMKTestTaskDB db = new PTMKTestTaskDB();
            db.Users.AddRange(Users);
            db.SaveChanges();
        }
        public string MaleOrFemale() => Gender == 'm' ? "Male" : "Female";
        public void Print() => Console.WriteLine($"{FullName} {DateOfBirth} {MaleOrFemale()} {GetAge()}");


    }
}
