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
    /// Interaction logic for SignInPage.xaml
    /// </summary>
    public partial class SignUpPage : UserControl
    {
        public event EventHandler SignInButtonClick;
        public SignUpPage()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SignInButtonClick?.Invoke(this, EventArgs.Empty);
        }

        private void ConfirmBorderMouseDown(object sender, MouseButtonEventArgs e)
        {
            ConfirmPasswordBox.Focus();
        }

        private void NewPasswordBorderMouseDown(object sender, MouseButtonEventArgs e)
        {
            NewPasswordBox.Focus();
        }

        private void EmailBorderMouseDown(object sender, MouseButtonEventArgs e)
        {
            EmailTextBox.Focus();   
        }

        private void PasswordBox_GotFocus(object sender, RoutedEventArgs e)
        {
            EmailTextBoxPlaceholder.Visibility = Visibility.Hidden;
        }

        private void NewPasswordBoxGotFocus(object sender, RoutedEventArgs e)
        {
            NewPasswordBoxPlaceholder.Visibility = Visibility.Hidden;
        }

        private void NewPasswordLostFocus(object sender, RoutedEventArgs e)
        {
        }

        private void ConfirmPasswordLostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(ConfirmPasswordBox.Password))
            {
                ConfirmPasswordBoxPlaceholder.Visibility = Visibility.Visible;
            }
        }

        private void ConfirmPasswordGotFocus(object sender, RoutedEventArgs e)
        {
            ConfirmPasswordBoxPlaceholder.Visibility= Visibility.Hidden;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void EmailTextBoxLostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(EmailTextBox.Text))
            {
                EmailTextBoxPlaceholder.Visibility = Visibility.Visible;
            }
           
        }

        private void EmailTextBoxGotFocus(object sender, RoutedEventArgs e)
        {
            EmailTextBoxPlaceholder.Visibility= Visibility.Hidden;
        }

        private void NewPasswordBoxLostFocus(object sender, RoutedEventArgs e)
        {

            if (string.IsNullOrEmpty(NewPasswordBox.Password))
            {
                NewPasswordBoxPlaceholder.Visibility = Visibility.Visible;
            }
        }

        private void CloseBtnClick(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
