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
using pr3dataset.prakta3DataSetTableAdapters;
namespace pr3dataset
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ProjectsTableAdapter company = new ProjectsTableAdapter();
        public MainWindow()
        {
            InitializeComponent();
            Company.ItemsSource = company.GetData();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Company.Columns[0].Visibility = Visibility.Collapsed;
            Company.Columns[3].Visibility = Visibility.Collapsed;
            Company.Columns[7].Visibility = Visibility.Collapsed;


            Company.Columns[1].Header = "Компания";
            Company.Columns[2].Header = "Город";
            Company.Columns[4].Header = "Имя";
            Company.Columns[5].Header = "Фамилия";
            Company.Columns[6].Header = "Должность";
            Company.Columns[8].Header = "Названия проекта";
            Company.Columns[9].Header = "Дата начала";
            Company.Columns[10].Header = "Дата окончания";
        }
    }
}
