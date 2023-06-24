using System.Windows;

namespace Framwork_Pages_Test
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void GoToPage2_Click(object sender, RoutedEventArgs e)
        {
            page1.Visibility = Visibility.Hidden;
            page2.Visibility = Visibility.Visible;
        }

        private void GoToPage1_Click(object sender, RoutedEventArgs e)
        {
            page2.Visibility = Visibility.Hidden;
            page1.Visibility = Visibility.Visible;
        }
    }
}
