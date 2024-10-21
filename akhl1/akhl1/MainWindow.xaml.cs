using System;
using System.Windows;

namespace akhl1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Click_one(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            stack1.Visibility = stack1.Visibility == Visibility.Visible ? Visibility.Hidden : Visibility.Visible;
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            stack2.Visibility = stack2.Visibility == Visibility.Visible ? Visibility.Hidden : Visibility.Visible;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
          
            if (int.TryParse(plotnost1.Text, out int plotnost) &&
                int.TryParse(visota1.Text, out int visota) &&
                int.TryParse(radius1.Text, out int radius))
            {
             
                bool check21 = check2.IsChecked == true;
                bool check11 = check2.IsChecked == true;

                if (check11 || check21 == true)
                {
                    double volume = (1.0 / 3) * Math.PI * (radius * radius) * visota;
                    double mass = volume * plotnost;
                    text1.Text = $"V = {volume:F2} см³, M = {mass:F2} г";
                    stack2.Visibility = Visibility.Visible;
                }
                else
                {
                    MessageBox.Show("Пожалуйста, выберите хотя бы одну опцию.");
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректные числовые значения.");
            }
        }
    }
}
