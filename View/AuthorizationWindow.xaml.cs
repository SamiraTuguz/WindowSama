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
        public static List<User> userList; 
        public AuthorizationWindow()
        {
            InitializeComponent();
            userList = UserParser.Parse("users3.txt").ToList();
        }

        private void btnSignIn_Click(object sender, RoutedEventArgs e)
        {
            UserValidator userValidator = new UserValidator();
            if (userValidator.ValidateLoginAndPassword(userList, tbLogin.Text, tbPassword.Text))
            {
                new DashboardWindow().Show();
                Close();
            }

            else MessageBox.Show("Неверный логин или пароль");
        }
    }
}
