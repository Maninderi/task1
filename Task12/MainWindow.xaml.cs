using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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

namespace Task12
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.Background = Brushes.White;
        }

        private void ChangeBG_Click(object sender, RoutedEventArgs e)
        {
                this.Background = new SolidColorBrush(Colors.Green);            
        }

        private void About_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Разработчик: Рыбалка Женя");
            StatusText.Text = "Информация о разработчике";
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Void_MouseLeave(object sender, RoutedEventArgs e)
        {
            StatusText.Text = "Готово";
        }
        private void Void_MouseEnter(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                StatusText.Text = button.Content.ToString();
            }
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
