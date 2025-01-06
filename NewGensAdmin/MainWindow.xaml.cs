using System.Windows;
using System.Windows.Controls;

namespace NewGensAdmin
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // Load General tab initially
            GeneralButton.Background = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 0, 123, 255));
            MainContentControl.Content = new General();
        }

        private void NavigationButton_Click(object sender, RoutedEventArgs e)
        {
            Button clickedButton = sender as Button;

            // Reset background for all buttons
            GeneralButton.Background = SettingsButton.Background = UsersButton.Background =
                new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 240, 240, 240));

            // Highlight the clicked button in blue
            clickedButton.Background = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 0, 123, 255));

            // Switch the content based on the clicked tab
            switch (clickedButton.Tag.ToString())
            {
                case "General":
                    MainContentControl.Content = new General();
                    break;
                case "Settings":
                    MainContentControl.Content = new Settings();
                    break;
                case "Users":
                    MainContentControl.Content = new Users();
                    break;
            }
        }

    }
}
