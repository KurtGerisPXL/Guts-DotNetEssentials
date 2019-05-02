using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Exercise09
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            colorsComboBox.SelectedIndex = 0;
        }

        private void ColorsComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (colorsComboBox.SelectedIndex == 0)
            {
                colorLabel.Background = new SolidColorBrush(Colors.Red);
            }
            else if (colorsComboBox.SelectedIndex == 1)
            {
                colorLabel.Background = new SolidColorBrush(Colors.Green);
            }
            else
            {
                colorLabel.Background = new SolidColorBrush(Colors.Blue);
            }
        }
    }
}