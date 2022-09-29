using System;
using System.Collections.Generic;
using System.Text;
using WindowSama.Core;

namespace WindowAuthorization.Core
{
    internal class UserValidator
    {
        public User CurrentUser { get; set; }
        public  bool Validate(User user, string login, string password)
        {

            if (user.Login == login && user.Password == password)
            {
                return true;
            }
            return false;
        }
        public int ValidateRole(User user)
        {
            if (user.Role == "Client")
                return 1;
            else if (user.Role == "Admin")
                return 2;
            else if (user.Role == "Manager")
                return 3;
            else return 0;
        }
        public  bool ValidateLoginAndPassword(List<User> userList, string login, string password)
        {
            foreach (var user in userList)
            {
                if (Validate (user, login, password ))
                {
                    CurrentUser = user;
                    return true;
                }
            }
            return false;
        }
    }
}
