using System;
using System.Collections.Generic;
using System.Globalization;
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
using WPFPractice.Manager;

namespace WPFPractice
{

    /// <summary>
    /// Interaction logic for EmployeeCard.xaml
    /// </summary>
    public partial class EmployeeCard : UserControl
    {

        public static readonly DependencyProperty ProfileImageSourceProperty = DependencyProperty.Register("ProfileImage", typeof(ImageSource), typeof(EmployeeCard));
        public static readonly DependencyProperty EmployeeNameProperty = DependencyProperty.Register("EmployeeName", typeof(string), typeof(EmployeeCard), new PropertyMetadata("Employee Name"));
        public static readonly DependencyProperty AgeGenderProperty = DependencyProperty.Register("EmployeeAgeAndGender", typeof(string), typeof(EmployeeCard), new PropertyMetadata("20 Years,Male"));
        public static readonly DependencyProperty PhoneNoProperty = DependencyProperty.Register("PhoneNumber", typeof(string), typeof(EmployeeCard), new PropertyMetadata("+91 9876543210"));
        public static readonly DependencyProperty EmailProperty = DependencyProperty.Register("EmployeeEmail", typeof(string), typeof(EmployeeCard), new PropertyMetadata("Abc@gmail.com"));
        public static readonly DependencyProperty EmployeeRoleProperty = DependencyProperty.Register("EmployeeRole", typeof(Role), typeof(EmployeeCard), new PropertyMetadata(Role.Manager));
        public static readonly DependencyProperty EmployeeRoleBackgroundColorProperty = DependencyProperty.Register("EmployeeRoleBackGroundColor", typeof(Brush), typeof(EmployeeCard), new PropertyMetadata(new SolidColorBrush((Color) ColorConverter.ConvertFromString("#CCEBFF"))));
        private Employee employee;
        private ImageSource profileImage;

        public Employee Employee
        {
            set
            {
                if (value != null)
                {
                    employee = value;
                    ProfilePhoto = employee.ProfilePhoto;
                    EmployeeEmail = employee.Email;
                    EmployeeAgeAndGender = employee.Age + " years" + "," + employee.Gender.ToString();
                    PhoneNumber = employee.PhoneNumber;
                    EmployeeRole = employee.Role;
                    EmployeeName = employee.FirstName;
                    EmployeeRoleBackGroundColor = FeaturesManager.EmployeeRoleBackGroundColor(employee.Role);
               
                }
            }
            get
            {
                return employee;
            }
        }

        public Brush EmployeeRoleBackGroundColor
        {
            set
            {
                SetValue(EmployeeRoleBackgroundColorProperty, value);
            }
            get
            {
                return (Brush)GetValue(EmployeeRoleBackgroundColorProperty);
            }
        }
        public ImageSource ProfilePhoto
        {
            set
            {

                SetValue(ProfileImageSourceProperty, value);

            }
            get
            {
                return (ImageSource)GetValue(ProfileImageSourceProperty);
            }
        }
        public string EmployeeName
        {
            set
            {
                SetValue(EmployeeNameProperty, value);
            }
            get
            {
                return (string)GetValue(EmployeeNameProperty);
            }
        }
        public string EmployeeAgeAndGender
        {
            set
            {
                SetValue(AgeGenderProperty, value);
            }
            get
            {
                return (string)GetValue(AgeGenderProperty);
            }

        }
        public string PhoneNumber
        {
            set
            {
                SetValue(PhoneNoProperty,"+91 "+ value);
            }
            get
            {
                return (string)GetValue(PhoneNoProperty);
            }
        }
        public string EmployeeEmail
        {
            set
            {
                SetValue(EmailProperty, value);
            }
            get
            {
                return (string)GetValue(EmailProperty);
            }
        }
        public Role EmployeeRole
        {
            set
            {
                SetValue(EmployeeRoleProperty, value);
            }
            get
            {
                return (Role)Enum.Parse(typeof(Role), (string)GetValue(EmployeeRoleProperty));
            }
        }
        public EmployeeCard()
        {
            InitializeComponent();
            DataContext = this;
        }

        public EmployeeCard(Employee employee)
        {
            InitializeComponent();
            DataContext = this;
            Employee = employee;
        }



    }
}
