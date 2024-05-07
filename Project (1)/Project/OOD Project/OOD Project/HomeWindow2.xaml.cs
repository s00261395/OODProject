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
using System.Windows.Shapes;

namespace OOD_Project
{
    /// <summary>
    /// Interaction logic for HomeWindow2.xaml
    /// </summary>
    public partial class HomeWindow2 : Window
    {
        public HomeWindow2()
        {
            InitializeComponent();
        }

        private void ButtonHome_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to Home interface (for example, Page1.xaml)
            MainWindow Home = new MainWindow();
            Home.Show();
            this.Close();

        }

        private void ButtonSearch_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to Search interface (for example, Page2.xaml)
            SearchWindow2 Home = new SearchWindow2();
            Home.Show();
            this.Close();
        }

        private void ButtonMap_Click(object sender, RoutedEventArgs e)
        {
            MapWindow Home = new MapWindow();
            Home.Show();
            this.Close();
        }
        private void ButtonFire_Click(object sender, RoutedEventArgs e)
        {
            FireWindow Home = new FireWindow();
            Home.Show();
            this.Close();
        }
    }
}
