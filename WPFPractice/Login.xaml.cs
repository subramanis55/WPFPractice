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
            SignUpPage signUpPage = new SignUpPage();
            MainGrid.Children.Add(signUpPage);
            signUpPage.SignInButtonClick += SignUpPage_SignInButtonClick;

        }

        private void SignUpPage_SignInButtonClick(object sender, EventArgs e)
        {
            MainGrid.Children.Clear();
            LoginPag loginPag = new LoginPag();
            loginPag.SignUpButtonClick += LoginPag_SignUpButtonClick
                ;
            MainGrid.Children.Add(loginPag);
        }

        private void LoginPag_SignUpButtonClick(object sender, EventArgs e)
        {

            MainGrid.Children.Clear();
            SignUpPage signUpPage = new SignUpPage();
            MainGrid.Children.Add(signUpPage);
            signUpPage.SignInButtonClick += SignUpPage_SignInButtonClick;
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
