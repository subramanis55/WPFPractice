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
    /// Interaction logic for EmployeeCard.xaml
    /// </summary>
    public partial class EmployeeCard : UserControl
    {

        public static readonly DependencyProperty ProfileImageSourceProperty = DependencyProperty.Register("ProfileImage", typeof(Image), typeof(EmployeeCard));
        public static readonly DependencyProperty EmployeeNameProperty = DependencyProperty.Register("EmployeeNameTextBlock", typeof(string), typeof(EmployeeCard));
        public static readonly DependencyProperty AgeGenderProperty = DependencyProperty.Register("AgeGenderTextBlock", typeof(string), typeof(EmployeeCard));
        public static readonly DependencyProperty PhoneNoProperty = DependencyProperty.Register("PhoneNoTextBlock", typeof(string), typeof(EmployeeCard));
        public static readonly DependencyProperty EmailProperty = DependencyProperty.Register("EmailTextBlock", typeof(string), typeof(EmployeeCard));
        public static readonly DependencyProperty EmployeeRoleProperty = DependencyProperty.Register("EmployeeRoleTextBox", typeof(string), typeof(EmployeeCard));
        private Employee employee;
        private  Image profileImage;
        public Employee Employee
        {
            set
            {
                employee = value;
                ProfilePhoto = employee.ProfilePhoto;
                Email = employee.Email;
                EmployeeAgeAndGender = employee.Age + "years" + " " + employee.Gender.ToString();
                PhoneNumber = employee.PhoneNumber;
                EmployeeRole = employee.Role;
                EmployeeName = employee.FirstName;
            }
            get
            {
                return employee;
            }
        }
        public Image ProfilePhoto
        {
            set
            {

                SetValue(ProfileImageSourceProperty, value);

            }
            get
            {
                return (Image)GetValue(ProfileImageSourceProperty);
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

        }
        public string PhoneNumber
        {
            set
            {
                SetValue(PhoneNoProperty, value);
            }
            get
            {
                return (string)GetValue(PhoneNoProperty);
            }
        }
        public string Email
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
        public Role EmployeeRole{
        set{
                SetValue(EmployeeRoleProperty,value.ToString());    
        }
        get{
                return (Role)Enum.Parse(typeof(Role),(string)GetValue(EmployeeRoleProperty));
        }
        }
        public EmployeeCard()
        {
            InitializeComponent();

        }
        
        public EmployeeCard( Employee employee)
        {
            InitializeComponent();
            Employee = employee;
        }



    }
}
