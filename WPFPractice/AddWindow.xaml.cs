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
using System.Windows.Shapes;

namespace WPFPractice
{
    /// <summary>
    /// Interaction logic for AddWindow.xaml
    /// </summary>
    public enum Gender
    {
        Male,
        Female,
        Others
    }
    public class EnumToBooleanConverter : IValueConverter
    {         
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null || parameter == null)
                return false;
            return value.Equals(parameter);
        }



        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value.Equals(true))
                return parameter;
            return Binding.DoNothing;
        }


    }
    public partial class AddWindow : Window
    {
        public event EventHandler<Employee> OnClickEmployeeObjectGet;
        private Gender gender;

        public string marrigaeStatus;
        public Gender Gender
        {
            get { return gender; }
            set
            {
                if (gender != value)
                {
                    gender = value;
                }
            }
        }
      
        public string MarrigaeStatus
        {
            get { return marrigaeStatus; }
            set
            {
                if (marrigaeStatus != value)
                {
                    marrigaeStatus = value;
                }
            }
        }

        public AddWindow()
        {
            InitializeComponent();
            DataContext = this;
            RoleComboBox.ItemsSource = EmployeeManager.RoleSource;
            DegreeComboBox.ItemsSource = Enum.GetNames(typeof(Degree)).ToList();
            JoinDatePicker.SelectedDate = DateTime.Now;
             DateOfBirthPicker.SelectedDate = DateTime.Now;
            SalaryTextBox.Text = ""+10000;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TextRange textRange = new TextRange(AddressTextBox.Document.ContentStart,AddressTextBox.Document.ContentEnd);
            Employee employee = new Employee()
            {

                FirstName = FirstNameTextBox.Text,
                LastName = LastNameTextBox.Text,
                DateOfBirth = (DateTime)DateOfBirthPicker.SelectedDate,
                Gender = this.Gender,
                MarriageStatus = this.MarrigaeStatus,
                PhoneNumber = PhoneNumberTextBox.Text,
                AadharNumber = AdharCardNumberTextBox.Text,
                Email = EmailTextBox.Text,
                Address = textRange.Text,
                Role = (Role)Enum.Parse(typeof(Role), RoleComboBox.SelectedItem.ToString()),
                JoinDateTime = (DateTime)JoinDatePicker.SelectedDate,
                Salary = int.Parse(SalaryTextBox.Text),
                EmployeeId = EmployeeIdTextBox.Text,
                CollageName = CollageTextBox.Text,
                Degree = (Degree)Enum.Parse(typeof(Degree), DegreeComboBox.SelectedItem.ToString()),
                DegreeSpecification = DegreeSpecificationTextBox.Text,
                //BankName = dataTable.Rows[i]["BankName"].ToString(),
                //BankIFSCCode = dataTable.Rows[i]["BankIFSCCode"].ToString(),
                //AccountNumber = dataTable.Rows[i]["AccountNumber"].ToString(),
                //PanCardNumber = dataTable.Rows[i]["PanCardNumber"].ToString(),
                //IsExEmployee = Convert.ToBoolean(dataTable.Rows[i]["IsExEmployee"].ToString())
            };
            OnClickEmployeeObjectGet?.Invoke(this,employee);
        }

        private void CloseBtnClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {

        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void MarriageStatusRadioButtonChecked(object sender, RoutedEventArgs e)
        {
            RadioButton radioButton = (RadioButton)(sender);
            MarrigaeStatus =""+ radioButton.Content;
        }
    }
}
