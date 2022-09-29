using System;
using System.Collections.Generic;
using System.Text;

namespace WindowAuthorization.Core
{
    internal class UserValidator
    {
        public static bool Validate(string login, string password)
        {
            if(login == "sama" && password == "samasama")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
