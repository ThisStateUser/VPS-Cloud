using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using VPS_Cloud.Views.Client;

namespace VPS_Cloud.Views
{
    /// <summary>
    /// Логика взаимодействия для AuthPG.xaml
    /// </summary>
    public partial class AuthPG : Page
    {
        public AuthPG()
        {
            InitializeComponent();
        }

        private void GoRegForm_Click(object sender, RoutedEventArgs e)
        {
            RegFormBtn.Visibility = Visibility.Visible;
            AuthFormBtn.Visibility = Visibility.Collapsed;
            RegForm.Visibility = Visibility.Visible;
            BlockTitle.Text = "Регистрация";
        }

        private void GoAuth_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.WindowGs.AuthFrame();
            NavigationService.Navigate(new PersonAccountPG());
        }

        private void GoAuthForm_Click(object sender, RoutedEventArgs e)
        {
            RegFormBtn.Visibility = Visibility.Collapsed;
            AuthFormBtn.Visibility = Visibility.Visible;
            RegForm.Visibility = Visibility.Collapsed;
            BlockTitle.Text = "Вход";
        }

        private void GoRegAndAuth_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CHomePG());
        }
    }
}
