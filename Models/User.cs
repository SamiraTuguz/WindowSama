using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowSama.Core
{
    class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime BornDate { get; set; }
        public Decimal Salary { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        public User()
        {
            Id = 1;
            FirstName = string.Empty;
            MiddleName = string.Empty;
            LastName = string.Empty;
            BornDate = default;
            Salary = 0;
            Login = string.Empty;
            Password = string.Empty;
            Role = string.Empty;
        }
        public User(int id, string firstName, string middleName, string lastName, DateTime bornDate, decimal salary, string login, string password, string role)
        {
            Id = id;
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            BornDate = bornDate;
            Salary = salary;
            Login = login;
            Password = password;
            Role = role;
        }

        public override string ToString()
        {
            return $"{Id} {FirstName} {MiddleName} {LastName} {BornDate} {Salary} {Login} {Password} {Role}";
        }
    }
}
