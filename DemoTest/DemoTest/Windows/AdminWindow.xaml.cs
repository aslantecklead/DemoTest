using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

namespace DemoTest.Windows
{
    /// <summary>
    /// Логика взаимодействия для AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        public DemoTestEntities4 db = new DemoTestEntities4();

        public AdminWindow()
        {
            InitializeComponent();
            Loaded_data();
        }

        private void Loaded_data()
        {
            var backwater = db.Backwater.ToList();
            dgList.SelectedValuePath = "ID";
            dgList.ItemsSource = backwater;
            dgList.SelectionMode = DataGridSelectionMode.Single;


        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            //string fishName = BitConverter.ToString(MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(Fish_Name.Text)));
            Backwater backwater = new Backwater
            {
                Name = Fish_Name.Text,
                Fish_Name = Fish_Name.Text,
                Fish_Size = int.TryParse(Fish_Size.Text, out int fishSize) ? fishSize : 0,
                Date_Start = Start.SelectedDate ?? DateTime.Now,
                Date_End = End.SelectedDate ?? DateTime.Now,

            };
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
