using System.Windows;

namespace Framework_Pages_Test
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddNewPincode(object sender, RoutedEventArgs e)
        {
            pincodeStartPage.Visibility = Visibility.Hidden;
            enterNewPinPage.Visibility = Visibility.Visible;
        }

        private void BackToBeginning(object sender, RoutedEventArgs e)
        {
            enterNewPinPage.Visibility = Visibility.Hidden;
            pincodeStartPage.Visibility = Visibility.Visible;
        }
    }
}
