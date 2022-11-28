using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    public class Membership
    {
        public const string cons1="Username must be provided";
        public const string cons2="Email must be provided";
        public const string cons3="Password must be provided";
        public static string Validate(string username, string email, string password)
        {
            if (string.IsNullOrWhiteSpace(username))
                return cons1;
            if (string.IsNullOrWhiteSpace(email))
                return cons2;
            if (string.IsNullOrWhiteSpace(password))
                return cons3;

            return string.Empty;
        }
    }
}
