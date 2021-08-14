using System.Text.RegularExpressions;

namespace ConsoleTestApplication
{
    public class Password
    {
        public bool CheckPassword(string password)
        {
            var match = Regex.Match(password, @"^((?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*\W).{8,})$");
            if (!match.Success)
            {
                return false;
            }
            return true;
        }
    }
}
