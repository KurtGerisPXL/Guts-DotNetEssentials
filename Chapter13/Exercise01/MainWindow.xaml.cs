using System.Windows;

namespace Exercise01
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ItemsListBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            while (itemsListBox.SelectedIndex != -1)
            {
                itemsListBox.Items.RemoveAt(itemsListBox.SelectedIndex);
            }
        }
    }
}
