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

namespace WPFPractice
{
    /// <summary>
    /// Interaction logic for EventPractice.xaml
    /// </summary>
    public partial class EventPractice : Window
    {
        public EventPractice()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine();
        }

        private void BorderFive(object sender, MouseButtonEventArgs e)
        {
            Console.WriteLine("BorderFiveMouseDown");
        }

        private void BorderThree(object sender, MouseButtonEventArgs e)
        {
            Console.WriteLine("BorderThreeMouseDown");
        }

        private void BorderFour(object sender, MouseButtonEventArgs e)
        {
            Console.WriteLine("BorderFourMouseDown");
        }

        private void BorderTwo(object sender, MouseButtonEventArgs e)
        {
            Console.WriteLine("BorderTwoMouseDown");
        }

        private void BorderOne(object sender, MouseButtonEventArgs e)
        {
            Console.WriteLine("BorderOneMouseDown");
        }

        private void ButtonMouseDown(object sender, MouseButtonEventArgs e)
        {
            Console.WriteLine("ButtonMouseDown");
        }

        private void TextBox_MouseEnter(object sender, MouseEventArgs e)
        {

        }

        private void Border_MouseEnter(object sender, MouseEventArgs e)
        {

        }

        private void Border_MouseEnter_1(object sender, MouseEventArgs e)
        {

        }

        private void Border_MouseEnter_2(object sender, MouseEventArgs e)
        {

        }

        private void Border_MouseEnter_3(object sender, MouseEventArgs e)
        {

        }

        private void Border_MouseEnter_4(object sender, MouseEventArgs e)
        {

        }
    }
}
