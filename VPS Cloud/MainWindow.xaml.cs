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
using VPS_Cloud.Views;

namespace VPS_Cloud
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static MainWindow WindowGs { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            WindowGs = this;
            MainFrame.Content = new AuthPG();
        }

        public void AuthFrame()
        {
            MainFrame.SetValue(Grid.ColumnProperty, 1);
            NavigationZone.Visibility = Visibility.Visible;
        }
    }
}
