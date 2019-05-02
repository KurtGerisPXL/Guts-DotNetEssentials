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

namespace Exercise08
{
    /// <summary>
    /// Interaction logic for PersonDetails.xaml
    /// </summary>
    public partial class PersonDetails : Window
    {
        public PersonDetails(Person selectedPerson)
        {
            InitializeComponent();
            personNameTextBox.Text = selectedPerson.Name;
            personFirstNameTextBox.Text = selectedPerson.FirstName;
            personGenderTextBox.Text = selectedPerson.Gender;
            personAddressTextBox.Text = selectedPerson.Address;
            personTelephoneNumberTextBox.Text = selectedPerson.TelephoneNumber;
            personBirthDateTextBox.Text = selectedPerson.BirthDate.ToString("d");
        }
    }
}
