using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Exercise08
{
    public partial class MainWindow : Window
    {
        private List<Person> _people;

        public MainWindow()
        {
            InitializeComponent();
            _people = new List<Person>() { new Person() { Name = "Geris", FirstName = "Kurt", Gender = "Male",
                                                          Address = "Huisveldstraat 4", TelephoneNumber = "0471890125",
                                                          BirthDate = new System.DateTime(1999, 11, 17)
                                                        },
                                           new Person() { Name = "PersonName2", FirstName = "PersonFirstName2", Gender = "PersonGender2",
                                                          Address = "PersonAddress2", TelephoneNumber = "PersonTelephoneNumber2",
                                                          BirthDate = new System.DateTime(2018, 5, 11)
                                                        },
                                           new Person() { Name = "PersonName3", FirstName = "PersonFirstName3", Gender = "PersonGender3",
                                                          Address = "PersonAddress3", TelephoneNumber = "PersonTelephoneNumber3",
                                                          BirthDate = new System.DateTime(1995, 9, 20)
                                                        }
                                         };

            personsListBox.ItemsSource = _people;
        }

        private void PersonsListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            int selectedIndex = personsListBox.SelectedIndex;
            Person selectedPerson = (Person)personsListBox.Items[selectedIndex];
            PersonDetails personDetails = new PersonDetails(selectedPerson);
            personDetails.ShowDialog();
        }
    }
}