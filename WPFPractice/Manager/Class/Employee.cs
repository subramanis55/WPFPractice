using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WPFPractice
{
    public class Employee
    {
        public int Id;
        public string EmployeeId;
        private DateTime experience=DateTime.MinValue; 
        public string FirstName;
        public string LastName;
        public int Age;
        public Role Role;
        public int Salary;
        public string MarriageStatus;
        public System.Windows.Media.ImageSource ProfilePhoto; 
        public DateTime JoinDateTime;
        public string PhoneNumber;
        public string Email;
        public string AadharNumber;
        private DateTime dateOfBirth;
        public string Address;
        public string CollageName;
        public Degree Degree;
        public string DegreeSpecification;
        public string BankName;
        public string BankIFSCCode;
        public string AccountNumber;
        public string PanCardNumber;
        public Gender Gender;
        public bool IsExEmployee;
        public DateTime DateOfBirth{
            set{
                dateOfBirth = value;
                Age = GetAge();
            }
            get{
                return dateOfBirth;
            }
        }
        public DateTime Experience{
        set{
                experience = value;
        }
        get{
                if(experience.Year!= (DateTime.Now.Year - JoinDateTime.Year)&& experience.Month!=(DateTime.Now.Month - JoinDateTime.Month)&& experience.Day != (DateTime.Now.Day - JoinDateTime.Day))
                Experience= new DateTime(DateTime.Now.Year - JoinDateTime.Year, DateTime.Now.Month - JoinDateTime.Month, DateTime.Now.Day - JoinDateTime.Day);
                return Experience; 
        }
        }
        
      
        private int GetAge(){
            int value = DateTime.Now.Year-DateOfBirth.Year ;
            if ((DateOfBirth.Day <= DateTime.Now.Day && DateOfBirth.Month == DateTime.Now.Month)|| (DateOfBirth.Month < DateTime.Now.Month))
            {
                return value;
            }
            return value - 1;
        }
    }
}
