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
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPag : UserControl
    {
        public event EventHandler SignUpButtonClick;
        public LoginPag()
        {
            InitializeComponent();
          
        }
        private void PasswordBorderMouseDown(object sender, MouseButtonEventArgs e)
        {
            PasswordTextBox.Focus();
        }

        private void EmailBorderMouseDown(object sender, MouseButtonEventArgs e)
        {
            EmailTextBox.Focus();
        }

        private void Button_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Ex(object sender, MouseButtonEventArgs e)
        {

        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void EmailTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            emailPlaceHolderLabel.Visibility = Visibility.Hidden;
        }

        private void PasswordTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            passPlaceHolderLabel.Visibility = Visibility.Hidden;
        }

        private void PasswordTextBox_LostFocus(object sender, RoutedEventArgs e)
        {

            if (string.IsNullOrEmpty(PasswordTextBox.Password))
            {
                passPlaceHolderLabel.Visibility = Visibility.Visible;
            }

        }
        private void Border_MouseEnter(object sender, MouseEventArgs e)
        {

        }

        private void SignInBtnClick(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(EmailTextBox.Text) && !string.IsNullOrEmpty(PasswordTextBox.Password))
            {
                MessageBox.Show("Sign Successful");
            }
            else
            {
                MessageBox.Show("Fill Details");
                EmailTextBox.Clear();
                PasswordTextBox.Clear();
            }
        }

        private void EmailTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(EmailTextBox.Text))
            {
                emailPlaceHolderLabel.Visibility = Visibility.Visible;
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SignUpButtonClick?.Invoke(sender, e);
        }

        private void CloseBtnClick(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
