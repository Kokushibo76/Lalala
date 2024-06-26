using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
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

namespace Emias
{
    public partial class PriemPage : Window
    {
        public PriemPage()
        {
            InitializeComponent();

            var doctors = new List<Doctor>
            {
                new Doctor { Name = "Иванов Ивар Иванович", Address = "Москва, Профсоюзная улица, д. 111A" },
                new Doctor { Name = "Смирнов Сергей Петрович", Address = "Москва, Каширское ш., д. 62" },
                new Doctor { Name = "Петров Алексей Андреевич", Address = "Москва, Тверская улица, д. 5" },
                new Doctor { Name = "Кузнецов Михаил Иванович", Address = "Москва, Ленина проспект, д. 14" },
                new Doctor { Name = "Соколов Дмитрий Николаевич", Address = "Москва, Новая улица, д. 7" }
            };

            DataContext = new
            {
                Doctors = doctors
            };
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
