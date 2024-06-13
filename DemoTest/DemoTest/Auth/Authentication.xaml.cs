using DemoTest.Windows;
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
using static System.Net.Mime.MediaTypeNames;

namespace DemoTest.Auth
{
    /// <summary>
    /// Логика взаимодействия для Authentication.xaml
    /// </summary>
    public partial class Authentication : Window
    {
        public DemoTestEntities4 db = new DemoTestEntities4();
        public Authentication()
        {
            InitializeComponent();
            Load_Data();
        }

        private void Load_Data()
        {
            var backWater = db.Beholder_Employee.ToList();
        }

        private void Authenticate_Click(object sender, RoutedEventArgs e)
        {
            var emp = db.Beholder_Employee.ToList();
            emp = emp.Where(x => x.Login == Login.Text && x.Password == Password.Text && x.ID_Employee == 1).ToList();
            if (emp.Count > 0)
            {
                AdminWindow adminWindow = new AdminWindow();
                adminWindow.Show();
                Close();
            }
            else
            {
                var empl = db.Beholder_Employee.ToList();
                empl = empl.Where(x => x.Login == Login.Text && x.Password == Password.Text && x.ID_Employee == 2).ToList();
                if (empl.Count > 0)
                {
                    EmployeeWindow employeeWindow = new EmployeeWindow();
                    employeeWindow.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль", "Ошибка аутентификации", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}
