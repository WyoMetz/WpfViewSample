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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfViewSample.Classes;

namespace WpfViewSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Person people = new Person();
        Person Person = new Person();
        public MainWindow()
        {
            InitializeComponent();
            ListViewTemplate.ItemsSource = people.GetPeople();
            ListViewNoTemplate.ItemsSource = people.GetPeople();
            DataGridView.ItemsSource = people.GetPeople();
            ComboxView.ItemsSource = people.GetPeople();
        }

        private void ListViewTemplate_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Person = (Person)ListViewTemplate.SelectedItem;
            ShowPerson();
        }

        private void ListViewNoTemplate_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Person = (Person)ListViewNoTemplate.SelectedItem;
            ShowPerson();
        }

        private void DataGridView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Person = (Person)DataGridView.SelectedItem;
            ShowPerson();
        }

        private void ComboxView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Person = (Person)ComboxView.SelectedItem;
            ShowPerson();
        }

        //Accessing the selected Item
        private void ShowPerson()
        {
            FirstNameText.Text = Person.FirstName;
            LastNameText.Text = Person.LastName;
            AddressText.Text = Person.Address;
            NumberText.Text = Person.Number.ToString();
        }
    }
}
