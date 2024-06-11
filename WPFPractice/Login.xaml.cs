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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPFPractice
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        SignUpPage signUpPage;
        LoginPag loginPage;
        public Login()
        {
            InitializeComponent();
            demoname = "hello";
            signUpPage = new SignUpPage();
            MainGrid.Children.Add(signUpPage);
            signUpPage.SignInButtonClick += SignUpPage_SignInButtonClick;
            loginPage = new LoginPag();
            loginPage.SignUpButtonClick += LoginPag_SignUpButtonClick;
            loginPage.loginButtonClick += LoginPageloginButtonClick;
            MainGrid.Children.Add(loginPage);
            Panel.SetZIndex(signUpPage, 1);
            //Panel.SetZIndex(moveingAnimationContainer, 1);
            moveingAnimationContainer.AnimationFinish += MoveingAnimationContainerAnimationFinish;
        }

        private void LoginPageloginButtonClick(object sender, EventArgs e)
        {
            Hide();
            ShowInTaskbar = false;
        }

        private void MoveingAnimationContainerAnimationFinish(object sender, bool e)
        {
            DoubleAnimation animation = new DoubleAnimation
            {
                From = 0.3,      // Starting opacity
                To = 1,        // Ending opacity
                Duration = TimeSpan.FromSeconds(1.5),
                EasingFunction = new QuadraticEase()
            };
            if (moveingAnimationContainer.Animation)
            {
                Panel.SetZIndex(signUpPage, 1);
                signUpPage.BeginAnimation(OpacityProperty, animation);
            }
            else
            {
                Panel.SetZIndex(loginPage, 1);  
                loginPage.BeginAnimation(OpacityProperty, animation);
            }
        }

        private void SignUpPage_SignInButtonClick(object sender, EventArgs e)
        {
            Panel.SetZIndex(moveingAnimationContainer, 1);
            Panel.SetZIndex(signUpPage, 0);
            moveingAnimationContainer.Animation =false;
        }

        private void LoginPag_SignUpButtonClick(object sender, EventArgs e)
        {
            Panel.SetZIndex(moveingAnimationContainer, 1);
            Panel.SetZIndex(loginPage, 0);
            moveingAnimationContainer.Animation = true; 
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
