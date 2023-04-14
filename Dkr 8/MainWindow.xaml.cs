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

namespace Dkr_8
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string[] Geometry = {"Квадрат","Прямоугольник","Треугольник", "Параллелограмм" };
        public MainWindow()
        {
            InitializeComponent();
            GeometryComboBox.ItemsSource = Geometry;
        }

        public double Square(double a)
        {
            return a * a;
        }
        public double rectangle(double a,double b)
        {
            return a * b;
        }
        public double triangle(double a,double h) 
        {
            return (a * h);
        }
        public double Parallelogram(double a, double h)
        {
            return (a * h) / 2;
        }

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
           
            try
            {
                DragMove();
            }
            catch (Exception ex) { }
        }
        private void closeApp(object sender, MouseButtonEventArgs e)//Метод для закрытия окна
        {

            try
            {
                Close();
            }
            catch (Exception ex) { }
        }

        private void RollUp(object sender, MouseButtonEventArgs e)//метод для сворачивания окна
        {
            try
            {
                this.WindowState = WindowState.Minimized;
            }
            catch (Exception ex) { }
        }
        int ChangeIndex = 0;
       
       

        private void ChangeVol(object sender, SelectionChangedEventArgs e)
        {
            ChangeIndex = GeometryComboBox.SelectedIndex;
            switch(ChangeIndex)
            {
                case 0:
                    nameBH.Visibility = Visibility.Hidden;
                    nameA.Margin = new Thickness(286, 144,0,0);
                    labelA.Margin = new Thickness(300, 109, 253, 153);
                    labelBH.Visibility = Visibility.Hidden;
                    break;
                case 1:
                    nameBH.Visibility = Visibility.Visible;
                    nameA.Margin = new Thickness(156, 144, 0, 0);
                    nameBH.Margin = new Thickness(422, 144, 0, 0);
                    labelA.Margin = new Thickness(170, 113, 383, 149);
                    labelBH.Margin = new Thickness(431, 113, 103, 149);
                    labelBH.Visibility = Visibility.Visible;

                    break;
                case 2:
                    nameBH.Visibility = Visibility.Visible;
                    nameA.Margin = new Thickness(156, 144, 0, 0);
                    nameBH.Margin = new Thickness(422, 144, 0, 0);
                    labelA.Margin = new Thickness(170, 113, 383, 149);
                    labelBH.Margin = new Thickness(431, 113, 103, 149);
                    labelBH.Visibility = Visibility.Visible;
                    labelBH.Content = "Высота H";
                    break;
                case 3:
                    nameBH.Visibility = Visibility.Visible;
                    nameA.Margin = new Thickness(156, 144, 0, 0);
                    nameBH.Margin = new Thickness(422, 144, 0, 0);
                    labelA.Margin = new Thickness(170, 113, 383, 149);
                    labelBH.Margin = new Thickness(431, 113, 103, 149);
                    labelBH.Visibility = Visibility.Visible;
                    labelBH.Content = "Высота H";
                    break;
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            double a = 0;
            double bh = 0;
            if (nameA.Text.Length > 0 & nameA.Text.All(char.IsDigit) )
            {
                switch (ChangeIndex)
                {
                    case 0:
                        a = Convert.ToInt32(nameA.Text);
                        Result.Content += Square(a).ToString();
                        break;
                    case 1:
                        nameBH.Visibility = Visibility.Visible;
                        a = Convert.ToInt32(nameA.Text);
                        bh = Convert.ToInt32(nameBH.Text);
                        Result.Content += rectangle(a, bh).ToString();
                        break;
                    case 2:
                        nameBH.Visibility = Visibility.Visible;
                        a = Convert.ToInt32(nameA.Text);
                        bh = Convert.ToInt32(nameBH.Text);
                        Result.Content += triangle(a, bh).ToString();
                        break;
                    case 3:
                        nameBH.Visibility = Visibility.Visible;
                        a = Convert.ToInt32(nameA.Text);
                        bh = Convert.ToInt32(nameBH.Text);
                        Result.Content += Parallelogram(a, bh).ToString();
                        break;
                }
            }
        }
    }
}
