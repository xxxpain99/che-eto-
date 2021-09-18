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

namespace WpfApp10
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadGroupList();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            int groupNumber = int.Parse (TextBoxGroup.Text);
           
            //sozdat podklyuchenie k BD
            db.base10Entities connection = new db.base10Entities();
           db.Класс isExists = connection.Класс.Where(g => g.Номер == groupNumber).FirstOrDefault();
            if(isExists !=null)
            {
                MessageBox.Show("Класс c таким номером уже существует");
                return;
            }
            db.Класс group = new db.Класс();
            group.Номер= groupNumber;
            connection.Класс.Add(group);

           
            int result = connection.SaveChanges();
            if (result == 1)
            {
                TextBoxGroup.Text = "";
                MessageBox.Show("Класс успешно создан");
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void LoadGroupList()
        {
            db.base10Entities connection = new db.base10Entities();
            var groupList = connection.Класс.ToList();
            
            foreach (var group in groupList)
            {
                ComboBoxGroup.Items.Add(group.Номер);
            }


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (ComboBoxGroup.SelectedIndex == -1)
            {

            }
           int g = (int)ComboBoxGroup.SelectedItem;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            this.Close();
           MainWindow frm = new MainWindow();
            frm.Show();
        }
    }
}
