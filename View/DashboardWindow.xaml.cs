using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WindowSama.View;

namespace WindowAuthorization.View
{
    /// <summary>
    /// Логика взаимодействия для DashboardWindow.xaml
    /// </summary>
    public partial class DashboardWindow : Window
    {
        public DashboardWindow()
        {
            InitializeComponent();
        }

        private void btnUsersPage_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new UsersPage());
        }

        private void btnManagerPage_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new Page1());
        }

        private void btnAdminPage_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new Page2());
        }
    }
}
