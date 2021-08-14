using System.Text.RegularExpressions;

namespace ConsoleTestApplication
{
    public class PasswordClass
    {
        public string MyPassword { get; set; }
        public bool CheckPassword()
        {
            var match = Regex.Match(MyPassword, @"^((?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*\W).{8,})$");
            if (!match.Success)
            {
                return false;
            }
            return true;
        }
    }
}
