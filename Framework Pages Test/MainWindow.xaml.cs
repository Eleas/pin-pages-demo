using System.Windows;

namespace Framework_Pages_Test
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ModifyPincode_Click(object sender, RoutedEventArgs e)
        {
            pincodeStartPage.Visibility = Visibility.Hidden;
            enterNewPinPage.Visibility = Visibility.Visible;
        }

        private void BackToBeginning_Click(object sender, RoutedEventArgs e)
        {
            enterNewPinPage.Visibility = Visibility.Hidden;
            pincodeStartPage.Visibility = Visibility.Visible;
        }

        private void ClosePinHandlingWindow_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
