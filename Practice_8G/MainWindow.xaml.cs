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

namespace Practice_8G
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CompareLastName_Click(object sender, RoutedEventArgs e)
        {
            Son firstWorker = new Son(NameW1.Text, PatronymicW1.Text);
            Son secondWorker = new Son(NameW2.Text, PatronymicW2.Text);

            int answer = firstWorker.CompareTo(secondWorker);
            if (answer == 1) result.Text = "Отчества совпадают";
            if (answer == -1) result.Text = "Отчества различны";
        }

        private void GetInfo_Click(object sender, RoutedEventArgs e)
        {
            Son father = new Son(NameW1.Text, PatronymicW1.Text);
            result.Text = father.ShowName();
        }

        private void GetSonInfo_Click(object sender, RoutedEventArgs e)
        {
            Son son = new Son(NameW2.Text, PatronymicW2.Text);
            result.Text = son.ShowNamePatronymic();
        }

        private void Information_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Дроздов Г.", "Разработчик", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
