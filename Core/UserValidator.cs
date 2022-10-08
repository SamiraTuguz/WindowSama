using System;
using System.Collections.Generic;
using System.Text;
using WindowSama.Core;

namespace WindowAuthorization.Core
{
    internal class UserValidator
    {
        public  bool Validate(User user, string login, string password)
        {

            if (user.Login == login && user.Password == password)
            {
                return true;
            }
            return false;
        }
        public bool ValidateLoginAndPassword(List<User> userList, string login, string password)
        {
            foreach (var user in userList)
            {
                if (Validate (user, login, password ))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
