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
using System.Text.RegularExpressions;
using Microsoft.Win32;
using System.IO;

namespace akhl
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string inputText = textbox1.Text;

            if (IsRussianText(inputText))
            {
                MessageBox.Show("На русском ", "title", MessageBoxButton.OK, MessageBoxImage.Question);

            }
            else MessageBox.Show("Не на русском ", "title", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private static bool IsRussianText(string text)
        {
            // Регулярное выражение для проверки наличия русских букв
            Regex regex = new Regex(@"^[а-яА-ЯёЁ\s]+$");
            return regex.IsMatch(text);
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string b = textbox2.Text;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "txt files ( *txt)/*.txt|all files (*.*)/*.*";
            if (saveFileDialog.ShowDialog() == true)
            {
                string FilePath = saveFileDialog.FileName;
                using (StreamWriter writer = new StreamWriter(FilePath))
                {
                    writer.Write(b);
                }
            }
        }
        

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();

            if (op.ShowDialog() == true)
            {
                img.Source = new BitmapImage(new Uri(op.FileName));
            }

        }
    }
}
