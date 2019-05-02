using System;
using System.Collections.Generic;
using System.Windows;

namespace Exercise07
{
    public partial class MainWindow : Window
    {

        private List<string> _months;

        public MainWindow()
        {
            InitializeComponent();
            _months = new List<string>() { "January", "February", "March", "April",
                                           "May", "June", "Juli", "August",
                                           "September", "October", "November", "December"};
        }

        private void LookupButton_Click(object sender, RoutedEventArgs e)
        {
            int monthNumber = Convert.ToInt32(monthNumberTextBox.Text);
            monthNameTextBox.Text = _months[monthNumber - 1];
        }
    }
}