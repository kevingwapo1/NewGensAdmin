using System.Windows;
using System.Windows.Controls;

namespace NewGensAdmin
{
    public partial class Settings : UserControl
    {
        private bool isNotificationOn = false;

        public Settings()
        {
            InitializeComponent();

            // Attach event handlers for the toggle button
            NotificationToggle.Checked += ToggleButton_Checked;
            NotificationToggle.Unchecked += ToggleButton_Unchecked;
        }

        private void ToggleButton_Checked(object sender, RoutedEventArgs e)
        {
            isNotificationOn = true;
        }

        private void ToggleButton_Unchecked(object sender, RoutedEventArgs e)
        {
            isNotificationOn = false;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            // Display a message based on the toggle state
            if (isNotificationOn)
            {
                MessageBox.Show("Notifications are ON.");
            }
            else
            {
                MessageBox.Show("Notifications are OFF.");
            }
        }
    }
}
