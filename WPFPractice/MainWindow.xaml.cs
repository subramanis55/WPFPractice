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

namespace WPFPractice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void textEmailMouseDown(object sender, MouseButtonEventArgs e)
        {
            txtEmail.Focus();
        }

        private void txtEmailTextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEmail.Text) && txtEmail.Text.Length > 0)
            {
                txtEmail.Visibility = Visibility.Collapsed;
            }
            else
            {
               txtEmail.Visibility = Visibility.Visible;
            }
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEmail.Text) && !string.IsNullOrEmpty(txtPassword.Password))
            {
                MessageBox.Show("Sign Successful");
            }
        }

        private void txtPassword_PasswordChanged(object sender, RoutedEventArgs e)
        {

            if (!string.IsNullOrEmpty(txtPassword.Password) && txtPassword.Password.Length > 0)
            {
                txtPassword.Visibility = Visibility.Collapsed;
            }
            else
            {
                txtPassword.Visibility = Visibility.Visible;
            }
        }

        private void textPasswordDown(object sender, MouseButtonEventArgs e)
        {
            txtPassword.Focus();
        }
    }
}
