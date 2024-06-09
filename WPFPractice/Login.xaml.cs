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
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
            demoname = "hello";



        }

        private void Border_MouseEnter(object sender, MouseEventArgs e)
        {

        }

        private void SignInBtnClick(object sender, RoutedEventArgs e)
        {
            if(!string.IsNullOrEmpty(EmailTextBox.Text)&& !string.IsNullOrEmpty(PasswordTextBox.Password)) {
                MessageBox.Show("Sign Successful");
            }
            else{
                MessageBox.Show("Fill Details");
                EmailTextBox.Clear();
                PasswordTextBox.Clear();
            }
        }



        public string demoname
        {
            get { return (string)GetValue(demonameProperty); }
            set { SetValue(demonameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for demoname.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty demonameProperty =
            DependencyProperty.Register("demoname", typeof(string), typeof(Login), new FrameworkPropertyMetadata(default(string),FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));


    }
}
