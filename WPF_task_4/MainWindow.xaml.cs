using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_task_4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            cities_cmbox.SelectedIndex = 0;
            List<string> azerbaijanCities = new List<string>
            {
                "Baku",
                "Ganja",
                "Sumqayit",
                "Lankaran",
                "Mingachevir",
                "Shaki",
                "Yevlakh",
                "Gabala",
                "Barda",
                "Agdash",
                "Sheki",
                "Nakhchivan (City)",
                "Khachmaz",
                "Shamakhi",
                "Quba"
            };
            cities_cmbox.ItemsSource = azerbaijanCities;

            listbox1.ItemsSource = Database.people;

        }

        private void Save_btn_Click(object sender, RoutedEventArgs e)
        {

            if (ad_txtbox.Text != "" && soyad_txtbox.Text != "" && (male_rb.IsChecked.Value == true || female_rb.IsChecked.Value == true) && cities_cmbox.Text != "")
            {
                string s;
                if (male_rb.IsChecked.Value == true)
                {
                    s = "Male";
                }
                else
                {
                    s = "Female";
                }

                bool c;
                if (step_chbox.IsChecked.Value == true)
                {
                    c = true;
                }
                else
                {
                    c = false;
                }

                Person person = new Person(ad_txtbox.Text, soyad_txtbox.Text, s, c, cities_cmbox.Text);
                Database.people.Add(person);
            }
            else
            {

            }
        }

        private void Delete_btn_Click(object sender, RoutedEventArgs e)
        {
            if (Database.people.Count > 0)
            {
                if (listbox1.SelectedIndex >= 0 && listbox1.SelectedIndex < Database.people.Count)
                {

                    Database.people.RemoveAt(listbox1.SelectedIndex);
                    listbox1.ItemsSource = null;
                    listbox1.ItemsSource = Database.people;
                }
            }

        }
    }
}