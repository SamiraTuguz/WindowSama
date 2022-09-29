using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WindowAuthorization.Core;
using WindowSama.Core;
using WindowSama.View;

namespace WindowAuthorization.View
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationWindow.xaml
    /// </summary>
    public partial class AuthorizationWindow : Window
    {
        private List<User> _userList; 
        public AuthorizationWindow()
        {
            InitializeComponent();
            _userList = UserParser.Parse("users3.txt").ToList();
        }

        private void btnSignIn_Click(object sender, RoutedEventArgs e)
        {
            UserValidator userValidator = new UserValidator();
            if (userValidator.ValidateLoginAndPassword(_userList, tbLogin.Text, tbPassword.Text))
            {
                if (userValidator.ValidateRole(userValidator.CurrentUser) == 1)
                    new ClientWindow().Show();
                else if (userValidator.ValidateRole(userValidator.CurrentUser) == 2)
                    new AdminWindow().Show();
                else if (userValidator.ValidateRole(userValidator.CurrentUser) == 3)
                    new ManagerWindow().Show();
                else if (userValidator.ValidateRole(userValidator.CurrentUser) == 0)
                    MessageBox.Show("Ошибка");
            }

            else MessageBox.Show("Неверный логин или пароль");
        }
    }
}
